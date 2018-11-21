using System.Runtime.Serialization;

namespace XBMCRPC.Setting
{
   public enum Type
   {
       boolean,
       integer,
       number,
       [EnumMember(Value="string")]
       String,
       action,
       list,
       path,
       addon
   }
}
