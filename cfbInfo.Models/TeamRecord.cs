using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class TeamRecord : IModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TeamRefNum { get; set; }
        [Required]
        public string GamePhase { get; set; }
        [Required]
        public string RecordName { get; set; }
        [Required]
        public string TeamName { get; set; }
    }
}
