using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using docextractor.Models;
using Mammoth;
namespace docextractor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var converter = new DocumentConverter();
        var result = converter.ConvertToHtml("D:/Binary/Documents/mohamed's resume.docx");
        var html = result.Value; // The generated HTML
        var warnings = result.Warnings; // Any warnings during conversion
        Console.WriteLine(warnings);
        ViewData["Html"]=html;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
