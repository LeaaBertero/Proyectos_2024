using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuarios>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Context Context) : base(Context)
        {

        }
    }
}
