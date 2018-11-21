using XBMCRPC.GUI.Stereoscopy;

namespace XBMCRPC.GUI.Property
{
   public class Value
   {
       public Value_currentcontrol currentcontrol { get; set; }
       public Value_currentwindow currentwindow { get; set; }
       public bool fullscreen { get; set; }
       public Value_skin skin { get; set; }
       public Mode stereoscopicmode { get; set; }
    }
}
