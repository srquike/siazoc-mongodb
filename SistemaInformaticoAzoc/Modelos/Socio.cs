using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Socio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SocioId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("fecha_nacimiento")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaNacimiento { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; }

        [BsonElement("dui")]
        public string Dui { get; set; }

        [BsonElement("genero")]
        public string Genero { get; set; }

        [BsonElement("telefono")]
        public string Telefono { get; set; }

        [BsonElement("fecha_ingreso")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaIngreso { get; set; }

        [BsonElement("fecha_retiro")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaRetiro { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("habilitado")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsHabilitado { get; set; }

        [BsonElement("retirado")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsRetirado { get; set; }

        [BsonElement("creditos")]
        public ICollection<Credito> Creditos { get; set; }
    }
}