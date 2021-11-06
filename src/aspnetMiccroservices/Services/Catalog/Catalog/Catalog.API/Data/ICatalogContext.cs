using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.API.Entitties;
namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
         IMongoCollection<Product> Products { get; }
    }
}
