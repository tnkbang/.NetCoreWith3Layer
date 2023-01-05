using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;
using DAL.Repositories.Contracts;
using BLL.Services.Contracts;

namespace BLL.Services
{
    public class NguoiDungServices : INguoiDungServices
    {
        private readonly IGenericRepository<NguoiDung> repositories;

        public NguoiDungServices(IGenericRepository<NguoiDung> nd)
        {
            repositories = nd;
        }

        public async Task<List<NguoiDung>> GetNguoiDungs()
        {
            try
            {
                return await repositories.GetList();
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
                return await repositories.GetNguoiDung(id);
            }
            catch
            {
                throw;
            }
        }

        public void CreateNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                repositories.Create(nguoiDung);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                repositories.Update(nguoiDung);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                repositories.Delete(nguoiDung);
            }
            catch
            {
                throw;
            }
        }
    }
}
