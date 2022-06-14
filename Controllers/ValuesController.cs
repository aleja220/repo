using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication44.Modelo;

namespace WebApplication44.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Aplication_oneContext _db;

        public ValuesController(Aplication_oneContext db)
        {
            _db = db;
           


        }

        [HttpGet]
        public async Task<IActionResult> GetDisciplina()
        {
            var List = await _db.TableDisciplinas.OrderBy(T => T.DisciplinaDeportiva).ToListAsync();

            return Ok(List);
        }



    }

}
