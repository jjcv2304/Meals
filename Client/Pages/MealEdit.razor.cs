using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Meals.Client.Pages
{
  public partial class MealEdit
  {
    private MealEditVM _mealEditVm = new MealEditVM();
    private EditContext _editContext;

    protected override void OnInitialized()
    {
      _editContext = new EditContext(_mealEditVm);
    }

    private void HandleValidSubmit()
    {
      var modelJson = JsonSerializer.Serialize(_mealEditVm, new JsonSerializerOptions { WriteIndented = true });
      JsRuntime.InvokeVoidAsync("alert", $"SUCCESS!! :-)\n\n{modelJson}");
    }

    private void HandleReset()
    {
      _mealEditVm = new MealEditVM();
      _editContext = new EditContext(_mealEditVm);
    }

    private Dictionary<IBrowserFile, string> loadedFiles = new Dictionary<IBrowserFile, string>();
    private IBrowserFile browserFile;
    private string loadedFileContent;
    private long maxFileSize = 5000000;

    string imgUrl = string.Empty;
    private char[] content;

    private async Task OnFileSelection(InputFileChangeEventArgs e)
    {
      IBrowserFile imgFile = e.File;
      var buffers = new byte[imgFile.Size];
      await imgFile.OpenReadStream(maxFileSize).ReadAsync(buffers);
      string imageType = imgFile.ContentType;
      imgUrl = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";

      //todo
      //IBrowserFile file = e.File;
      //  //var buffers = new byte[imgFile.Size];
      //  using var reader = new StreamReader(file.OpenReadStream(maxFileSize));
      //  await reader.ReadAsync(content);
      //  string imageType = file.ContentType;
      //  imgUrl =$"data:{imageType};base64,{Convert.ToBase64String(loadedFileContent)}";
    }

    //async Task LoadFiles(InputFileChangeEventArgs inputFileChangeEventArgs)
    //{
    //  int maxAllowedFiles = 1;

    //  loadedFiles.Clear();
    //  var exceptionMessage = string.Empty;

    //  try
    //  {
    //    foreach (var file in inputFileChangeEventArgs.GetMultipleFiles(maxAllowedFiles))
    //    {
    //      using var reader =
    //          new StreamReader(file.OpenReadStream(maxFileSize));

    //      browserFile = file;
    //      loadedFileContent = await reader.ReadToEndAsync();
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    exceptionMessage = ex.Message;
    //  }

    //}
  }
}