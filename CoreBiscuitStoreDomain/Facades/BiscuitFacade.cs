using CoreBiscuitStoreDomain.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CoreBiscuitStoreDomain.Dtos;
using CoreBiscuitStoreData;

namespace CoreBiscuitStoreDomain.Facades
{
    public class BiscuitFacade : IBiscuitFacade
    {
        //how to inject into something being injected into something else in a different project?

        //and how to mock it for unit testing
        private readonly IRepositoryFactory _repositoryFacatory;

        public BiscuitFacade(IRepositoryFactory repositoryFactory)
        {
            _repositoryFacatory = repositoryFactory;
        }


        public IEnumerable<BiscuitDto> GetAllBiscuitTypes()
        {
            throw new NotImplementedException();
        }
    }
}
