using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restauracja.Data;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers
{
    public class KlienciController : Controller
    {
        private readonly RestDbContext _context;
        private readonly IMapper _mapper;
        public KlienciController(RestDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<KlientDto>> Pobierz()
        {
            var data = _context.Klienci.ToList();

            var datadto = _mapper.Map<List<KlientDto>>(data);
            return Ok(datadto);
        }


        public IActionResult Index()
    {
        var data = _context.Klienci.ToList();
        return View(data);
    }


}


}