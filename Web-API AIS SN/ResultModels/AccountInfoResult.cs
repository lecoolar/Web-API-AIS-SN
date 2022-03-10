using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountInfoResult
    {
		public string Number { get; set; }

		public string AddressName { get; set; }

		public string OwnerName { get; set; }

		public string HouseHolderName { get; set; }

		public System.Nullable<decimal> Total { get; set; }

		public System.Nullable<decimal> Living { get; set; }

		public System.Nullable<decimal> Heating { get; set; }

		public System.Nullable<int> ApartmentFloorHouse { get; set; }

		public System.Nullable<int> ApartmentRoomsCount { get; set; }

		public System.Nullable<long> ApartmentId { get; set; }

		public string TerritorialSubDivisionName { get; set; }

		public System.Nullable<long> TerritorialSubDivisionCode { get; set; }

		public string ApartmentType { get; set; }

		public System.Nullable<int> ResidentsCount { get; set; }

		public System.Nullable<int> ResidentVacationsCount { get; set; }

		public AccountInfoResult(string accountNumber, SNContext snContext)
		{
			var info = snContext.AccountsViews.FirstOrDefault(a => a.Number == accountNumber);
			this.Number = info.Number;
			this.AddressName = info.AddressName;
			this.OwnerName = info.OwnerName;
			this.HouseHolderName = info.HouseHolderName;
			this.ApartmentFloorHouse = info.ApartmentFloorHouse;
			this.ApartmentRoomsCount = info.ApartmentRoomsCount;
			this.ApartmentId = info.ApartmentId;

			var info2 = snContext.ApartmentAreas.Where(a => a.ApartmentId == ApartmentId);
			var maxDateb = info2.Max(a => a.Dateb);
			this.Total = info2.FirstOrDefault(a=>a.Dateb == maxDateb).Total;
			this.Living = info2.FirstOrDefault(a => a.Dateb == maxDateb).Living;
			this.Heating = info2.FirstOrDefault(a => a.Dateb == maxDateb).Heating;

			var info3 = snContext.ApartmentTerritorialSubdivisionsViews.FirstOrDefault(a => a.ApartmentId == ApartmentId);
			this.TerritorialSubDivisionName = info3.OrganizationName;
			this.TerritorialSubDivisionCode = info3.OrganizationCode;

			var info4 = snContext.ApartmentTypesViews.FirstOrDefault(a => a.ApartmentId == ApartmentId);
			var info5 = snContext.Fasets.FirstOrDefault(a => a.Id == info4.FasetId && (a.Name == "Тип жилья" || a.Name == "Тип квартирности дома"));
			this.ApartmentType = info4.FasetItemName;

			var info6 = snContext.ApartmentResidents.Where(a => a.ApartmentId == ApartmentId && (a.Datee == null || a.Datee >= DateTime.Now)).ToList();
			this.ResidentsCount = info6.Count();

			var info7 = snContext.ApartmentResidentVacations.Where(a => a.ApartmentId == ApartmentId && (a.Datee == null || a.Datee >= DateTime.Now)).ToList();
			this.ResidentVacationsCount = info7.Count();
		}
	}
}
