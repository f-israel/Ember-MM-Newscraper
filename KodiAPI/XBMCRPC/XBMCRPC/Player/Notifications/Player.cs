using XBMCRPC.Global;

namespace XBMCRPC.Player.Notifications
{
   public class Player
   {
       public int playerid { get; set; }
       public int speed { get; set; }
   public class Seek : Player
   {
       public Time seekoffset { get; set; }
       public Time time { get; set; }
    }
    }
}
