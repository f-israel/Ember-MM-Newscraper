using XBMCRPC.Item.Details;

namespace XBMCRPC.PVR.Details
{
   public class Timer : Base
   {
       public int channelid { get; set; }
       public string directory { get; set; }
       public int endmargin { get; set; }
       public string endtime { get; set; }
       public string file { get; set; }
       public string firstday { get; set; }
       public bool isradio { get; set; }
       public int lifetime { get; set; }
       public int priority { get; set; }
       public bool repeating { get; set; }
       public int runtime { get; set; }
       public int startmargin { get; set; }
       public string starttime { get; set; }
       public TimerState state { get; set; }
       public string summary { get; set; }
       public int timerid { get; set; }
       public string title { get; set; }
       public Timer_weekdays weekdays { get; set; }
    }
}
