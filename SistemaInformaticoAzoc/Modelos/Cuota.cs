using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Cuota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CuotaId { get; set; }

        [BsonElement("fecha_pago")]
        public string FechaPago { get; set; }

        [BsonElement("monto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Monto { get; set; }

        [BsonElement("credito_id")]
        public string CreditoId { get; set; }

        [BsonElement("fecha_vencimiento")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaVencimiento { get; set; }

        [BsonElement("pagada")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsPagada { get; set; }

        [BsonElement("credito")]
        public Credito Credito { get; set; }
    }
}