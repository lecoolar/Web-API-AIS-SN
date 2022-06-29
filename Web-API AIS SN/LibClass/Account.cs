using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Web_API_AIS_SN.SNModels;
using Web_API_AIS_SN.Context;

namespace Web_API_AIS_SN.LibClass
{
    public class AccountSN
    {
        internal string conString;

        public AccountSN(string conStrings)
        {
            conString = conStrings;
        }

        //public void SaveChange(Account account)
        //{
        //    using (var sn = new SNContext(conString))
        //    {
        //        try
        //        {

        //            var oldAccount = sn.Accounts.Where(q => q.Id == account.Id).Single();
        //            oldAccount = account;
        //            sn.SubmitChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Ошибка при попытке сохранить изменения в Account.SaveChange");

        //        }
        //    }

        //}

        public List<AccountsViewNotArchived> GetAccountsViewNotArchivedByAdrId(long adrId, int level)
        {
            var accounts = new List<AccountsViewNotArchived>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.AccountsViewNotArchiveds.Select(a => new AccountsViewNotArchived()
                    {
                        Id = a.Id,
                        Number = a.Number,
                        ApartmentId = a.ApartmentId,
                        ApartmentNumber = a.ApartmentNumber,
                        Created = a.Created,
                        FromDate = a.FromDate,
                        ToDate = a.ToDate,
                        AddrId = a.AddrId,
                        AddressName = a.AddressName,
                        AddressLevel = a.AddressLevel,
                        ParentAddrId = a.ParentAddrId,
                        OwnerId = a.OwnerId,
                        OwnerName = a.OwnerName,
                        NeedOwnerPresence = a.NeedOwnerPresence,
                        Comment = a.Comment,
                        ClLs = a.ClLs,
                        ObjLs = a.ObjLs,
                        PgCl = a.PgCl,
                        PgObj = a.PgObj,
                        ApartmentFromDate = a.ApartmentFromDate,
                        ApartmentToDate = a.ApartmentToDate,
                        ApartmentCreated = a.ApartmentCreated,
                        ApartmentFloorHouse = a.ApartmentFloorHouse,
                        ApartmentDoorWay = a.ApartmentDoorWay,
                        ApartmentRoomsCount = a.ApartmentRoomsCount,
                        ApartmentEnergoAccount = a.ApartmentEnergoAccount,
                        HouseHolderId = a.HouseHolderId,
                        HouseHolderCode = a.HouseHolderCode,
                        HouseHolderName = a.HouseHolderName,
                        PersonAge = a.PersonAge,
                        NeedPrintNotice = a.NeedPrintNotice,
                        NeedEmailNotice = a.NeedEmailNotice,
                        IdentityCardNumber = a.IdentityCardNumber,
                        IdentityCardHolderName = a.IdentityCardHolderName,
                        DocInfo = a.DocInfo,
                        NoticeAdrId = a.NoticeAdrId,
                        NoticeAddressName = a.NoticeAddressName,
                        NoticeAdrName = a.NoticeAdrName,
                        NoticeAdrPostalIndex = a.NoticeAdrPostalIndex,
                        UseAccountServiceGroups = a.UseAccountServiceGroups,
                        IsCloseInPaymentSystem = a.IsCloseInPaymentSystem,
                        IsArchived = a.IsArchived,
                        AdministrationDistrictId = a.AdministrationDistrictId,
                        AdministrationDistrictName = a.AdministrationDistrictName,
                        OwnerOrgId = a.OwnerOrgId,
                        NoticeEmail = a.NoticeEmail,
                        TypeBudget = a.TypeBudget,
                        TypeBudgetName = a.TypeBudgetName,
                        DateComment = a.DateComment
                    }

                    ).Where(la => la.AddrId == adrId && la.AddressLevel == level && (la.ToDate == null || la.ToDate > DateTime.Today)).ToList();

                }
            }
            catch
            {

            }

