using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Drive : IModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GameRefNum { get; set; }
        [Required]
        public int DriveNum { get; set; }
        [Required]
        public string TeamRefNum { get; set; }
        [Required]
        public string StartPer { get; set; }
        [Required]
        public string StartClock { get; set; }
        [Required]
        public string StartSpot { get; set; }
        [Required]
        public string StartReason { get; set; }
        [Required]
        public string EndPer { get; set; }
        [Required]
        public string EndClock { get; set; }
        [Required]
        public string EndSpot { get; set; }
        [Required]
        public string EndReason { get; set; }
        [Required]
        public int Plays { get; set; }
        [Required]
        public int Yards { get; set; }
        [Required]
        public int TimePoss { get; set; }
        [Required]
        public bool RedZoneAtt { get; set; }
    }
}
