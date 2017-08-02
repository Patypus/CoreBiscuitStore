using CoreBiscuitStoreCommon.Settings;
using CoreBiscuitStoreData.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBiscuitStoreData.Repository.Resolver
{
    public class RepositoryResolver : IRepositoryResolver
    {
        private readonly ApplicationConfiguration _configuration;

        public RepositoryResolver(ApplicationConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IRepository<T> GetRepository<T>()
        {
            throw new NotImplementedException();
        }
    }
}