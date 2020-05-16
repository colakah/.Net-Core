using NetCoreExample.Business.Contracts;
using NetCoreExample.Data.Contracts;
using System;

namespace NetCoreExample.Business
{
    public class BusinessEngine : IBusinessEngine
    {
        private IDataRepository _IDataRepository;
        public BusinessEngine(IDataRepository IDataRepository)
        {
            _IDataRepository = IDataRepository;
        }
        public string Get()
        {
            return _IDataRepository.Get();
        }
    }
}
