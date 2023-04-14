using System.Linq;
using KusumlataBookStore.DataAccess.Data;
using KusumlataBooks.DataAccess.Repository;
using KusumlataBooks.DataAccess.Repository.IRepository;
using KusumlataBooks.Models;





namespace KusumlataBookStore.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}