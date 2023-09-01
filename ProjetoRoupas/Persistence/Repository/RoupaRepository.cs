using ProjetoRoupas.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoRoupas.Persistence.Repository
{
    public class RoupaRepository : IRoupaRepository

    {
        private readonly OracleDbContext _dbContext;

        public RoupaRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Roupas GetById(int id) 
        {
            return _dbContext.Roupas.Find(id);
        }

        public IEnumerable<Roupas> GetAll() 
        {
            return _dbContext.Roupas.ToList();
        }

        public void Add(Roupas entity)
        {
            _dbContext.Roupas.Add(entity);
            _dbContext.SaveChanges();
        }  

        public void Update(Roupas entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Roupas entity)
        {
            _dbContext.Roupas.Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}
