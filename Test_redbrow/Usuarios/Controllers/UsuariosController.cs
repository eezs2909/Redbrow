using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models;

namespace Usuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UsuariosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("Consulta")]
        public async Task<ActionResult<IEnumerable<Usuario>>>Get()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpGet("ID")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            return await context.Usuarios.Where(x=> x.id == id).FirstOrDefaultAsync();
        }

        [HttpPost("Alta")]
        public async Task<ActionResult> Post(Usuario usuario)
        {

            context.Add(usuario);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpPost("AltaMultiple")]
        public async Task<ActionResult> Post(Usuario[] usuarios)
        {
            context.AddRange(usuarios);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("Cambio")]
        public async Task<ActionResult> Update(Usuario usuarios)
        {
            context.Update(usuarios);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("Baja")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuario = new Usuario {id = id };
            context.Remove(usuario);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
