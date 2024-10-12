using BoardgameShopASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BoardgameShopASPNET.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        //������� ������������, ����� ����������� �������� ������ �� ��
        public async Task<IActionResult>Index()
        {
            int countOfImgsIgroteka = 6;
            ViewBag.CountOfImgsIgroteka = countOfImgsIgroteka;
            ViewBag.CountOfHiBlockIgroteka = 5;
            return View(await _context.Users.ToListAsync());
            //View ���������� � �������� ������ ������
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
}
