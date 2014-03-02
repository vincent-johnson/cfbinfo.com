using cfbInfo.DAL;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Domain
{
    public class SearchService
    {
        private readonly Context _context;
        private readonly string _searchValue;

        public SearchService(string searchValue)
        {
            _searchValue = searchValue;
            _context = new Context();
        }

        public int FetchTotalReturnedItems()
        {
            int teams = FetchTeamsBySearch().Count();
            int conferences = FetchConferencesBySearch().Count();
            int players = FetchPlayersBySearch().Count();
            return teams + conferences + players;
        }

        public IEnumerable<Team> FetchTeamsBySearch()
        {
            return FetchTeamsBySearch(_searchValue, _context);
        }

        public IEnumerable<Conference> FetchConferencesBySearch()
        {
            return FetchConferencesBySearch(_searchValue, _context);
        }

        public IEnumerable<Player> FetchPlayersBySearch()
        {
            return FetchPlayersBySearch(_searchValue, _context);
        }


        private IEnumerable<Team> FetchTeamsBySearch(string searchValue, Context context)
        {
            var query = (from team in context.Teams
                         where team.Name.Contains(searchValue)
                         select team).ToList();

            return query;
        }

        private IEnumerable<Conference> FetchConferencesBySearch(string searchValue, Context context)
        {
            var query = (from conference in context.Conferences
                         where conference.Name.Contains(searchValue)
                         select conference).ToList();

            return query;
        }

        private IEnumerable<Player> FetchPlayersBySearch(string searchValue, Context context)
        {
            var query = (from player in context.Players
                         where player.FirstName.Contains(searchValue) || player.LastName.Contains(searchValue)
                         select player).ToList();
            return query;
        }
    }
}
