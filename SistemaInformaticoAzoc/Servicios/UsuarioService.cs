using MongoDB.Driver;
using SistemaInformaticoAzoc.Database;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using MongoDB.Bson;

namespace SistemaInformaticoAzoc.Servicios
{
    public class UsuarioService
    {
        private readonly IMongoCollection<Usuario> _collection;

        public UsuarioService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Usuario>("usuarios");
        }

        public Task CreateAsync(Usuario usuario)
        {
            return _collection.InsertOneAsync(usuario);
        }

        public Task DeleteAsync(string id)
        {
            return _collection.FindOneAndDeleteAsync(u => u.UsuarioId == id);
        }

        public Task<Usuario> GetByIdAsync(string id)
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "empleados"},
                        { "localField", "empleado_id"},
                        { "foreignField", "_id"},
                        { "as", "empleado"}
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
                        { "path", "$empleado" },
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

            return _collection.AggregateAsync<Usuario>(pipeLine).Result.FirstOrDefaultAsync();

            // return _collection.FindAsync(u => u.UsuarioId == id).Result.FirstOrDefaultAsync();
        }

        public Task<List<Usuario>> GetAllAsync()
        {
            BsonDocument lookup = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "empleados"},
                        { "localField", "empleado_id"},
                        { "foreignField", "_id"},
                        { "as", "empleado"}
                    }
                }
            };

            BsonDocument unwind = new BsonDocument
            {
                {
                    "$unwind", new BsonDocument
                    {
                        { "path", "$empleado" },
                        { "preserveNullAndEmptyArrays", BsonBoolean.True }
                    }
                }
            };

            BsonDocument[] pipeLine = new BsonDocument[]
            {
                lookup,
                unwind
            };

            return _collection.AggregateAsync<Usuario>(pipeLine).Result.ToListAsync();

            // return _collection.FindAsync(u => true).Result.ToListAsync();
        }

        public Task UpdateAsync(Usuario usuario)
        {
            return _collection.FindOneAndReplaceAsync(u => u.UsuarioId == usuario.UsuarioId, usuario);
        }
    }
}