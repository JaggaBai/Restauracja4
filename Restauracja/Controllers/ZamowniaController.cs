using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers //Zastosowanie asynchronous tasks->async do zamówień 
{
    public class ZamowniaController : Controller
    {
        private readonly RestDbContext _context;
        public ZamowniaController(RestDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Zamownia.ToListAsync();
            return View(data);
        }
    }
}
