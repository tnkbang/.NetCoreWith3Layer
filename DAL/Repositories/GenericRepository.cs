using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DataContext;
using DAL.Models;
using DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly DayHocTrucTuyenContext db;

        public GenericRepository(DayHocTrucTuyenContext _db)
        {
            db = _db;
        }
        public async Task<List<TModel>> GetNguoiDungs()
        {
            try
            {
                return await db.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
