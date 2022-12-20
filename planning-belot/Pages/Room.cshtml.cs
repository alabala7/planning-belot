using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace planning_belot.Pages;

public class RoomModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public readonly List<int> Fibbonacci;

    public RoomModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Fibbonacci = getFibbonacciNumbers(6).ToList();
    }

    public void OnGet()
    {

    }


    private IEnumerable<int> getFibbonacciNumbers(int num)
    {
        int prev = 1;
        int beforePrev = 0;
        for (int i = 0; i < num; i++)
        {
            var res = prev + beforePrev;
            yield return res;
            beforePrev = prev;
            prev = res;
        }
    }
}
