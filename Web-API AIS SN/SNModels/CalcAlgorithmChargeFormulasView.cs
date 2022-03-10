using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlgorithmChargeFormulasView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
        public byte? NeedApartmentSquares { get; set; }
        public byte? NeedHousekeepingSquares { get; set; }
        public byte? NeedApartmentProperties { get; set; }
        public byte? NeedCounters { get; set; }
        public short? ParamFasetId { get; set; }
        public string NoticeCoefficientCalc { get; set; }
        public string NoticeConsumption { get; set; }
        public string NoticeInfoExistCounter { get; set; }
        public string NoticeInfoGroupRate { get; set; }
        public string NoticeInfoHouseNormRate { get; set; }
        public string NoticeInfoHouseRate { get; set; }
        public string NoticeInfoNormRate { get; set; }
        public bool? NoticeIsFill { get; set; }
        public string NoticeNormRate { get; set; }
        public string NoticeRate { get; set; }
        public string NoticeResidentsCount { get; set; }
        public string NoticeResource { get; set; }
        public string NoticeSquare { get; set; }
        public string ParamFasetName { get; set; }
    }
}
