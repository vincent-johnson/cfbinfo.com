using cfbInfo.DAL;
using cfbInfo.Domain;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfbInfo.Web.ViewModels
{
    public class TeamViewModel
    {
        private readonly TeamService _teamService;
        private readonly Team _team;

        //============ Constructors ==============//

        public TeamViewModel(Context context, Team team)
        {
            _teamService = new TeamService(team, context);
            _team = team;
        }

        public TeamViewModel(string Id, Context context)
        {
            _teamService = new TeamService(Id, context);
        }


        //============ Public properties =============//

        public Team Team
        {
            get { return _team; }
        }

        public Conference Conference
        {
            get { return _teamService.FetchConferenceByTeam(); }
        }

        public IEnumerable<Player> Players
        {
            get { return _teamService.FetchPlayersByTeam(); }
        }

        public IEnumerable<ICollection<string>> GameInformation
        {
            get { return _teamService.FetchGameInformationByTeam(); }
        }

        //public IEnumerable<TeamRecord> TeamRecords
        //{
        //    get { return _teamService.FetchTeamRecordsByTeam(); }
        //}

        //public IEnumerable<PlayerRecord> PlayerRecords
        //{
        //    get { return _teamService.FetchPlayerRecordsByPlayers(); }
        //}
    }
}