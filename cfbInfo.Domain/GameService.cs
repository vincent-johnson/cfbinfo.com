﻿using cfbInfo.DAL;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Domain
{
    public class GameService
    {
        private readonly GameStatistic _gameStat;
        private readonly Context _context;
        private readonly Game _game;
        private readonly int _id;


        //============ Constructors =================//

        public GameService(int id)
        {
            _context = new Context();
            _id = id;
            _gameStat = GameStatistic(_id, _context);
            _game = FetchGameByGameStatistic(_gameStat);
        }

        //=========== Pulic Methods ===============//

        public GameStatistic GameStatistics()
        {
            return _gameStat;
        }

        public Team FetchTeamByGame(string HomeOrVisitor)
        {
            return FetchTeamByGame(HomeOrVisitor, _game, _context);
        }

        public TeamGameStatistic FetchGameStatsByTeam(Team team)
        {
            return FetchGameStatsByTeam(team, _game, _context);
        }

        public Stadium FetchStadumByGame()
        {
            return FetchStadiumByGame(_game, _context);
        }

        public string FetchDateByGameStatistic()
        {
            return _game.Date.Date.ToString();
        }


        //=========== Private Methods ===============//
        private GameStatistic GameStatistic(int id, Context context)
        {
            var gameStat = context.GameStatistics.Find(id);
            return gameStat;
        }

        private Stadium FetchStadiumByGame(Game game, Context context)
        {
            var query = (from stadium in context.Stadiums
                         where stadium.RefNum == game.StadiumRefNum
                         select stadium).SingleOrDefault();
            return query;
        }

        private TeamGameStatistic FetchGameStatsByTeam(Team team, Game game, Context context)
        {
            var query = (from tgs in context.TeamGameStatistics
                         where (team.RefNum == tgs.TeamRefNum) && (game.RefNum == tgs.GameRefNum)
                         select tgs).Single();
            return query;
        }


        private Team FetchTeamByGame(string homeOrVistior, Game game, Context context)
        {
            if (homeOrVistior == "home")
            {
                var query = (from team in context.Teams
                             where team.RefNum == game.HomeTeamRefNum
                             select team).Single();
                return query;
            }
            if (homeOrVistior == "visitor")
            {
                var query = (from team in context.Teams
                             where team.RefNum == game.VisitTeamRefNum
                             select team).Single();
                return query;
            }
            else
            {
                throw new ArgumentException("The method - FetchTeamByGame() in GameService.cs - requires the string to contain either home or visitor");
            }
        }

        private Game FetchGameByGameStatistic(GameStatistic gameStatistic)
        {
            var query = (from game in _context.Games
                         where gameStatistic.GameRefNum == game.RefNum
                         select game).Single();
            return query;
        }
    }
}
