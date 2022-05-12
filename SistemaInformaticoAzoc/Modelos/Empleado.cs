using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Empleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("fecha_nacimiento")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime FechaNacimiento { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; }

        [BsonElement("dui")]
        public string Dui { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("cargo_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CargoId { get; set; }

        [BsonElement("cargo")]
        public Cargo Cargo { get; set; }
    }
}