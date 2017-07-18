using CoreBiscuitStoreDomain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBiscuitStoreDomain.Facades.Interfaces
{
    public interface IBiscuitFacade
    {
        BiscuitDto GetAllBiscuitTypes();
    }
}
