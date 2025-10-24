using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPO_TUT.Data.Models
{
    public class Archivo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        //Relacion muchos a muchos con Materia
        public ICollection<Materia> Materias { get; set; } = new List<Materia>();

        
       
    }
}
