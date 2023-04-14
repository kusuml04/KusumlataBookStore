using System;
using System.Collections.Generic;
using System.Text;

namespace KusumlataBooks.DataAccess.Repository.IRepository
{
   public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
        ICoverTypeRepository Cover { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
