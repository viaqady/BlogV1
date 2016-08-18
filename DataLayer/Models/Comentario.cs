using System;

namespace Data.Models
{
    public class Comentario
    {
        public Guid ComentarioId { get; set; }
        public Guid PostId { get; set; }
        public string TextoComentario { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Post Post { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
