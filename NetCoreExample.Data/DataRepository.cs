using NetCoreExample.Data.Contracts;
using System;

namespace NetCoreExample.Data
{
    public class DataRepository : IDataRepository
    {
        public string Get()
        {
            return "Repodan dönüyor";
        }
    }
}
