using CRUDBlazorWASM.Server.Models;
using CRUDBlazorWASM.Shared;
using Microsoft.EntityFrameworkCore;

namespace CRUDBlazorWASM.Server.Services
{
    public class GestionUsuarios : IUsuario
    {
        private readonly DbCrudwasmContext _dbcontext;

        public GestionUsuarios(DbCrudwasmContext dbcontext)
        {
             _dbcontext = dbcontext;
        }

        public async Task<List<Usuario>> DatosUsuarios()
        {
            try
            {
               return await _dbcontext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<Usuario> DatosUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task ActualizarUsuario(IUsuario u)
        {
            throw new NotImplementedException();
        }

        public async Task BorrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task NuevoUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}
