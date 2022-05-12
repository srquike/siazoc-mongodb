using MongoDB.Bson;
using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Servicios
{
    internal class CargoService
    {
        private readonly IMongoCollection<Cargo> _collection;

        public CargoService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Cargo>("cargos");
        }

        public Task CreateAsync(Cargo cargo)
        {
            return _collection.InsertOneAsync(cargo);
        }

        public Task DeleteAsync(string id)
        {
            return _collection.FindOneAndDeleteAsync(c => c.CargoId == id);
        }

        public Task UpdateAsync(Cargo cargo)
        {
            return _collection.FindOneAndReplaceAsync(c => c.CargoId == cargo.CargoId, cargo);
        }

        public Task<Cargo> GetByIdAsync(string id)
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "empleados"},
                        { "localField", "_id"},
                        { "foreignField", "cargo_id"},
                        { "as", "empleados"}
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

            BsonDocument[] pipeLine = new BsonDocument[]
            {
                match,
                lookup
            };

            return _collection.AggregateAsync<Cargo>(pipeLine).Result.FirstOrDefaultAsync();
            // return _collection.FindAsync(c => c.CargoId == id).Result.FirstOrDefaultAsync();
        }

        public Task<List<Cargo>> GetAllAsync()
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "empleados"},
                        { "localField", "_id"},
                        { "foreignField", "cargo_id"},
                        { "as", "empleados"}
                    }
                }
            };

            BsonDocument[] pipeLine = new BsonDocument[]
            {
                lookup
            };

            return _collection.AggregateAsync<Cargo>(pipeLine).Result.ToListAsync();
            // return _collection.FindAsync(c => true).Result.ToListAsync();
        }
    }
}