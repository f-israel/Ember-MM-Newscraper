using System;
using System.Collections.Generic;
using System.Linq;
using XBMCRPC.Global;

namespace XBMCRPC.PVR.Details
{
   public class Timer_weekdays : List<Weekday>
   {
         public static Timer_weekdays AllFields()
         {
             var items = Enum.GetValues(typeof (Weekday));
             var list = new Timer_weekdays();
             list.AddRange(items.Cast<Weekday>());
             return list;
         }
   }
}
