using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class PlayerRecord : IModel
    {
        public int Id { get; set; }
        public string PlayerRefNum { get; set; }
        public string TeamRefNum { get; set; }
        public string ConfRefNum { get; set; }
        public string GamePhase { get; set; }
        public string RecordName { get; set; }
    }
}
