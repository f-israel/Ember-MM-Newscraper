using System.Runtime.Serialization;

namespace XBMCRPC.JSONRPC
{
   public enum Introspect_filter_type
   {
       method,
       [EnumMember(Value="namespace")]
       Namespace,
       type,
       notification
   }
}
