using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Assignment.EfCore;
using Code.Assignment.Models.StarWars;
using Microsoft.EntityFrameworkCore;

namespace Code.Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediController : ControllerBase
    {
        private readonly ILogger<JediController> _logger;
        private readonly AssignmentDBContext _context;

        public JediController(ILogger<JediController> logger, AssignmentDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async ValueTask<IEnumerable<Jedi>> Get()
        {
            return await _context.Jedi.Include(s=>s.LightSaber).ToListAsync();
        }
    }
}
