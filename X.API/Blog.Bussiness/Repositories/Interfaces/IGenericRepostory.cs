using Blog.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness.Repositories.Interfaces
{
    public interface IGenericRepostory<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
        IQueryable<T> GetAll(bool noTracking = true);
        Task CreateAscyn(T data);
        Task SaveAscyn();
    }
}
