using MongoDB.Bson;
using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Servicios
{
    public class EmpleadoService
    {
        private readonly IMongoCollection<Empleado> _collection;

        public EmpleadoService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Empleado>("empleados");
        }

        public Task CreateAsync(Empleado empleado)
        {
            return _collection.InsertOneAsync(empleado);
        }

        public Task DeleteAsync(string id)
        {
            return _collection.FindOneAndDeleteAsync(e => e.EmpleadoId == id);
        }

        public Task UpdateAsync(Empleado empleado)
        {
            return _collection.FindOneAndReplaceAsync(e => e.EmpleadoId == empleado.EmpleadoId, empleado);
        }

        public Task<Empleado> GetByIdAsync(string id)
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "cargos"},
                        { "localField", "cargo_id"},
                        { "foreignField", "_id"},
                        { "as", "cargo"}
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
                        { "path", "$cargo" },
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

            return _collection.AggregateAsync<Empleado>(pipeLine).Result.FirstOrDefaultAsync();
            // return _collection.FindAsync(e => e.EmpleadoId == id).Result.FirstOrDefaultAsync();
        }

        public Task<List<Empleado>> GetAllAsync()
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "cargos"},
                        { "localField", "cargo_id"},
                        { "foreignField", "_id"},
                        { "as", "cargo"}
                    }
                }
            };

            BsonDocument unwind = new BsonDocument
            {
                {
                    "$unwind", new BsonDocument
                    {
                        { "path", "$cargo" },
                        { "preserveNullAndEmptyArrays", BsonBoolean.True }
                    }
                }
            };

            BsonDocument[] pipeLine = new BsonDocument[]
            {
                lookup,
                unwind
            };

            return _collection.AggregateAsync<Empleado>(pipeLine).Result.ToListAsync();
            // return _collection.FindAsync(e => true).Result.ToListAsync();
        }
    }
}