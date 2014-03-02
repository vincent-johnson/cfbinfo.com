using cfbInfo.DAL;
using cfbInfo.Domain;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfbInfo.Web.ViewModels
{
    public class ConferenceViewModel
    {
        private readonly ConferenceService _conferenceService;
        private readonly Conference _conference;

        //============== Constructors =============//
        public ConferenceViewModel(int id)
        {
            _conferenceService = new ConferenceService(id);
            _conference = _conferenceService.Conference();
        }

        //============== Public Methods =============//
        public Conference Conference
        {
            get { return _conference; }
        }

        public IEnumerable<Team> ConferenceTeams
        {
            get { return _conferenceService.FetchTeamsByConference(); }
        }

        public IEnumerable<TeamRecord> OffensiveRecords
        {
            get { return _conferenceService.FetchOffensiveRecordsByTeams(); }
        }

        public IEnumerable<TeamRecord> DefensiveRecords
        {
            get { return _conferenceService.FetchDefensiveRecordsByTeam(); }
        }

        public IEnumerable<TeamRecord> SpecialTeamRecords
        {
            get { return _conferenceService.FetchSpecialTeamsRecordsByTeam(); }
        }
    }
}