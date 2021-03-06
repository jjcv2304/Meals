using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Meals.Client.Components
{
  public partial class VoteWithStars
  {
    /// <summary>
    /// Defines the maximum number of votes to show, represented as stars
    /// </summary>
    [Parameter]
    public int NumberOfStarts { get; set; }

    private int _value;

    /// <summary>
    /// Number of votes/stars that will be selected
    /// </summary>
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
    /// <summary>
    /// Notifys changes on the number of votes/stars selected
    /// </summary>
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