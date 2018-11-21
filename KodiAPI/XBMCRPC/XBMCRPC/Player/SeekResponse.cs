using XBMCRPC.Global;

namespace XBMCRPC.Player
{
   public class SeekResponse
   {
       public double percentage { get; set; }
       public Time time { get; set; }
       public Time totaltime { get; set; }
    }
}
