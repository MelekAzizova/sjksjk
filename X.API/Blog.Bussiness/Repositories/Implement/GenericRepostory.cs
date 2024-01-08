using Blog.Bussiness.Repositories.Interfaces;
using Blog.Core.Entities.Common;
using Blog.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Repositories.Implement
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseEntity
    {
        public GenericRepostory(BlogContext db)
        {
            _db = db;
        }

        BlogContext _db { get; }
        public DbSet<T> Table => _db.Set<T>();

        public IQueryable<T> GetAll(bool noTracking=true)
             => noTracking ? Table.AsNoTracking() : Table;

        public async Task CreateAscyn(T data)
        {
             await Table.AddAsync(data);
        }

        public async Task SaveAscyn()
        {
            await _db.SaveChangesAsync();
        }
    }
}
