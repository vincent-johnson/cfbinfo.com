﻿using cfbInfo.DAL;
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
        private readonly int _id;
        private readonly Team _team;
        private readonly Context _context;

        //============== Constructors =============//
        public TeamService(int id)
        {
            _id = id;
            _context = new Context();
            _team = FetchTeamById(_id, _context);
            
        }


        //============ Public Methods ============//
        public Team Team()
        {
            return FetchTeamById(_id, _context);
        }

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

        private Team FetchTeamById(int id, Context context)
        {
            var query = (from team in context.Teams
                         where team.Id == id
                         select team).SingleOrDefault();
            return query;
        }

        private Team FetchByRefNum(string refNum)
        {
            return FetchByRefNum(refNum, _context);
        }

        private Team FetchByRefNum(string refNum, Context context)
        {
            Team query = (from team in context.Teams
                          where team.RefNum == refNum
                          select team).Single();
            return query;
        }

        private Conference FetchConferenceByTeam(Team team, Context context)
        {
            string conferenceRefNum = team.ConfRefNum;

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
                         where player.TeamRefNum == _team.RefNum
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
                         where game.HomeTeamRefNum == _team.RefNum || game.VisitTeamRefNum == _team.RefNum
                         select game).Distinct();

            ICollection<List<string>> gameDetail = new List<List<string>>();
            foreach (Game game in Games)
            {
                Team homeTeam = FetchByRefNum(game.HomeTeamRefNum, _context);
                Team visitTeam = FetchByRefNum(game.VisitTeamRefNum, _context);
                Stadium stadium = FetchStadiumByGame(game, _context);
                var gameInformation = new List<string>();
                gameInformation.Add(game.Date.ToString("mm/dd/yyyy"));
                gameInformation.Add(homeTeam.Name + " vs. " + visitTeam.Name + " at " + stadium.Name + " in " + stadium.City + ", " + stadium.State);
                gameInformation.Add(game.Id.ToString());
                gameDetail.Add(gameInformation);
            }
            return gameDetail;
        }
    }
}
