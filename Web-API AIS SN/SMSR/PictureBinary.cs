using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PictureBinary
    {
        public int Id { get; set; }
        public byte[] BinaryData { get; set; }
        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
