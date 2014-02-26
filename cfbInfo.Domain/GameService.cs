using cfbInfo.DAL;
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


        //============ Constructors =================//

        public GameService(GameStatistic gameStat, Context context)
        {
            _gameStat = gameStat;
            _context = context;
            _game = FetchGameByGameStatistic(_gameStat);
        }

        //=========== Public Methods ===============//

        public Team FetchTeamByGame(string HomeOrVisitor)
        {
            return FetchTeamByGame(HomeOrVisitor, _game, _context);
        }

        public TeamGameStatistic FetchGameStatsByTeam(Team team)
        {
            return FetchGameStatsByTeam(team, _game, _context);
        }

        public string FetchDateByGameStatistic()
        {
            return _game.Date.Date.ToString();
        }


        //=========== Private Methods ===============//
        private TeamGameStatistic FetchGameStatsByTeam(Team team, Game game, Context context)
        {
            var query = (from tgs in context.TeamGameStatistics
                         where (team.RefNum == tgs.TeamId) && (game.RefNum == tgs.GameId)
                         select tgs).Single();
            return query;
        }


        private Team FetchTeamByGame(string homeOrVistior, Game game, Context context)
        {
            if (homeOrVistior == "home")
            {
                var query = (from team in context.Teams
                             where team.RefNum == game.HomeTeamId
                             select team).Single();
                return query;
            }
            if (homeOrVistior == "visitor")
            {
                var query = (from team in context.Teams
                             where team.RefNum == game.VisitTeamId
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
                         where gameStatistic.GameId == game.RefNum
                         select game).Single();
            return query;
        }
    }
}
