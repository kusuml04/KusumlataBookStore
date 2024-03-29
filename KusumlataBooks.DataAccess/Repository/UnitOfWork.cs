﻿using KusumlataBooks.DataAccess.Repository.IRepository;
using KusumlataBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using KusumlataBooks.DataAccess.Repository;
using KusumlataBookStore.DataAccess.Repository;

namespace KusumlataBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //make the method public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statement
        public UnitOfWork(ApplicationDbContext db)// constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRespository(_db);
            SP_Call = new SP_Call(_db);
            Cover = new CoverTypeRepository(_db);
            ProductRepository = new ProductRepository(_db);


        }

        public ICategoryRepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository Cover { get; private set; }
        public ProductRepository ProductRepository { get; }
        public IProductRepository Product { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();//All the changes will be saved when the save methods is called at the parent leave.
        }
    }
}