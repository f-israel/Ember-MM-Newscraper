namespace XBMCRPC.List.Item
{
   public class File : Base
   {
       public string file { get; set; }
       public File_filetype filetype { get; set; }
       public string lastmodified { get; set; }
       public string mimetype { get; set; }
       public int size { get; set; }
    }
}
