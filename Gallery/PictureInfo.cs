using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    [Serializable]
    class PictureInfo
    {
        public String NamePicture { get; set; }
        public String FullName { get; set; }
        public String Comment { get; set; }
        public int Mark { get; set; }
    }
}
