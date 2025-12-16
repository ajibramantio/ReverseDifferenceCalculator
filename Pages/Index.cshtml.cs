using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReverseDifferenceCalculator.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? InputNumber { get; set; }
    
    public string? ReversedNumber { get; set; }
    public int Difference { get; set; }
    public bool HasResult { get; set; }

    public void OnGet()
    {
        HasResult = false;
    }

    public IActionResult OnPost()
    {
        if (string.IsNullOrWhiteSpace(InputNumber))
        {
            HasResult = false;
            return Page();
        }

        // Remove any non-digit characters (extra safety)
        string cleanedInput = new string(InputNumber.Where(char.IsDigit).ToArray());
        
        if (string.IsNullOrEmpty(cleanedInput))
        {
            HasResult = false;
            return Page();
        }

        // Parse the number
        if (int.TryParse(cleanedInput, out int originalNumber))
        {
            // Calculate reverse
            int reversed = ReverseNumber(originalNumber);
            ReversedNumber = reversed.ToString();
            
            // Calculate absolute difference (always positive)
            Difference = Math.Abs(originalNumber - reversed);
            
            InputNumber = originalNumber.ToString();
            HasResult = true;
        }
        else
        {
            HasResult = false;
        }

        return Page();
    }

    private int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return reversed;
    }
}
