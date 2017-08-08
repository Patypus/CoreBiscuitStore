using CoreBiscuitStoreDomain.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CoreBiscuitStoreDomain.Dtos;
using CoreBiscuitStoreData;
using CoreBiscuitStoreData.Repository.Resolver;

namespace CoreBiscuitStoreDomain.Facades
{
    public class BiscuitFacade : IBiscuitFacade
    {
        private readonly IRepositoryResolver _repositoryResolver;

        public BiscuitFacade(IRepositoryResolver repositoryResolver)
        {
            _repositoryResolver = repositoryResolver;
        }
        
        public IEnumerable<BiscuitDto> GetAllBiscuitTypes()
        {
            throw new NotImplementedException();
        }

        //https://www.codeproject.com/Articles/1151842/Using-MongoDB-NET-Driver-with-NET-Core-WebAPI
    }
}
