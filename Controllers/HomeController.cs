using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PopupsWebWithAjax.Data;
using PopupsWebWithAjax.Models;

namespace PopupsWebWithAjax.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly PostDbContext _context;

    public HomeController(ILogger<HomeController> logger, PostDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Post()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Post(Post post)
    {
        post.PublishedOn = DateTime.Now;
        // Save data to the database
        _context.Posts.Add(post);
        _context.SaveChanges();

        // Return a response (success or error)
        return Redirect("/");
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
