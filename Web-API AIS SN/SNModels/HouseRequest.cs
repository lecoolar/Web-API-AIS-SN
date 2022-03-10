using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseRequest
    {
        public long Id { get; set; }
        public DateTime ReqDate { get; set; }
        public long UserId { get; set; }
        public long HouseId { get; set; }
        public DateTime Created { get; set; }
        public long? ResidentId { get; set; }
        public string ResidentName { get; set; }
        public string ResidentTel { get; set; }
        public int? ReasonId { get; set; }
        public string ReasonName { get; set; }
        public int? ResultId { get; set; }
        public string ResultName { get; set; }
        public int? ResultKind { get; set; }
        public int? TypeId { get; set; }
        public string AnswerNumber { get; set; }
        public DateTime? AnswerDate { get; set; }
        public long? AnswerUserId { get; set; }
        public string Number { get; set; }
        public int? TimeDuration { get; set; }
        public string Comment { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }

        public virtual User AnswerUser { get; set; }
    }
}
