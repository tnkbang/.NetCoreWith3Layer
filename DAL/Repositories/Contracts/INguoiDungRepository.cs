using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;

namespace DAL.Repositories.Contracts
{
    public interface INguoiDungRepository<NguoiDungs> where NguoiDungs : class
    {
        Task<List<NguoiDung>> GetList();

        void Create(NguoiDung model);

        void Update(NguoiDung model);

        void Delete(NguoiDung model);

        Task<NguoiDung> GetNguoiDung(string id);
    }
}
