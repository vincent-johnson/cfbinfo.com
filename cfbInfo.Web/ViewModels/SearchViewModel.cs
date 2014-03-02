using cfbInfo.DAL;
using cfbInfo.Domain;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfbInfo.Web.ViewModels
{
    public class SearchViewModel
    {
        private readonly SearchService _searchService;
        private readonly string _searchValue;

        public SearchViewModel(string searchValue)
        {
            _searchValue = searchValue;
            _searchService = new SearchService(_searchValue);
        }

        public IEnumerable<Team> ReturnTeams
        {
            get { return _searchService.FetchTeamsBySearch(); }
        }

        public IEnumerable<Conference> ReturnConferences
        {
            get { return _searchService.FetchConferencesBySearch(); }
        }

        public IEnumerable<Player> ReturnPlayers
        {
            get { return _searchService.FetchPlayersBySearch(); }
        }
    }
}