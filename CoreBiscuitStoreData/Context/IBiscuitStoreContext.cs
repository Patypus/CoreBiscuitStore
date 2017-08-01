using CoreBiscuitStoreData.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBiscuitStoreData.Context
{
    public interface IBiscuitStoreContext
    {
        IMongoCollection<Biscuit> Biscuits { get;  }
    }
}
