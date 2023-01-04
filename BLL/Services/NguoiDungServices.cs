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
                return await repositories.GetNguoiDungs();
            }
            catch
            {
                throw;
            }
        }
    }
}
