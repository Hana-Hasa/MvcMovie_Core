using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _88214020018_TranThiNgocHuyen.Models
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        public virtual IList<Movie> Movies { get; set; } = new List<Movie>();
    }
}