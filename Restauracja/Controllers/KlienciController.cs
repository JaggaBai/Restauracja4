using Microsoft.AspNetCore.Mvc;
using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers
{
    public class KlienciController : Controller
    {
        private readonly RestDbContext _context;
        public KlienciController(RestDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Klienci.ToList();
            return View(data);
        }
    }
}
