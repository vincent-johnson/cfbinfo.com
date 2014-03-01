using cfbInfo.DAL;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Domain
{
    public class ConferenceService
    {
        private readonly Context _context;
        private readonly Conference _conference;

        //============== Constructors =============//
        public ConferenceService(Conference conference, Context context)
        {
            _context = context;
            _conference = conference;
        }

        //============== Public Methods =============//
        public IEnumerable<Team> FetchTeamsByConference()
        {
            return FetchTeamsByConference(_conference, _context);
        }

        public IEnumerable<TeamRecord> FetchOffensiveRecordsByTeams()
        {
            return FetchRecordsByTeams(_conference, _context, "offense");
        }

        public IEnumerable<TeamRecord> FetchDefensiveRecordsByTeam()
        {
            return FetchRecordsByTeams(_conference, _context, "defense");
        }

        public IEnumerable<TeamRecord> FetchSpecialTeamsRecordsByTeam()
        {
            return FetchRecordsByTeams(_conference, _context, "special teams");
        }

        //============== Private Methods =============//
        private IEnumerable<Team> FetchTeamsByConference(Conference conference, Context context)
        {
            var query = (from teams in context.Teams
                         where teams.ConfRefNum == conference.RefNum
                         select teams).ToList();
            return query;
        }

        private IEnumerable<TeamRecord> FetchRecordsByTeams(Conference conference, Context context, string gamePhase)
        {
            IEnumerable<Team> teamList = FetchTeamsByConference(conference, context);
            ICollection<TeamRecord> conferenceRecords = new List<TeamRecord>();
            foreach (Team team in teamList)
            {
                var recordList =  (from tr in context.TeamRecords
                                  where tr.TeamRefNum == team.RefNum && tr.GamePhase == gamePhase
                                  select tr).ToList();
                if (recordList != null)
                {
                    foreach (var record in recordList)
                    {
                        conferenceRecords.Add(record);
                    }
                }
            }
            return conferenceRecords;
        }
    }
}
