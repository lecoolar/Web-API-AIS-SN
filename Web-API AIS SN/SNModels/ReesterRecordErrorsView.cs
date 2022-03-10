using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReesterRecordErrorsView
    {
        public long Id { get; set; }
        public long ReesterRecordId { get; set; }
        public int ErrorId { get; set; }
        public string ErrorName { get; set; }
        public int ErrorTypeId { get; set; }
        public string ErrorTypeName { get; set; }
    }
}
