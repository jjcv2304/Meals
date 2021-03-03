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

namespace Meals.Client.Components
{
  public partial class VoteWithStars
  {
    [Parameter]
    public int NumberOfStarts { get; set; }

    private int NumberOfStartsSelected { get; set; }

    private void StarClicked(int index)
    {
      NumberOfStartsSelected = index+1;
    }
  }
}