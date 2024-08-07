using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuarios>, IUsuarioRepositorio
    {
        //constructor de la interfáz de la clase (Repositorio)
        //que tiene como base , la herencia del context (Base de datos)
        public UsuarioRepositorio(Context Context) : base(Context)
        {

        }
    }
}
