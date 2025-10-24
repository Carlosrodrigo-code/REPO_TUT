using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace REPO_TUT.Data.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "La matrícula es obligatoria")]
        public string Matricula { get; set; } = string.Empty;
        [Range(1, 12, ErrorMessage = "El cuatrimestre debe estar entre 1 y 12")]
        public int Cuatrimestre { get; set; }

        //Relacion muchos a muchos con Materias
        public ICollection<Materia> Materias { get; set; } = new List<Materia>();
    }
}
