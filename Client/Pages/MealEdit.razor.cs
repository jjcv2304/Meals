using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using Meals.Client;
using Meals.Client.Shared;
using System.Text.Json;

namespace Meals.Client.Pages
{
  public partial class MealEdit
  {
    private MealEditVM mealEditVM = new MealEditVM();
    private EditContext editContext;

    protected override void OnInitialized()
    {
      editContext = new EditContext(mealEditVM);
    }

    private void HandleValidSubmit()
    {
      var modelJson = JsonSerializer.Serialize(mealEditVM, new JsonSerializerOptions { WriteIndented = true });
      JSRuntime.InvokeVoidAsync("alert", $"SUCCESS!! :-)\n\n{modelJson}");
    }

    private void HandleReset()
    {
      mealEditVM = new MealEditVM();
      editContext = new EditContext(mealEditVM);
    }
  }
}