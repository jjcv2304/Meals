using Microsoft.AspNetCore.Components;


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

    private bool IsStarChecked(int starIndex)
    {
      return starIndex < NumberOfStartsSelected;
    }
  }
}