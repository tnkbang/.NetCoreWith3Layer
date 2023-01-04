using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;

namespace DAL.Repositories.Contracts
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        Task<List<TModel>> GetNguoiDungs();
    }
}
