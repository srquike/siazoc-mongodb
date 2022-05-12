using MongoDB.Bson;
using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Servicios
{
    public class CuotaService
    {
        private readonly IMongoCollection<Cuota> _collection;

        public CuotaService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Cuota>("cuotas");
        }

        public Task<Cuota> GetByIdAsync(string id)
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "creditos"},
                        { "localField", "credito_id"},
                        { "foreignField", "_id"},
                        { "as", "credito"}
                    }
                }
            };

            BsonDocument match = new BsonDocument
            {
                {
                    "$match", new BsonDocument
                    {
                        { "_id", BsonObjectId.Create(id) }
                    }
                }
            };

            BsonDocument unwind = new BsonDocument
            {
                {
                    "$unwind", new BsonDocument
                    {
                        { "path", "$credito" },
                        { "preserveNullAndEmptyArrays", BsonBoolean.True }
                    }
                }
            };

            BsonDocument[] pipeLine = new BsonDocument[]
            {
                match,
                lookup,
                unwind
            };

            return _collection.AggregateAsync<Cuota>(pipeLine).Result.FirstOrDefaultAsync();
        }

        public Task CreateManyAsync(List<Cuota> cuotas)
        {
            return _collection.InsertManyAsync(cuotas);
        }

        public Task UpdateAsync(Cuota cuota)
        {
            return _collection.ReplaceOneAsync(c => c.CuotaId == cuota.CuotaId, cuota);
        }

        public Task DeleteManyAsync(string codigoCredito)
        {
            return _collection.DeleteManyAsync(c => c.CreditoId == codigoCredito);
        }
    }
}