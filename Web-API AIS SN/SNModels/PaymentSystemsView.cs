using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentSystemsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ParseProcName { get; set; }
        public string ProcessReesterRecordProcName { get; set; }
        public string UnpivotApxReesterRecordProcName { get; set; }
        public string PreProcessReesterProcName { get; set; }
        public string PostProcessReesterProcName { get; set; }
        public int? RecordStorageFormatId { get; set; }
        public string RecordStorageFormatName { get; set; }
        public string PivotApxReesterRecordProcName { get; set; }
        public string Encoding { get; set; }
        public bool IsRequiredPaymentAgent { get; set; }
        public string InsertApartmentCounterIndicationProcName { get; set; }
        public string RecordNameParse { get; set; }
        public bool IsBankPaymentOrder { get; set; }
        public bool? IsDeleteLoadedFiles { get; set; }
        public string StartFolderForFiles { get; set; }
        public string ProcessReesterRecordByHandProcName { get; set; }
    }
}
