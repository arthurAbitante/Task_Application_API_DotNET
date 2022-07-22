using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DielWepApplication.Models
{
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public DateTime data { get; set; }
        [Required]
        public DateTime tempoDuracao { get; set; }
        [Required]
        public string tipo { get; set; }
    }
}
