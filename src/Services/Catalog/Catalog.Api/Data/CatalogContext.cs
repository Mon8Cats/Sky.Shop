using Catalog.Api.Entities;
using Catalog.Api.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IOptions<MongoDbSettings> mongoDbOptions)
        {
            var mongoClient = new MongoClient(mongoDbOptions.Value.ConnectionString);
            var database = mongoClient.GetDatabase(mongoDbOptions.Value.DatabaseName);
            Products = database.GetCollection<Product>(mongoDbOptions.Value.CollectionName);
        }
        public IMongoCollection<Product> Products { get; }
    }
}