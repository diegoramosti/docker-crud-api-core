using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Entity;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly MyDbContext _context;

        public AutorController(MyDbContext context)
        {
            this._context = context;
            if (_context.AutorItems.Count() == 0)
            {
                _context.AutorItems.Add(new Autor { Nome = "Mario Cabral" , Email =  "teste@uol.com.br", Senha = "123456789"});
                _context.SaveChanges();
            }

        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return Ok(_context.AutorItems.ToList());
        }

        [HttpPost]
        public ActionResult<IEnumerable<Autor>> Post(Autor autor)
        {
            try
            {
                _context.AutorItems.Add(autor);
                _context.SaveChanges();
                return Ok(_context.AutorItems.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}
