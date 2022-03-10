using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceSuspension
    {
        public AccountServiceSuspension()
        {
            AccountServiceSuspensionSquares = new HashSet<AccountServiceSuspensionSquare>();
        }

        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeSuspension { get; set; }
        public decimal? SquareAffected { get; set; }
        public string Notice { get; set; }
        public decimal? PercentAffected { get; set; }
        public DateTime Created { get; set; }
        public long? GroupOperId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual FasetItem TypeSuspensionNavigation { get; set; }
        public virtual ICollection<AccountServiceSuspensionSquare> AccountServiceSuspensionSquares { get; set; }
    }
}
