using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Credito
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CreditoId { get; set; }

        [BsonElement("fecha_creacion")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaCreacion { get; set; }

        [BsonElement("fecha_inicio")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime? FechaInicio { get; set; }

        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("monto")]
        [BsonRepresentation(BsonType.Double)]
        public decimal Monto { get; set; }

        [BsonElement("tasa_interes")]
        [BsonRepresentation(BsonType.Double)]
        public decimal TasaInteres { get; set; }

        [BsonElement("plazo")]
        [BsonRepresentation(BsonType.Int32)]
        public int Plazo { get; set; }

        [BsonElement("cancelado")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsCancelado { get; set; } = false;

        [BsonElement("aprobado")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsAprobado { get; set; }

        [BsonElement("socio_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SocioId { get; set; }

        [BsonElement("socio")]
        public Socio Socio { get; set; }

        [BsonElement("cuotas")]
        public ICollection<Cuota> Cuotas { get; set; }

        [BsonElement("deducciones")]
        public ICollection<Deduccion> Deducciones { get; set; }
    }
}