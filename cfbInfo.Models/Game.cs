using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Game : IModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RefNum { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string VisitTeamId { get; set; }
        [Required]
        public string HomeTeamId { get; set; }
        [Required]
        public string StadiumRefNum { get; set; }
        [Required]
        public string Site { get; set; }
    }
}
