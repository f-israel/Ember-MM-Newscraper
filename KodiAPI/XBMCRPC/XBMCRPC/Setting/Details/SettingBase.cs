namespace XBMCRPC.Setting.Details
{
   public class SettingBase : Base
   {
       public object control { get; set; }
       public bool enabled { get; set; }
       public int level { get; set; }
       public string parent { get; set; }
       public Type type { get; set; }
    }
}
