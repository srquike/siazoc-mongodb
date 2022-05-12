using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Servicios
{
    public class DeduccionService
    {
        private readonly IMongoCollection<Deduccion> _collection;

        public DeduccionService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Deduccion>("deducciones");
        }

        public Task CreateManyAsync(List<Deduccion> deducciones)
        {
            return _collection.InsertManyAsync(deducciones);
        }

        public Task DeleteManyAsync(string codigoCredito)
        {
            return _collection.DeleteManyAsync(c => c.CreditoId == codigoCredito);
        }
    }
}