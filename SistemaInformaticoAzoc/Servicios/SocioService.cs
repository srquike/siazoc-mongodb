using MongoDB.Bson;
using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Servicios
{
    public class SocioService
    {
        private readonly IMongoCollection<Socio> _collection;

        public SocioService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Socio>("socios");
        }

        public Task<Socio> GetByIdAsync(string id)
        {
            BsonDocument[] pipeLine = new BsonDocument[]
            {
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "creditos"},
                            { "localField", "_id"},
                            { "foreignField", "socio_id"},
                            { "as", "creditos"}
                        }
                    }
                },
                new BsonDocument
                {
                    {
                        "$match", new BsonDocument
                        {
                            { "_id", BsonObjectId.Create(id) }
                        }
                    }
                }
            };

            return _collection.AggregateAsync<Socio>(pipeLine).Result.FirstOrDefaultAsync();
        }

        public Task<List<Socio>> GetAllAsync()
        {
            BsonDocument[] pipeLine = new BsonDocument[]
            {
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "creditos"},
                            { "localField", "_id"},
                            { "foreignField", "socio_id"},
                            { "as", "creditos"}
                        }
                    }
                }
            };

            return _collection.AggregateAsync<Socio>(pipeLine).Result.ToListAsync();
        }

        public Task CreateAsync(Socio socio)
        {
            return _collection.InsertOneAsync(socio);
        }

        public Task DeleteAsync(string id)
        {
            return _collection.DeleteOneAsync(s => s.SocioId == id);
        }

        public Task UpdateAsync(Socio socio)
        {
            return _collection.ReplaceOneAsync(s => s.SocioId == socio.SocioId, socio);
        }
    }
}