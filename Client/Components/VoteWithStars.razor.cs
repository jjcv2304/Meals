using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Meals.Client.Components
{
  public partial class VoteWithStars
  {

    [Parameter]
    public int NumberOfStarts { get; set; }

    private int _value;

    [Parameter]
    public int NumberOfStartsSelected
    {
      get => _value;
      set
      {
        if (_value == value) return;
        _value = value;
        NumberOfStartsSelectedChanged.InvokeAsync(value);
      }
    }

    [Parameter]
    public EventCallback<int> NumberOfStartsSelectedChanged { get; set; }

    void StarClicked(int index)
    {
      NumberOfStartsSelected = index + 1;
    }

    private bool IsStarChecked(int starIndex)
    {
      return starIndex < NumberOfStartsSelected;
    }
  }
}