using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreBiscuitStoreData.Repository.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Gets all entities of the type the interface has.
        /// </summary>
        /// <returns>Task to resolve the enumerable of all entities in the repository</returns>
        Task<IEnumerable<T>> GetAll();
    }
}
