using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Stadium : IModel
    {
        public int Id { get; set; }
        public string RefNum { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Capacity { get; set; }
        public string Surface { get; set; }
        public string YearOpen { get; set; }
    }
}
