using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAccountDebt
    {
        public long TransportDebtId { get; set; }
        public long? TransportAccountProviderId { get; set; }
        public string AccountNumber { get; set; }
        public long? RemoteOrganizationId { get; set; }
        public long? TransportAccountAddressId { get; set; }
        public long? PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Snils { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime? DebtStart { get; set; }
        public DateTime? DebtEnd { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
