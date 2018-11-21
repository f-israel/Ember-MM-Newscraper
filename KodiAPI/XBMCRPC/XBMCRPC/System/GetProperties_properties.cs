using System;
using System.Collections.Generic;
using System.Linq;
using XBMCRPC.System.Property;

namespace XBMCRPC.System
{
   public class GetProperties_properties : List<Name>
   {
         public static GetProperties_properties AllFields()
         {
             var items = Enum.GetValues(typeof (Name));
             var list = new GetProperties_properties();
             list.AddRange(items.Cast<Name>());
             return list;
         }
   }
}
