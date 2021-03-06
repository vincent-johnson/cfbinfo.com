﻿using cfbInfo.DAL;
using cfbInfo.Domain;
using cfbInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cfbInfo.Web.ViewModels
{
    public class PlayerViewModel
    {
        private readonly Player _player;
        private readonly PlayerService _playerService;

        public PlayerViewModel(int id)
        {
            _playerService = new PlayerService(id);
            _player = _playerService.Player();
        }

        public Player Player
        {
            get { return _player; }
        }

        public Team Team
        {
            get { return _playerService.FetchTeamByPlayer(); }
        }

        public IEnumerable<PlayerRecord> Records
        {
            get { return _playerService.FetchRecordsByPlayer(); }
        }

        public Conference Conference
        {
            get { return _playerService.FetchConferenceByPlayer(); }
        }
    }
}