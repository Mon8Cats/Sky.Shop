using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Settings
{
    public class MongoDbSettings
    {
        //public string Host { get; init; }
        //public int Port { get; init; }
        //public string User { get; init; }
        //public string Password { get; init; }
        public string ConnectionString { get; set;}
        public string DatabaseName { get; init; }
        public string CollectionName { get; init; }

        //public string ConnectionString => $"mongodb://{User}:{Password}@{Host}:{Port}";
        
    }
}