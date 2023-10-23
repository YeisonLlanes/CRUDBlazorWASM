using CRUDBlazorWASM.Shared;

namespace CRUDBlazorWASM.Server.Services
{
    public interface IUsuario
    {
        Task<List<Usuario>> DatosUsuarios();

        Task NuevoUsuario(Usuario u);

        Task ActualizarUsuario(IUsuario u);

        Task<Usuario> DatosUsuario(int id);

        Task BorrarUsuario(int id);
    }
}
