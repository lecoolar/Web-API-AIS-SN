using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;
//using System.Web.Mvc;



namespace Web_API_AIS_SN.LibClass
{
    public class AccountViewSN
    {
        internal string conString;

        public AccountViewSN( )
        {
        }
        public AccountViewSN(string conStrings)
        {
            conString = conStrings;
        }
        public AccountsView GetByNumber(string number)
        {
            var accounts = new List<AccountsView>();
            AccountsView account = new AccountsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.AccountsViews.Where(q => q.Number == number).Select(z => new AccountsView
                    {
                        ApartmentNumber = z.ApartmentNumber,
                        AddrId = z.AddrId,
                        AddressName = z.AddressName,
                        AddressLevel = z.AddressLevel,
                        ParentAddrId = z.ParentAddrId,
                        PgCl = z.PgCl,
                        PgObj = z.PgObj,
                        ApartmentFromDate = z.ApartmentFromDate,
                        ApartmentToDate = z.ApartmentToDate,
                        ApartmentCreated = z.ApartmentCreated,
                        ApartmentFloorHouse = z.ApartmentFloorHouse,
                        ApartmentDoorWay = z.ApartmentDoorWay,
                        ApartmentRoomsCount = z.ApartmentRoomsCount,
                        NeedOwnerPresence = z.NeedOwnerPresence,
                        Comment = z.Comment,
                        ClLs = z.ClLs,
                        ObjLs = z.ObjLs,
                        ApartmentEnergoAccount = z.ApartmentEnergoAccount,
                        HouseHolderId = z.HouseHolderId,
                        HouseHolderCode = z.HouseHolderCode,
                        HouseHolderName = z.HouseHolderName,
                        PersonAge = z.PersonAge,
                        NeedPrintNotice = z.NeedPrintNotice,
                        NeedEmailNotice = z.NeedEmailNotice,
                        IdentityCardNumber = z.IdentityCardNumber,
                        IdentityCardHolderName = z.IdentityCardHolderName,
                        DocInfo = z.DocInfo,
                        NoticeAdrId = z.NoticeAdrId,
                        Id = z.Id,
                        Number = z.Number,
                        ApartmentId = z.ApartmentId,
                        Created = z.Created,
                        FromDate = z.FromDate,
                        ToDate = z.ToDate,
                        OwnerId = z.OwnerId,
                        OwnerName = z.OwnerName,
                        NoticeAddressName = z.NoticeAddressName,
                        NoticeAdrName = z.NoticeAdrName,
                        UseAccountServiceGroups = z.UseAccountServiceGroups,
                        IsCloseInPaymentSystem = z.IsCloseInPaymentSystem,
                        IsArchived = z.IsArchived,
                        AdministrationDistrictId = z.AdministrationDistrictId,
                        AdministrationDistrictName = z.AdministrationDistrictName,
                        OwnerOrgId = z.OwnerOrgId,
                        NoticeEmail = z.NoticeEmail,
                        TypeBudget = z.TypeBudget,
                        TypeBudgetName = z.TypeBudgetName,
                        DateComment = z.DateComment
                    }).ToList();
                    account = accounts.Count() == 1 ?  accounts.Single() : null;
                }
            }
            catch(Exception ex)
            {

            }

            return account;
        }

        public AccountsView GetById(long id)
        {
            var accounts = new List<AccountsView>();
            AccountsView account = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.AccountsViews.Where(q => q.Id == id).ToList();
                    if (accounts.Any())
                    {
                        if (accounts.Count() == 1)
                        {
                            account = accounts.Single();
                        }
                        else
                        {
                        }
                    }
                    else
                    {

                    }

                }
            }
            catch
            {

            }

            return account;
        }

    }
}
