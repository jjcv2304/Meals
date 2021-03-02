using System;
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
using Meals.Shared;
using static System.Net.WebRequestMethods;

namespace Meals.Client.Pages
{
  public partial class FetchData 
  {

    [Inject]
    protected HttpClient Http { get; set; }

    protected WeatherForecast[] Forecasts { get; private set; }

    protected override async Task OnInitializedAsync()
    {
      Forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
  }
}