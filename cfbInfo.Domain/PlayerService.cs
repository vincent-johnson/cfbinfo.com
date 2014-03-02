using cfbInfo.DAL;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Domain
{
    public class PlayerService
    {
        private readonly Context _context;
        private readonly Player _player;

        public PlayerService(Player player, Context context)
        {
            _player = player;
            _context = context;
        }

        public Team FetchTeamByPlayer()
        {
            return FetchTeamByPlayer(_player, _context);
        }

        public IEnumerable<PlayerRecord> FetchRecordsByPlayer()
        {
            return FetchRecordsByPlayer(_player, _context);
        }

        public Conference FetchConferenceByPlayer()
        {
            return FetchConferenceByPlayer(_player, _context);
        }



        private Team FetchTeamByPlayer(Player player, Context context)
        {
            var query = (from team in context.Teams
                         where team.RefNum == player.TeamRefNum
                         select team).SingleOrDefault();
            return query;
        }

        private IEnumerable<PlayerRecord> FetchRecordsByPlayer(Player player, Context context)
        {
            var query = (from record in context.PlayerRecords
                         where record.PlayerRefNum == player.RefNum
                         select record).ToList();
            return query;
        }

        private Conference FetchConferenceByPlayer(Player player, Context context)
        {
            Team team = FetchTeamByPlayer(_player, _context);
            var query = (from conference in context.Conferences
                         where conference.RefNum == team.ConfRefNum
                         select conference).SingleOrDefault();
            return query;
        }
    }
}
