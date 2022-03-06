using NHL.NET.Models.Position;

namespace NHL.NET.Models.Player
{
    public class NHLRosterPlayer
    {
        public NHLSimplePlayer Player { get; set; }

        public int JerseyNumber { get; set; }

        public PlayerPosition Position { get; set; }
    }
}
