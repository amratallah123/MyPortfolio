using Core.Interfaces;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataDbContext _context;
        private IGenericRepository<T> _genericRepository;
        public UnitOfWork(DataDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> Repository
        {
            get
            {   
                return _genericRepository ?? (_genericRepository = new GenericRepository<T>(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
