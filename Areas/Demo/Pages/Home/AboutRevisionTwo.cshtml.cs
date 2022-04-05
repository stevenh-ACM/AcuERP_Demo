
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcuERP_Demo.Areas.Demo.Pages.Home;

public class AboutRevisionTwoModel : PageModel
{
    private readonly ILogger<AboutRevisionTwoModel> _logger;

    public AboutRevisionTwoModel(ILogger<AboutRevisionTwoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public int DisplayNumOfEmployees { get; set; }

    [BindProperty]
    public double DisplayTotalRevenue { get; set; }

    [BindProperty]
    public string DisplayStartYear { get; set; }

    public void OnGet()
    {
        YearValue();
        EmpValue();
        RevValue();        
    }

    public string YearValue() 
    {
        var rand = new Random();
        return DisplayStartYear = (rand.Next(2,10) + 2008).ToString();
    }
    public int EmpValue()
    {
        var rand = new Random();
        return DisplayNumOfEmployees = rand.Next(50, 151);
    }
    public double RevValue()
    {
        var rand = new Random();
        return DisplayTotalRevenue = Math.Round((rand.NextDouble() * 113) + 50, 0);
    }
}

