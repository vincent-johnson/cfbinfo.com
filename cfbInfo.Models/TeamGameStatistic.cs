using cfbInfo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfbInfo.Models
{
    public sealed class TeamGameStatistic : IModel
    {
        public int Id { get; set; }
        public string TeamRefNum { get; set; }
        public string GameRefNum { get; set; }
        public int RushAtt { get; set; }
        public int RushYard { get; set; }
        public int RushTD { get; set; }
        public int PassAtt { get; set; }
        public int PassComp { get; set; }
        public int PassYard { get; set; }
        public int PassTD { get; set; }
        public int PassInt { get; set; }
        public int PassConv { get; set; }
        public int KickoffRet { get; set; }
        public int KickoffRetYard { get; set; }
        public int KickoffRetTD { get; set; }
        public int PuntRet { get; set; }
        public int PuntRetYard { get; set; }
        public int PuntRetTD { get; set; }
        public int FumRet { get; set; }
        public int FumRetYard { get; set; }
        public int FumRetTD { get; set; }
        public int IntRet { get; set; }
        public int IntRetYard { get; set; }
        public int IntRetTD { get; set; }
        public int MiscRet { get; set; }
        public int MiscRetYard { get; set; }
        public int MiscRetTD { get; set; }
        public int FGAtt { get; set; }
        public int FGMade { get; set; }
        public int OffXPAtt { get; set; }
        public int OffXPMade { get; set; }
        public int Off2ptConvAtt { get; set; }
        public int Off2ptConvMade { get; set; }
        public int Def2ptConvAtt { get; set; }
        public int Def2ptConvMade { get; set; }
        public int Safety { get; set; }
        public int Points { get; set; }
        public int Punt { get; set; }
        public int PuntYard { get; set; }
        public int Kickoff { get; set; }
        public int KickoffYard { get; set; }
        public int KickoffTouchback { get; set; }
        public int KickoffOob { get; set; }
        public int KickoffOnside { get; set; }
        public int Fumble { get; set; }
        public int FumbleLost { get; set; }
        public int TackleSolo { get; set; }
        public int TackleAsst { get; set; }
        public decimal Tackle4Loss { get; set; }
        public int Tackle4LossYard { get; set; }
        public decimal Sack { get; set; }
        public int SackYard { get; set; }
        public int QbHurry { get; set; }
        public int FumForced { get; set; }
        public int PassBroken { get; set; }
        public int KickBlocked { get; set; }
        public int FirstRush { get; set; }
        public int FirstPass { get; set; }
        public int FirstPenalty { get; set; }
        public int TimePoss { get; set; }
        public int Penalty { get; set; }
        public int PenaltyYard { get; set; }
        public int ThirdAtt { get; set; }
        public int ThirdConv { get; set; }
        public int FourthAtt { get; set; }
        public int FourthConv { get; set; }
        public int RedZoneAtt { get; set; }
        public int RedZoneTD { get; set; }
        public int RedZoneFG { get; set; }
    }
}
