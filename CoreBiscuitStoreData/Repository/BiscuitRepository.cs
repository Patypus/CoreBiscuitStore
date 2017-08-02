using CoreBiscuitStoreData.Repository.Interfaces;
using System.Collections.Generic;
using CoreBiscuitStoreData.Entities;
using CoreBiscuitStoreData.Context;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CoreBiscuitStoreData.Repository
{
    public class BiscuitRepository : IRepository<Biscuit>
    {
        private readonly IBiscuitStoreContext _context;

        public BiscuitRepository(IBiscuitStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Biscuit>> GetAll()
        {
            return await _context.Biscuits.Find(new BsonDocument()).ToListAsync();
        }
    }
}