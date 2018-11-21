using System;
using System.Collections.Generic;
using System.Linq;
using XBMCRPC.GUI.Property;

namespace XBMCRPC.GUI
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
