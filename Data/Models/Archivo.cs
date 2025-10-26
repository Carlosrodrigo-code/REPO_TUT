using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPO_TUT.Data.Models
{
    /// <summary>
    /// Representa un archivo subido al sistema.
    /// </summary>
    public class Archivo
    {
        /// <summary>
        /// Identificador único del archivo.
        /// </summary>
        [Key]
        public int ArchivoId { get; set; }

        /// <summary>
        /// Nombre del archivo.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Mime type del archivo.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string TipoMime { get; set; } = string.Empty;

        /// <summary>
        /// Tamaño del archivo en bytes.
        /// </summary>
        [Required]
        public long TamañoBytes { get; set; }

        /// <summary>
        /// Fecha y hora de subida del archivo. Por defecto es la fecha y hora actual en UTC.
        /// </summary>
        [Required]
        public DateTime FechaSubida { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Contenido binario del archivo.
        /// </summary>
        public byte[]? Contenido { get; set; }

    }
}
