using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.DAL
{
    public class Context : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameStatistic> GameStatistics { get; set; }
        //public DbSet<Kickoff> Kickoffs { get; set; }
        //public DbSet<KickoffReturn> KickoffReturns { get; set; }
        //public DbSet<Pass> Passes { get; set; }
        //public DbSet<Play> Plays { get; set; }
        public DbSet<Player> Players { get; set; }
        //public DbSet<PlayerRecord> PlayerRecords { get; set; }
        //public DbSet<PlayerGameStatistic> PlayerGameStatistics { get; set; }
        //public DbSet<Punt> Punts { get; set; }
        //public DbSet<PuntReturn> PuntReturns { get; set; }
        //public DbSet<Reception> Receptions { get; set; }
        //public DbSet<Rush> Rushes { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        //public DbSet<TeamRecord> TeamRecords { get; set; }
        public DbSet<TeamGameStatistic> TeamGameStatistics { get; set; }
        public DbSet<TeamRecord> TeamRecords { get; set; }
    }
}
