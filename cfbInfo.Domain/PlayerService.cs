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
        private readonly int _id;

        public PlayerService(int id)
        {
            _id = id;
            _context = new Context();
            _player = Player();
        }

        public Player Player()
        {
            return Player(_id, _context);
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



        private Player Player(int id, Context context)
        {
            var player = context.Players.Find(id);
            return player;
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
