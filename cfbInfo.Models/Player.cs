using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class Player : IModel
    {
        public int Id { get; set; }
        public string RefNum { get; set; }
        public string TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JerseyNum { get; set; }
        public string Class { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PrevSchool { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
