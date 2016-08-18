using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Comentarios = new HashSet<Comentario>();
        }

        public Guid PostId { get; set; }
        public DateTime Fecha { get; set; }
        public Guid UsuarioId { get; set; }
        public string TextoPost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}