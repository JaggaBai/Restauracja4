using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restauracja.Data;
using Restauracja.Data.Services;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers
{
    public class PozycjeZamowieniaController : Controller
    {
        private readonly IPozycjeZamowieniaService _service;
        public PozycjeZamowieniaController(IPozycjeZamowieniaService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _service.PobierzWszystkieAsync();
            return View(res);
        }
        //[HttpGet]
        //[Route("Filter/{searchString}")]
        public async Task<IActionResult> Filter(string searchString)
        {
            var res = await _service.PobierzWszystkieAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filtrowanie = res.Where(n => n.Nazwa.Contains(searchString)).ToList();
                return View("Index", filtrowanie);
            }
            return View("Index", res);

            }
       
        //public IActionResult DodajwMenu() //get drugi ścieżka pz/DodajwMenu
        //{
        //    return View();
        //}

        public async Task <IActionResult> DodajwMenu([Bind("Nazwa, Id, Cena")] PozycjaZamowienia pozycjaZamowienia)
        {
            if (!ModelState.IsValid)
            {
                return View(pozycjaZamowienia);
            }
            await _service.DodajAsync(pozycjaZamowienia);
            return RedirectToAction(nameof(Index));
        }
        //public Task<ActionResult> Znajdzpoid(int id)
        //{
          
            
        //}

    }
    }

