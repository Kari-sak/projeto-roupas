using ProjetoRoupas.Models;

namespace ProjetoRoupas.Persistence.Repository
{
    public interface IRoupaRepository

    {
        Roupas GetById(int id);
        IEnumerable <Roupas> GetAll();
        void Add(Roupas entity);
        void Update(Roupas entity);
        void Delete(Roupas entity);

    }
}
