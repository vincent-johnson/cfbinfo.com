using cfbInfo.DAL;
using cfbInfo.Domain;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfbInfo.Web.ViewModels
{
    public class GameViewModel
    {
        private GameService _gameService;
        private GameStatistic _gameStat;

        //============= Constructors =================//
        public GameViewModel(int id)
        {
            _gameService = new GameService(id);
            _gameStat = _gameService.GameStatistics();
        }

        //============= Public properties ===============//
        public Team HomeTeam
        {
            get { return _gameService.FetchTeamByGame("home"); }
        }

        public Team VisitingTeam
        {
            get { return _gameService.FetchTeamByGame("visitor"); }
        }

        public string GameDate
        {
            get { return _gameService.FetchDateByGameStatistic(); }
        }

        public TeamGameStatistic HomeTeamStats
        {
            get { return _gameService.FetchGameStatsByTeam(HomeTeam); }
        }

        public TeamGameStatistic VisitTeamStats
        {
            get { return _gameService.FetchGameStatsByTeam(VisitingTeam); }
        }

        public GameStatistic GameStatistics
        {
            get { return _gameStat; }
        }

        public Stadium Stadium
        {
            get { return _gameService.FetchStadumByGame(); }
        }
    }
}