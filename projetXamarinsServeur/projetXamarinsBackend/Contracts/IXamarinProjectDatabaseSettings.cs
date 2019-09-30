using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetXamarinsBackend.Contracts
{
    public interface IXamarinProjectDatabaseSettings
    {
        string MoviesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
