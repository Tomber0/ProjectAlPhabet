using System.Windows.Controls;

namespace ProjectAlPhabet.Model
{
    internal class PictureInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Image Image { get; set; }
        public byte[] Data { get; set; }
        public byte[] DataUncomp { get; set; }

    }
}
