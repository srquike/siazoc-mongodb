using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Deduccion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DeduccionId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("monto")]
        [BsonRepresentation(BsonType.Double)]
        public decimal Monto { get; set; }

        [BsonElement("credito_id")]
        public string CreditoId { get; set; }

        [BsonElement("credito")]
        public Credito Credito { get; set; }
    }
}