            return accounts;
        }

        //public List<AccountsViewNotArchived> GetAccountsViewNotArchivedByAccountId(long AccountId)
        //{
        //    var accounts = new List<AccountsViewNotArchived>();
        //    try
        //    {
        //        using (var sn = new SNContext(conString))
        //        {
        //            accounts = sn.AccountsViewNotArchiveds.Select(a => new AccountsViewNotArchived()
        //            {
        //                id = a.id,
        //                number = a.number,
        //                apartmentId = a.apartmentId,
        //                apartmentNumber = a.apartmentNumber,
        //                created = a.created,
        //                fromDate = a.fromDate,
        //                toDate = a.toDate,
        //                addrId = a.addrId,
        //                addressName = a.addressName,
        //                addressLevel = a.addressLevel,
        //                parentAddrId = a.parentAddrId,
        //                ownerId = a.ownerId,
        //                ownerName = a.ownerName,
        //                needOwnerPresence = a.needOwnerPresence,
        //                comment = a.comment,
        //                cl_ls = a.cl_ls,
        //                obj_ls = a.obj_ls,
        //                pg_cl = a.pg_cl,
        //                pg_obj = a.pg_obj,
        //                apartmentFromDate = a.apartmentFromDate,
        //                apartmentToDate = a.apartmentToDate,
        //                apartmentCreated = a.apartmentCreated,
        //                apartmentFloorHouse = a.apartmentFloorHouse,
        //                apartmentDoorWay = a.apartmentDoorWay,
        //                apartmentRoomsCount = a.apartmentRoomsCount,
        //                apartmentEnergoAccount = a.apartmentEnergoAccount,
        //                houseHolderId = a.houseHolderId,
        //                houseHolderCode = a.houseHolderCode,
        //                houseHolderName = a.houseHolderName,
        //                personAge = a.personAge,
        //                needPrintNotice = a.needPrintNotice,
        //                needEmailNotice = a.needEmailNotice,
        //                identityCardNumber = a.identityCardNumber,
        //                identityCardHolderName = a.identityCardHolderName,
        //                docInfo = a.docInfo,
        //                noticeAdrId = a.noticeAdrId,
        //                noticeAddressName = a.noticeAddressName,
        //                noticeAdrName = a.noticeAdrName,
        //                noticeAdrPostalIndex = a.noticeAdrPostalIndex,
        //                useAccountServiceGroups = a.useAccountServiceGroups,
        //                isCloseInPaymentSystem = a.isCloseInPaymentSystem,
        //                isArchived = a.isArchived,
        //                administrationDistrictId = a.administrationDistrictId,
        //                administrationDistrictName = a.administrationDistrictName,
        //                ownerOrgId = a.ownerOrgId,
        //                noticeEmail = a.noticeEmail,
        //                typeBudget = a.typeBudget,
        //                typeBudgetName = a.typeBudgetName,
        //                dateComment = a.dateComment
        //            }

        //            ).Where(la => la.id == AccountId).ToList();

        //        }
        //    }
        //    catch
        //    {

        //    }

        //    return accounts;
        //}

        //public List<AccountsViewNotArchived> GetAccountsViewNotArchivedByAccount(string account)
        //{
        //    var accounts = new List<AccountsViewNotArchived>();
        //    try
        //    {
        //        using (var sn = new SNContext(conString))
        //        {
        //            accounts = sn.AccountsViewNotArchiveds.Select(a => new AccountsViewNotArchived()
        //            {
        //                id = a.id,
        //                number = a.number,
        //                apartmentId = a.apartmentId,
        //                apartmentNumber = a.apartmentNumber,
        //                created = a.created,
        //                fromDate = a.fromDate,
        //                toDate = a.toDate,
        //                addrId = a.addrId,
        //                addressName = a.addressName,
        //                addressLevel = a.addressLevel,
        //                parentAddrId = a.parentAddrId,
        //                ownerId = a.ownerId,
        //                ownerName = a.ownerName,
        //                needOwnerPresence = a.needOwnerPresence,
        //                comment = a.comment,
        //                cl_ls = a.cl_ls,
        //                obj_ls = a.obj_ls,
        //                pg_cl = a.pg_cl,
        //                pg_obj = a.pg_obj,
        //                apartmentFromDate = a.apartmentFromDate,
        //                apartmentToDate = a.apartmentToDate,
        //                apartmentCreated = a.apartmentCreated,
        //                apartmentFloorHouse = a.apartmentFloorHouse,
        //                apartmentDoorWay = a.apartmentDoorWay,
        //                apartmentRoomsCount = a.apartmentRoomsCount,
        //                apartmentEnergoAccount = a.apartmentEnergoAccount,
        //                houseHolderId = a.houseHolderId,
        //                houseHolderCode = a.houseHolderCode,
        //                houseHolderName = a.houseHolderName,
        //                personAge = a.personAge,
        //                needPrintNotice = a.needPrintNotice,
        //                needEmailNotice = a.needEmailNotice,
        //                identityCardNumber = a.identityCardNumber,
        //                identityCardHolderName = a.identityCardHolderName,
        //                docInfo = a.docInfo,
        //                noticeAdrId = a.noticeAdrId,
        //                noticeAddressName = a.noticeAddressName,
        //                noticeAdrName = a.noticeAdrName,
        //                noticeAdrPostalIndex = a.noticeAdrPostalIndex,
        //                useAccountServiceGroups = a.useAccountServiceGroups,
        //                isCloseInPaymentSystem = a.isCloseInPaymentSystem,
        //                isArchived = a.isArchived,
        //                administrationDistrictId = a.administrationDistrictId,
        //                administrationDistrictName = a.administrationDistrictName,
        //                ownerOrgId = a.ownerOrgId,
        //                noticeEmail = a.noticeEmail,
        //                typeBudget = a.typeBudget,
        //                typeBudgetName = a.typeBudgetName,
        //                dateComment = a.dateComment
        //            }

        //            ).Where(la => la.number == account).ToList();

        //        }
        //    }
        //    catch
        //    {

        //    }

        //    return accounts;
        //}
        //public List<AccountsViewNotArchived> GetAccountsViewNotArchivedByApartmentId(long apartmentId)
        //{
        //    var accounts = new List<AccountsViewNotArchived>();
        //    try
        //    {
        //        using (var sn = new SNContext(conString))
        //        {
        //            accounts = sn.AccountsViewNotArchived.Select(a => new AccountsViewNotArchived()
        //            {
        //                id = a.id,
        //                number = a.number,
        //                apartmentId = a.apartmentId,
        //                apartmentNumber = a.apartmentNumber,
        //                created = a.created,
        //                fromDate = a.fromDate,
        //                toDate = a.toDate,
        //                addrId = a.addrId,
        //                addressName = a.addressName,
        //                addressLevel = a.addressLevel,
        //                parentAddrId = a.parentAddrId,
        //                ownerId = a.ownerId,
        //                ownerName = a.ownerName,
        //                needOwnerPresence = a.needOwnerPresence,
        //                comment = a.comment,
        //                cl_ls = a.cl_ls,
        //                obj_ls = a.obj_ls,
        //                pg_cl = a.pg_cl,
        //                pg_obj = a.pg_obj,
        //                apartmentFromDate = a.apartmentFromDate,
        //                apartmentToDate = a.apartmentToDate,
        //                apartmentCreated = a.apartmentCreated,
        //                apartmentFloorHouse = a.apartmentFloorHouse,
        //                apartmentDoorWay = a.apartmentDoorWay,
        //                apartmentRoomsCount = a.apartmentRoomsCount,
        //                apartmentEnergoAccount = a.apartmentEnergoAccount,
        //                houseHolderId = a.houseHolderId,
        //                houseHolderCode = a.houseHolderCode,
        //                houseHolderName = a.houseHolderName,
        //                personAge = a.personAge,
        //                needPrintNotice = a.needPrintNotice,
        //                needEmailNotice = a.needEmailNotice,
        //                identityCardNumber = a.identityCardNumber,
        //                identityCardHolderName = a.identityCardHolderName,
        //                docInfo = a.docInfo,
        //                noticeAdrId = a.noticeAdrId,
        //                noticeAddressName = a.noticeAddressName,
        //                noticeAdrName = a.noticeAdrName,
        //                noticeAdrPostalIndex = a.noticeAdrPostalIndex,
        //                useAccountServiceGroups = a.useAccountServiceGroups,
        //                isCloseInPaymentSystem = a.isCloseInPaymentSystem,
        //                isArchived = a.isArchived,
        //                administrationDistrictId = a.administrationDistrictId,
        //                administrationDistrictName = a.administrationDistrictName,
        //                ownerOrgId = a.ownerOrgId,
        //                noticeEmail = a.noticeEmail,
        //                typeBudget = a.typeBudget,
        //                typeBudgetName = a.typeBudgetName,
        //                dateComment = a.dateComment
        //            }

        //            ).Where(la => la.apartmentId == apartmentId).ToList();

        //        }
        //    }
        //    catch
        //    {

        //    }

        //    return accounts;
        //}
        public Account GetByNumber(string number)
        {
            var accounts = new List<Account>();
            Account account = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    var acc = sn.Accounts.First();
                    accounts = sn.Accounts.Where(q => q.Number == number).ToList();
                    if (accounts.Any())
                    {
                        if (accounts.Count() == 1)
                        {
                            account = accounts.Single();
                        }
                    }
                }
            }
            catch
            {

            }

            return account;
        }

        public Account GetById(long id)
        {
            var accounts = new List<Account>();
            Account account = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.Accounts.Where(q => q.Id == id).ToList();
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

        //public int ChangeEmail(long id, string email)
        //{
        //    var r = (int)0;

        //    try
        //    {
        //        using (var sn = new SNContext(conString))
        //        {
        //            r = sn.Account_ChangeEmailNotice(id, email);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return r;
        //}

        //    public List<GetAccountProvidersResult> GetAccountProviders(string accountNumber)
        //    {
        //        var r = new List<GetAccountProvidersResult>();

        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                r = sn.GetAccountProviders(accountNumber).ToList();
        //            }
        //        }
        //        catch
        //        {

        //        }
        //        return r;
        //    }

        //    public List<GetAccountServiceProvidersResult> GetAccountServiceProviders(string accountNumber)
        //    {
        //        var res = new List<GetAccountServiceProvidersResult>();
        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                res = sn.GetAccountServiceProviders(accountNumber).ToList();
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }

        //        return res;
        //    }
        //    public int ChangeNotice(Accounts account)
        //    {
        //        var r = (int)0;

        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                r = sn.Account_ChangeNotice(account.id, account.needEmailNotice, account.needPrintNotice, account.noticeEmail);
        //            }
        //        }
        //        catch
        //        {

        //        }
        //        return r;
        //    }

        //    public long GetAccountRecalcId(long accountId, DateTime fromDate, DateTime toDate)
        //    {
        //        var res = (long?)0;

        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                //sn.Account_RecalcForLk(accountId, fromDate, toDate, ref res);
        //                sn.Account_Recalc(accountId, fromDate, toDate, ref res);
        //                sn.Account_RecalcForLk(accountId, fromDate.ToString("dd-MM-yyyy"), toDate.ToString("dd-MM-yyyy"), ref res);
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        return (long)res;
        //    }

        //    public bool IsExists(string lsPerson)
        //    {
        //        var result = false;
        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                result = sn.Accounts.Any(a => a.number == lsPerson);
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        return result;
        //    }

        public Account GetByApartmentId(long apartmentId)
        {
            var accounts = new List<Account>();
            Account account = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.Accounts.Where(q => q.ApartmentId == apartmentId && (q.Datee == null || q.Datee >= DateTime.Today)).ToList();
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


        public List<Account> GetByApartmentIdWithCloced(long apartmentId)
        {
            var accounts = new List<Account>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accounts = sn.Accounts.Where(q => q.ApartmentId == apartmentId).ToList();
                }
            }
            catch
            {

            }
            return accounts;
        }


        //    public AccountHouseHoldersView GetAccountHouseHolders(long accId)
        //    {
        //        var houseHolders = new AccountHouseHoldersView();
        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                houseHolders = sn.AccountHouseHoldersView
        //                    .Where(q => q.accountId == accId)
        //                    .OrderByDescending(h => h.fromDate)
        //                    .ThenByDescending(h => h.id)
        //                    .FirstOrDefault();
        //            }
        //        }
        //        catch
        //        {

        //        }

        //        return houseHolders;
        //    }


        //    public GetHouseHolderInfoByAccountResult GetAccountHouseHolders(string account)
        //    {
        //        var houseHolders = new GetHouseHolderInfoByAccountResult();
        //        try
        //        {
        //            using (var sn = new SNDataContext(conString))
        //            {
        //                houseHolders = sn.GetHouseHolderInfoByAccount(account).SingleOrDefault();

        //            }
        //        }
        //        catch
        //        {

        //        }

        //        return houseHolders;
        //    }

        public List<AccountPropertiesView> GetAccountProperties(long accountId)
        {
            var accountProperties = new List<AccountPropertiesView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    accountProperties = sn.AccountPropertiesViews.Where(q => q.AccountId == accountId).ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return accountProperties;
        }

        public string GetHouseIdByAccount(string accountNumber)
        {
            var result = String.Empty;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    var account = sn.Accounts.FirstOrDefault(a => a.Number == accountNumber);

                    if (account != null)
                    {
                        var apartment = sn.Apartments1.FirstOrDefault(a => a.Id == account.ApartmentId);

                        if (apartment != null)
                        {
                            result = apartment.HouseId.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }
    }
}
