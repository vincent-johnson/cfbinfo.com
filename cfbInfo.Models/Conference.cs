using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Conference : IModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RefNum { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subdivision { get; set; }
    }
}
