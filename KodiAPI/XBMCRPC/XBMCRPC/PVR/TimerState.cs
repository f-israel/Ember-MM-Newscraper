using System.Runtime.Serialization;

namespace XBMCRPC.PVR
{
   public enum TimerState
   {
       unknown,
       [EnumMember(Value="new")]
       New,
       scheduled,
       recording,
       completed,
       aborted,
       cancelled,
       conflict_ok,
       conflict_notok,
       error
   }
}
