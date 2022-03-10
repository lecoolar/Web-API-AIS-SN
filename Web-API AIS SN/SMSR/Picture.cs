using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Picture
    {
        public Picture()
        {
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
        public bool IsNew { get; set; }

        public virtual PictureBinary PictureBinary { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
