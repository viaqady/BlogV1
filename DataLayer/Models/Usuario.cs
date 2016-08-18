using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.Comentarios = new HashSet<Comentario>();
            this.Posts = new HashSet<Post>();
        }

        public Guid UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> Comentarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }

    }
}