using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Api.Settings
{
    public class NpgsqlSettings
    {
        //"ConnectionString": "Server=localhost;Port=5432;Database=DiscountDb;User Id=admin;Password=admin1234;"
        public string ConnectionString { get; set; }
    }
}