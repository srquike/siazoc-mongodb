using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Cargo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CargoId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("empleados")]
        public ICollection<Empleado> Empleados { get; set; }
    }
}