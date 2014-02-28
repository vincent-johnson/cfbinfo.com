using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class GameStatistic : IModel
    {
        public int Id { get; set; }
        public string GameRefNum { get; set; }
        public int Attendance { get; set; }
        public int Duration { get; set; }
    }
}
