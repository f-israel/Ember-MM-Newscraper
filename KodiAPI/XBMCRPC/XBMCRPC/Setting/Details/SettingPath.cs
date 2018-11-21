using System.Collections.Generic;

namespace XBMCRPC.Setting.Details
{
   public class SettingPath : SettingString
   {
       public List<string> sources { get; set; }
       public bool writable { get; set; }
    }
}
