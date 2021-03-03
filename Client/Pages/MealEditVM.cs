using System;
using System.ComponentModel.DataAnnotations;

namespace Meals.Client.Pages
{
  internal class MealEditVM
    {

      [Required]
      [Display(Name = "Meal Name")]
      public string Name { get; set; }

      [Display(Name = "Meal Description")]
      public string Description { get; set; }

      [Display(Name = "Meal Link information")]
      public string Reference { get; set; }

      [Required]
      [Range(0, 5, ErrorMessage = "Vote should be between 0 and 5")]
      public string Vote { get; set; }

      [Display(Name = "Meal Tags")]
      public string Tags { get; set; }
    }
  }