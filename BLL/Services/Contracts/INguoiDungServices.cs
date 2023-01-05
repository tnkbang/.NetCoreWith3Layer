using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;

namespace BLL.Services.Contracts
{
    public interface INguoiDungServices
    {
        Task<List<NguoiDung>> GetNguoiDungs();

        void CreateNguoiDung(NguoiDung nguoiDung);

        void UpdateNguoiDung(NguoiDung nguoiDung);

        void DeleteNguoiDung(NguoiDung nguoiDung);

        Task<NguoiDung> GetNguoiDung(string id);
    }
}
