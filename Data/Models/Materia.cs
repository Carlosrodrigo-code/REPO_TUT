
using System.ComponentModel.DataAnnotations;

namespace REPO_TUT.Data.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; } = string.Empty;
       
    }
}
