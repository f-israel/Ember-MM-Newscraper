using System.Collections.Generic;

namespace XBMCRPC.Textures.Details
{
   public class Texture
   {
       public string cachedurl { get; set; }
       public string imagehash { get; set; }
       public string lasthashcheck { get; set; }
       public List<Size> sizes { get; set; }
       public int textureid { get; set; }
       public string url { get; set; }
    }
}
