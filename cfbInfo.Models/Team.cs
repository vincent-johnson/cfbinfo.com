using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Team : IModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RefNum { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string ConfRefNum { get; set; }
        [Required]
        public int NumOfNatlChamp { get; set; }
        [Required]
        public int NumOfConfChamp { get; set; }
        [Required]
        public string YearFounded { get; set; }
        [Required]
        public int AllTimeWins { get; set; }
        [Required]
        public int AllTimeLosses { get; set; }
        [Required]
        public int AllTimeTies { get; set; }
        [Required]
        public int BowlWins { get; set; }
        [Required]
        public int BowlLosses { get; set; }
        [Required]
        public int BowlTies { get; set; }
        [Required]
        public int NumOfHeismans { get; set; }
        [Required]
        public int NumOfAllAmericans { get; set; }
        [Required]
        public string HeadCoach { get; set; }
        [Required]
        public string OffCoord { get; set; }
        [Required]
        public string DefCoord { get; set; }
        [Required]
        public string Mascot { get; set; }
        [Required]
        public string TeamUrl { get; set; }
        [Required]
        public string ColorHexCode { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
