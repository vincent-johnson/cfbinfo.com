using cfbInfo.DAL;
using cfbInfo.DAL.Interfaces;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Domain
{
    public class TeamService
    {
        private readonly Team _team;
        private readonly Context _context;

        //============== Constructors =============//
        public TeamService(Team team, Context context)
        {
            _team = team;
            _context = context;
        }

        public TeamService(string teamId, Context context)
        {
            _context = context;
            _team = FetchById(teamId, _context);
        }


        //============ Public Methods ============//

        public Conference FetchConferenceByTeam()
        {
            return FetchConferenceByTeam(_team, _context);
        }

        public IEnumerable<Player> FetchPlayersByTeam()
        {
            return FetchPlayersByTeam(_team, _context);
        }

        public IEnumerable<ICollection<string>> FetchGameInformationByTeam()
        {
            return FetchGameInformationByTeam(_team, _context);
        }

        //public IEnumerable<PlayerRecord> FetchPlayerRecordsByPlayers()
        //{
        //    IEnumerable<Player> TeamPlayers = FetchPlayersByTeam();
        //    return FetchPlayerRecordsByPlayers(TeamPlayers);
        //}

        //public IEnumerable<TeamRecord> FetchTeamRecordsByTeam()
        //{
        //    return FetchTeamRecordsByTeam(_team, _context);
        //}


        //============= Private Methods =============//

        private Team FetchById(string id)
        {
            return FetchById(id, _context);
        }

        private Team FetchById(string id, Context context)
        {
            Team query = (from team in context.Teams
                          where team.RefNum == id
                          select team).Single();
            return query;
        }

        private Conference FetchConferenceByTeam(Team team, Context context)
        {
            string conferenceRefNum = team.ConfId;

            Conference query = (from conference in context.Conferences
                                where conference.RefNum == conferenceRefNum
                                select conference).Single();
            return query;
        }

        private Stadium FetchStadiumByGame(Game game, Context context)
        {
            var query = (from stadium in _context.Stadiums
                         where stadium.RefNum == game.StadiumRefNum
                         select stadium).Single();
            return query;
        }

        private IEnumerable<Player> FetchPlayersByTeam(Team team, Context context)
        {
            var query = (from player in _context.Players
                         where player.TeamId == _team.RefNum
                         select player).Distinct();
            return query;
        }

        //private IEnumerable<PlayerRecord> FetchPlayerRecordsByPlayers(IEnumerable<Player> teamPlayers)
        //{
        //    ICollection<PlayerRecord> allPlayerRecords = new List<PlayerRecord>();
        //    foreach (Player player in teamPlayers)
        //    {
        //        var query = (from playerRecord in _context.PlayerRecords
        //                     where playerRecord.PlayerRefNum == player.RefNum
        //                     select playerRecord).Single();
        //        allPlayerRecords.Add(query);
        //    }
        //    return allPlayerRecords;
        //}

        //private IEnumerable<TeamRecord> FetchTeamRecordsByTeam(Team team, Context context)
        //{
        //    var query = (from teamRecord in context.TeamRecords
        //                 where teamRecord.TeamRefNum == team.RefNum
        //                 select teamRecord);
        //    return query;
        //}

        private IEnumerable<ICollection<string>> FetchGameInformationByTeam(Team team, Context context)
        {
            var Games = (from game in _context.Games
                         where game.HomeTeamId == _team.RefNum || game.VisitTeamId == _team.RefNum
                         select game).Distinct();

            ICollection<List<string>> gameDetail = new List<List<string>>();
            foreach (Game game in Games)
            {
                Team homeTeam = FetchById(game.HomeTeamId, _context);
                Team visitTeam = FetchById(game.VisitTeamId, _context);
                Stadium stadium = FetchStadiumByGame(game, _context);
                var gameInformation = new List<string>();
                gameInformation.Add(game.Date.ToString("mm/dd/yyyy"));
                gameInformation.Add(homeTeam.Name + " vs. " + visitTeam.Name + " at " + stadium.Name + " in " + stadium.City + ", " + stadium.State);
                gameDetail.Add(gameInformation);
            }
            return gameDetail;
        }
    }
}
