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
    public class NguoiDungRepository<NguoiDungs> : INguoiDungRepository<NguoiDungs> where NguoiDungs : class
    {
        private readonly DayHocTrucTuyenContext db;

        public NguoiDungRepository(DayHocTrucTuyenContext _db)
        {
            db = _db;
        }

        public async Task<List<NguoiDung>> GetList()
        {
            try
            {
                return await db.Set<NguoiDung>().ToListAsync();
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

        public void Create(NguoiDung model)
        {
            try
            {
                db.Set<NguoiDung>().Add(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(NguoiDung model)
        {
            try
            {
                db.Set<NguoiDung>().Update(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Delete(NguoiDung model)
        {
            try
            {
                db.Set<NguoiDung>().Remove(model);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
