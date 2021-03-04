using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System.Text.Json;

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
  }
}