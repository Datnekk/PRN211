﻿using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;

namespace PRN211_HE170436_Project.Components
{
    public class Navbar : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Navbar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() {  

            return View(_context.Categories.ToList());
            
        }
    }
}
