using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetXamarinsBackend.Contracts;

namespace projetXamarinsBackend.Models
{
    public class XamarinProjectDatabaseSettings : IXamarinProjectDatabaseSettings
    {
        public string MoviesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
