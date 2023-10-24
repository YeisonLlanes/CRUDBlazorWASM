using CRUDBlazorWASM.Server.Services;
using CRUDBlazorWASM.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CRUDBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuarioService;

        public UsuarioController(IUsuario UsuarioService)
        {
            _usuarioService = UsuarioService;
        }


        [HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Usuario>> GetUsuarios()
        {
            //return Ok(await _usuarioService.DatosUsuarios());
            return await _usuarioService.DatosUsuarios();
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> ObtenerUsuario(int id)
        {
            Usuario u = await _usuarioService.DatosUsuario(id);
            if(u != null)
            {
                return Ok(u);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task CreateUser(Usuario usuario)
        {
            await _usuarioService.NuevoUsuario(usuario);
        }

        [HttpPut]
        public async Task UpdateUser(Usuario usuario)
        {
            await _usuarioService.ActualizarUsuario(usuario);
        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteUSer(int id)
        {
            await _usuarioService.BorrarUsuario(id);
            return Ok();
        }


    }
}
