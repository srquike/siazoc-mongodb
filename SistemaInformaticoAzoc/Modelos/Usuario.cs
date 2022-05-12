using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SistemaInformaticoAzoc.Modelos
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioId { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("clave")]
        public string Clave { get; set; }

        [BsonElement("administrador")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsAdministrador { get; set; }

        [BsonElement("activado")]
        [BsonRepresentation(BsonType.Boolean)]
        public bool EsActivado { get; set; }

        [BsonElement("empleado_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonElement("empleado")]
        public Empleado Empleado { get; set; }
    }
}