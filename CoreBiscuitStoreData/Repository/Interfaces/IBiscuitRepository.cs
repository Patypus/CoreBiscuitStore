using CoreBiscuitStoreData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreBiscuitStoreData.Repository.Interfaces
{
    public interface IBiscuitRepository
    {
        Task<IEnumerable<Biscuit>> GetAllBiscuits();
    }
}
