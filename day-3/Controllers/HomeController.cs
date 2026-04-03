using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using day_3.Models;

namespace day_3.Controllers;

public class HomeController(ILogger<HomeController> logger,AppDbContext context) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly AppDbContext _context = context;

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Items()
    {
        var items = _context.Items.ToList();
        var price = _context.Items.Sum(item => item.Value);
        ViewBag.Price = price;
        return View(items);
    }
    public IActionResult CreatAndEdit( int? id)
    {
        if (id != null)
        {
          var item =  _context.Items.SingleOrDefault(item => item!.Id == id);
          return View(item);
        }
        return View();
    }
    public IActionResult CreatAndEditForm( Item modle)
    {
        if (modle.Id == 0)
        {
            _context.Items.Add(modle);
           
        }
        else
        {
            _context.Items.Update(modle);
        }
        _context.SaveChanges();
        return RedirectToAction("Items");
 
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Delete(int id)
    {
        _context.Items.Remove(_context.Items.SingleOrDefault(item =>item != null && item.Id == id ));
        _context.SaveChanges();
        return RedirectToAction("Items");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
