using cfbInfo.DAL;
using cfbInfo.Models;
using cfbInfo.Web.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Tests.ViewModels.Tests
{
    [TestFixture]
    public class TestTeamViewModel
    {
        //Dummy data
        private readonly Team team = new Team()
        {
            Id = 10000,
            Name = "Test Team",
            RefNum = "10000",
            SchoolName = "Test School",
            ConfRefNum = "10000" ,
            NumOfNatlChamp = 1,
            NumOfConfChamp  = 1,
            YearFounded = "1999",
            AllTimeWins = 100,
            AllTimeLosses = 50,
            AllTimeTies = 10,
            BowlWins = 20,
            BowlLosses = 10,
            BowlTies = 5,
            NumOfHeismans = 2,   
            NumOfAllAmericans = 10,
            HeadCoach = "test head coach",
            OffCoord  = "test offensive coordinator",
            DefCoord  = "test defensive coordinator",
            Mascot = "test mascot",
            TeamUrl = "www.testeamviewmodel.com",
            ColorHexCode = "ffffff",
            Image = "testteam.png"
        };


        [Test]
        private void CheckReturnedTeamFromTeamViewModel(TeamViewModel tvm, Team team)
        {
            TeamViewModel test = new TeamViewModel(team.Id);
            Assert.AreEqual(team, test.Team);
        }

        [Test]
        private void CheckReturnedRefNumFromTeamViewMode(TeamViewModel tvm, Team team)
        {
        }
    }
}
