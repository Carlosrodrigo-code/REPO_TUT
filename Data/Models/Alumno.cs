using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace REPO_TUT.Data.Models
{
    /// <summary>
    /// Representa un alumno de la institución en el sistema.
    /// </summary>
    public class Alumno
    {
        /// <summary>
        /// Identificador único del alumno.
        /// </summary>
        [Key]
        public int AlumnoId { get; set; }

        /// <summary>
        /// Nombre del alumno.
        /// </summary>
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Apellido del alumno.
        /// </summary>
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MaxLength(255)]
        public string Apellido { get; set; } = string.Empty;

        /// <summary>
        /// Matrícula del alumno.
        /// </summary>
        [Required(ErrorMessage = "La matrícula es obligatoria")]
        [MaxLength(255)]
        public string Matricula { get; set; } = string.Empty;

        /// <summary>
        /// Cuatrimestre actual del alumno.
        /// </summary>
        [Range(1, 12, ErrorMessage = "El cuatrimestre debe estar entre 1 y 12")]
        public int Cuatrimestre { get; set; }
    }
}
