using CRUDBlazorWASM.Server.Services;
using CRUDBlazorWASM.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
