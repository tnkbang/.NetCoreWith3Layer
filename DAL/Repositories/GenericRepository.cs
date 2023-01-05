using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public async Task<List<TModel>> GetList()
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

        public async Task<NguoiDung> GetNguoiDung(string id)
        {
            try
            {
                var nd = await db.NguoiDungs.FirstOrDefaultAsync(x => x.MaNd == id);
                if (nd != null) return nd;
                return new NguoiDung();
            }
            catch
            {
                throw;
            }
        }

        public void Create(TModel model)
        {
            try
            {
                db.Set<TModel>().Add(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(TModel model)
        {
            try
            {
                db.Set<TModel>().Update(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Delete(TModel model)
        {
            try
            {
                db.Set<TModel>().Remove(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
