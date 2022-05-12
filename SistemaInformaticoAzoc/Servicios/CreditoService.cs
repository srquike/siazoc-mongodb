using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Database;

namespace SistemaInformaticoAzoc.Servicios
{
    public class CreditoService
    {
        private readonly IMongoCollection<Credito> _collection;
        private readonly CuotaService _cuotaServices;
        private readonly DeduccionService _deduccionServices;

        public CreditoService()
        {
            _collection = MongoDbProvider.GetDatabase().GetCollection<Credito>("creditos");
            _cuotaServices = new CuotaService();
            _deduccionServices = new DeduccionService();
        }

        public Task<Credito> GetByIdAsync(string id)
        {
            BsonDocument[] pipeLine = new BsonDocument[]
            {
                new BsonDocument
                {
                    {
                        "$match", new BsonDocument
                        {
                            { "_id", BsonObjectId.Create(id) }
                        }
                    }
                },
                new BsonDocument 
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "cuotas"},
                            { "localField", "codigo"},
                            { "foreignField", "credito_id"},
                            { "as", "cuotas"}
                        }
                    }
                },
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "deducciones"},
                            { "localField", "codigo"},
                            { "foreignField", "credito_id"},
                            { "as", "deducciones"}
                        }
                    }
                }, 
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "socios"},
                            { "localField", "socio_id"},
                            { "foreignField", "_id"},
                            { "as", "socio"}
                        }
                    }
                },                
                new BsonDocument
                {
                    {
                        "$unwind", new BsonDocument
                        {
                            { "path", "$socio" },
                            { "preserveNullAndEmptyArrays", BsonBoolean.True }
                        }
                    }
                }
            };

            return _collection.AggregateAsync<Credito>(pipeLine).Result.FirstOrDefaultAsync();
        }

        public Task<List<Credito>> GetAllAsync()
        {
            BsonDocument[] pipeLine = new BsonDocument[]
            {
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "cuotas"},
                            { "localField", "codigo"},
                            { "foreignField", "credito_id"},
                            { "as", "cuotas"}
                        }
                    }
                },
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "deducciones"},
                            { "localField", "codigo"},
                            { "foreignField", "credito_id"},
                            { "as", "deducciones"}
                        }
                    }
                },
                new BsonDocument
                {
                    {
                        "$lookup", new BsonDocument
                        {
                            { "from", "socios"},
                            { "localField", "socio_id"},
                            { "foreignField", "_id"},
                            { "as", "socio"}
                        }
                    }
                },
                new BsonDocument
                {
                    {
                        "$unwind", new BsonDocument
                        {
                            { "path", "$socio" },
                            { "preserveNullAndEmptyArrays", BsonBoolean.True }
                        }
                    }
                }
            };

            return _collection.AggregateAsync<Credito>(pipeLine).Result.ToListAsync();
        }

        public Task CreateAsync(Credito credito)
        {
            return _collection.InsertOneAsync(credito);
        }

        public Task DeleteAsync(string id, string codigo)
        {
            _cuotaServices.DeleteManyAsync(codigo);
            _deduccionServices.DeleteManyAsync(codigo);

            return _collection.DeleteOneAsync(c => c.CreditoId == id);
        }

        public Task UpdateAsync(Credito credito)
        {
            return _collection.ReplaceOneAsync(c => c.CreditoId == credito.CreditoId, credito);
        }
    }
}