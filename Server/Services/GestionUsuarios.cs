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
            try
            {
                Usuario? u = await _dbcontext.Usuarios.FindAsync(id);
                if(u != null)
                {
                    return u;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task NuevoUsuario(Usuario u)
        {
            try
            {
                u.FechaIngreso = DateTime.Now;
                await _dbcontext.Usuarios.AddAsync(u);
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task ActualizarUsuario(Usuario u)
        {
            try
            {
                Usuario? us = await _dbcontext.Usuarios.FindAsync(u.IdUsuario);
                if (us != null)
                {
                    us.Nombre = u.Nombre;
                    us.Apellido = u.Apellido;
                    us.Telefono = u.Telefono;
                    us.Email = u.Email;

                    _dbcontext.ChangeTracker.Clear();//--> Opcion sustituye AsNoTRacking() con EF, limpia el objeto que esta siendo tracking(Validar mejor opcion)
                    _dbcontext.Entry(us).State = EntityState.Modified;
                    await _dbcontext.SaveChangesAsync();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task BorrarUsuario(int id)
        {
            try
            {
                Usuario? u = await _dbcontext.Usuarios.FindAsync(id);
                if (u != null)
                {
                    _dbcontext.ChangeTracker.Clear();
                    _dbcontext.Usuarios.Remove(u);
                    await _dbcontext.SaveChangesAsync();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        
    }
}
