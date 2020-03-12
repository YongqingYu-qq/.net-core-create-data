using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Core_mvc.Data;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Controllers
{
    public class PositionsController : Controller
    {
        private readonly MvcMovieContext _context;
        public PositionsController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Position.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Positions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionId,PositionName")] Position position)
        {
            if (ModelState.IsValid)
            {
                _context.Add(position);
                await _context.SaveChangesAsync();
                return PartialView("_PositionList", _context.Position.ToList());
            }
            return View(position);
        }
    }
}