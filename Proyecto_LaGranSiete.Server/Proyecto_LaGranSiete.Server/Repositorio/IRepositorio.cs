using Proyecto_LaGranSiete.BD.Data;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public interface IRepositorio<E> where E : class, IEntityBase
    {
        Task<bool> Borrar(int id);
        Task<bool> Existe(int id);
        Task<List<E>> Insert();
        Task<int> Insert(E entidad);
        Task<E> SelectById(int id);
        Task<bool> Update(int id, E entidad);
    }
}