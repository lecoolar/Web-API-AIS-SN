using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SMSRContext : DbContext
    {
        public SMSRContext()
        {
        }

        public SMSRContext(DbContextOptions<SMSRContext> options)
            : base(options)
        {
        }
#warning
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("DbConnectionString");
                optionsBuilder.UseSqlServer("Data Source=dev1-srv.aisgorod.ru;Initial Catalog=sn_sms_router_test;Persist Security Info=True;User ID=lk;Password=lk2011");
            }
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountInfo> AccountInfos { get; set; }
        public virtual DbSet<AccountInfoView> AccountInfoViews { get; set; }
        public virtual DbSet<AccountMessanger> AccountMessangers { get; set; }
        public virtual DbSet<AccountMessangerView> AccountMessangerViews { get; set; }
        public virtual DbSet<AccountNumbersView> AccountNumbersViews { get; set; }
        public virtual DbSet<AccountPerson> AccountPersons { get; set; }
        public virtual DbSet<AccountPersonsView> AccountPersonsViews { get; set; }
        public virtual DbSet<AccountPhone> AccountPhones { get; set; }
        public virtual DbSet<AccountPhonesEpd47View> AccountPhonesEpd47Views { get; set; }
        public virtual DbSet<AccountPhonesView> AccountPhonesViews { get; set; }
        public virtual DbSet<AccountsInfoView> AccountsInfoViews { get; set; }
        public virtual DbSet<AccountsView> AccountsViews { get; set; }
        public virtual DbSet<AccsOnPay> AccsOnPays { get; set; }
        public virtual DbSet<AccsOnPayView> AccsOnPayViews { get; set; }
        public virtual DbSet<AclRecord> AclRecords { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }
        public virtual DbSet<Addrobj> Addrobjs { get; set; }
        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<ApartmentLsNumberFia> ApartmentLsNumberFias { get; set; }
        public virtual DbSet<ApartmentLsNumberFias2> ApartmentLsNumberFias2s { get; set; }
        public virtual DbSet<ApiClaim> ApiClaims { get; set; }
        public virtual DbSet<ApiResource> ApiResources { get; set; }
        public virtual DbSet<ApiScope> ApiScopes { get; set; }
        public virtual DbSet<ApiScopeClaim> ApiScopeClaims { get; set; }
        public virtual DbSet<ApiSecret> ApiSecrets { get; set; }
        public virtual DbSet<AppealType> AppealTypes { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankFaset> BankFasets { get; set; }
        public virtual DbSet<BaseSetting> BaseSettings { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }
        public virtual DbSet<ChatHouse> ChatHouses { get; set; }
        public virtual DbSet<CheckPayOrdersStatus> CheckPayOrdersStatuses { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }
        public virtual DbSet<CityView> CityViews { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientClaim> ClientClaims { get; set; }
        public virtual DbSet<ClientCorsOrigin> ClientCorsOrigins { get; set; }
        public virtual DbSet<ClientGrantType> ClientGrantTypes { get; set; }
        public virtual DbSet<ClientIdPrestriction> ClientIdPrestrictions { get; set; }
        public virtual DbSet<ClientPostLogoutRedirectUri> ClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<ClientProperty> ClientProperties { get; set; }
        public virtual DbSet<ClientRedirectUri> ClientRedirectUris { get; set; }
        public virtual DbSet<ClientScope> ClientScopes { get; set; }
        public virtual DbSet<ClientSecret> ClientSecrets { get; set; }
        public virtual DbSet<Communication0820Sn> Communication0820Sns { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }
        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<DeletedAccount> DeletedAccounts { get; set; }
        public virtual DbSet<DeletedPhone> DeletedPhones { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountAppliedToCategory> DiscountAppliedToCategories { get; set; }
        public virtual DbSet<DiscountAppliedToManufacturer> DiscountAppliedToManufacturers { get; set; }
        public virtual DbSet<DiscountAppliedToProduct> DiscountAppliedToProducts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<FiasNameWebService> FiasNameWebServices { get; set; }
        public virtual DbSet<FiasNameWebServices2> FiasNameWebServices2s { get; set; }
        public virtual DbSet<FiasNameWebServicesView> FiasNameWebServicesViews { get; set; }
        public virtual DbSet<ForumsForum> ForumsForums { get; set; }
        public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }
        public virtual DbSet<ForumsPost> ForumsPosts { get; set; }
        public virtual DbSet<ForumsPostVote> ForumsPostVotes { get; set; }
        public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }
        public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }
        public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }
        public virtual DbSet<GdprConsent> GdprConsents { get; set; }
        public virtual DbSet<GdprLog> GdprLogs { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<HousesView> HousesViews { get; set; }
        public virtual DbSet<IdentityClaim> IdentityClaims { get; set; }
        public virtual DbSet<IdentityResource> IdentityResources { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<IpPhoneRequest> IpPhoneRequests { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Log1> Logs1 { get; set; }
        public virtual DbSet<Log2> Logs2 { get; set; }
        public virtual DbSet<LogsView> LogsViews { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingsView> MeetingsViews { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<MobilePay> MobilePays { get; set; }
        public virtual DbSet<MrtTemplate> MrtTemplates { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }
        public virtual DbSet<NotOpenLkandDublEmail> NotOpenLkandDublEmails { get; set; }
        public virtual DbSet<NumbersView> NumbersViews { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderNote> OrderNotes { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrganizationW> OrganizationWs { get; set; }
        public virtual DbSet<OutMessage> OutMessages { get; set; }
        public virtual DbSet<PasswordBuff> PasswordBuffs { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<PayBankComission> PayBankComissions { get; set; }
        public virtual DbSet<PaymentAgent> PaymentAgents { get; set; }
        public virtual DbSet<PaymentBasesArhiv09022018> PaymentBasesArhiv09022018s { get; set; }
        public virtual DbSet<PaymentBasesTemp> PaymentBasesTemps { get; set; }
        public virtual DbSet<PaymentBasesView> PaymentBasesViews { get; set; }
        public virtual DbSet<PaymentBasis> PaymentBases { get; set; }
        public virtual DbSet<PaymentCase> PaymentCases { get; set; }
        public virtual DbSet<PaymentService> PaymentServices { get; set; }
        public virtual DbSet<PaymentServiceView> PaymentServiceViews { get; set; }
        public virtual DbSet<PaymentServiceViewTest> PaymentServiceViewTests { get; set; }
        public virtual DbSet<PaysEpd47View> PaysEpd47Views { get; set; }
        public virtual DbSet<PaysView> PaysViews { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }
        public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
        public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PhoneInfo> PhoneInfos { get; set; }
        public virtual DbSet<PhoneInfoView> PhoneInfoViews { get; set; }
        public virtual DbSet<PhoneNotification> PhoneNotifications { get; set; }
        public virtual DbSet<PhoneSend> PhoneSends { get; set; }
        public virtual DbSet<PhoneService> PhoneServices { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PictureBinary> PictureBinaries { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollAnswer> PollAnswers { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMappings { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
        public virtual DbSet<ProviderInfo> ProviderInfos { get; set; }
        public virtual DbSet<ProviderInfoView> ProviderInfoViews { get; set; }
        public virtual DbSet<PushMeetingsView> PushMeetingsViews { get; set; }
        public virtual DbSet<QueryType> QueryTypes { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<Qwerty> Qwerties { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }
        public virtual DbSet<RegistrationRequest> RegistrationRequests { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }
        public virtual DbSet<ReviewType> ReviewTypes { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public virtual DbSet<SearchTerm> SearchTerms { get; set; }
        public virtual DbSet<SendChecksToEmail> SendChecksToEmails { get; set; }
        public virtual DbSet<SendChecksToEmailView> SendChecksToEmailViews { get; set; }
        public virtual DbSet<SendMessage> SendMessages { get; set; }
        public virtual DbSet<SendMessagesView> SendMessagesViews { get; set; }
        public virtual DbSet<SentSmsLog> SentSmsLogs { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Setting1> Settings1 { get; set; }
        public virtual DbSet<Setting2> Settings2 { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<ShippingByWeightByTotalRecord> ShippingByWeightByTotalRecords { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShippingMethodRestriction> ShippingMethodRestrictions { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<Socrbase> Socrbases { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<StatmentInfo> StatmentInfos { get; set; }
        public virtual DbSet<StatusPay> StatusPays { get; set; }
        public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreMapping> StoreMappings { get; set; }
        public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }
        public virtual DbSet<StreetView> StreetViews { get; set; }
        public virtual DbSet<SubjectsCountryView> SubjectsCountryViews { get; set; }
        public virtual DbSet<SubscribeAcc> SubscribeAccs { get; set; }
        public virtual DbSet<SubscribeAccsView> SubscribeAccsViews { get; set; }
        public virtual DbSet<SystemType> SystemTypes { get; set; }
        public virtual DbSet<T220520220> T220520220s { get; set; }
        public virtual DbSet<T220520220Last> T220520220Lasts { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<Temp090419> Temp090419s { get; set; }
        public virtual DbSet<TempAccountInfo2019> TempAccountInfo2019s { get; set; }
        public virtual DbSet<TempAccountInfo2020> TempAccountInfo2020s { get; set; }
        public virtual DbSet<TempAccountPhonesViewSv1208> TempAccountPhonesViewSv1208s { get; set; }
        public virtual DbSet<TempAccounts0209> TempAccounts0209s { get; set; }
        public virtual DbSet<TempAccounts110719> TempAccounts110719s { get; set; }
        public virtual DbSet<TempAccounts120719> TempAccounts120719s { get; set; }
        public virtual DbSet<TempAccounts30112019> TempAccounts30112019s { get; set; }
        public virtual DbSet<TempAccountsSv1208> TempAccountsSv1208s { get; set; }
        public virtual DbSet<TempApartmentLsNumberFias18022020> TempApartmentLsNumberFias18022020s { get; set; }
        public virtual DbSet<TempFiasNameWebServices18022020> TempFiasNameWebServices18022020s { get; set; }
        public virtual DbSet<TempIpPhoneRequests24032020> TempIpPhoneRequests24032020s { get; set; }
        public virtual DbSet<TempOblastAccounts04062019> TempOblastAccounts04062019s { get; set; }
        public virtual DbSet<TempPay031019> TempPay031019s { get; set; }
        public virtual DbSet<TempPay2203> TempPay2203s { get; set; }
        public virtual DbSet<TempPays2003> TempPays2003s { get; set; }
        public virtual DbSet<TempPhonesSv1208> TempPhonesSv1208s { get; set; }
        public virtual DbSet<TierPrice> TierPrices { get; set; }
        public virtual DbSet<TmpPay031019> TmpPay031019s { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }
        public virtual DbSet<Tt22052020> Tt22052020s { get; set; }
        public virtual DbSet<TypePay> TypePays { get; set; }
        public virtual DbSet<UrlRecord> UrlRecords { get; set; }
        public virtual DbSet<UserDevice> UserDevices { get; set; }
        public virtual DbSet<UserSession> UserSessions { get; set; }
        public virtual DbSet<UsersInRole> UsersInRoles { get; set; }
        public virtual DbSet<UsersInRolesView> UsersInRolesViews { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }
        public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }
        public virtual DbSet<VendorNote> VendorNotes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WebService> WebServices { get; set; }
        public virtual DbSet<WebServicesView> WebServicesViews { get; set; }
        public virtual DbSet<ОплатаМибапрельРицульяновск> ОплатаМибапрельРицульяновскs { get; set; }
        public virtual DbSet<СборыМибУлЭнергоОктябрь> СборыМибУлЭнергоОктябрьs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Accounts", "smsr");

                entity.HasIndex(e => e.Id, "IX_Accounts_id");

                entity.HasIndex(e => e.Number, "IX_Accounts_number");

                entity.HasIndex(e => new { e.Number, e.WebServiceId }, "IX_Accounts_number_webserviceId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.ToTable("AccountInfo", "smsr");

                entity.HasIndex(e => e.Accountnumber, "IX_AccountInfo_accountNumber");

                entity.HasIndex(e => new { e.City, e.Street, e.House, e.Accountnumber }, "IX_AccountInfo_city_street_house_number")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FiasCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fiasCode");

                entity.Property(e => e.Flat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flat");

                entity.Property(e => e.House)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("house");

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            modelBuilder.Entity<AccountInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountInfoView", "smsr");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FiasCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fiasCode");

                entity.Property(e => e.Flat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flat");

                entity.Property(e => e.House)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("house");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.SystemType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("systemType");
            });

            modelBuilder.Entity<AccountMessanger>(entity =>
            {
                entity.ToTable("AccountMessanger", "bot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.TelegramChatId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telegramChatId");

                entity.Property(e => e.ViberChatId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("viberChatId");
            });

            modelBuilder.Entity<AccountMessangerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountMessangerView", "bot");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.AddressName)
                    .HasMaxLength(191)
                    .IsUnicode(false)
                    .HasColumnName("addressName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.TelegramChatId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telegramChatId");

                entity.Property(e => e.ViberChatId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("viberChatId");
            });

            modelBuilder.Entity<AccountNumbersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountNumbersView", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");
            });

            modelBuilder.Entity<AccountPerson>(entity =>
            {
                entity.ToTable("AccountPersons", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccountPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountPersons_Persons");
            });

            modelBuilder.Entity<AccountPersonsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountPersonsView", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.PersonId).HasColumnName("personId");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personINN");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personSNILS");
            });

            modelBuilder.Entity<AccountPhone>(entity =>
            {
                entity.ToTable("AccountPhones", "smsr");

                entity.HasIndex(e => e.PhoneId, "IX_AccountPhones");

                entity.HasIndex(e => e.AccountId, "IX_AccountPhones__accountId_inc_phoneId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.AccountPhones)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountPhones_Phones");
            });

            modelBuilder.Entity<AccountPhonesEpd47View>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountPhonesEpd47View", "smsr");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.Value)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<AccountPhonesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountPhonesView", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BaseIp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("baseIp");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<AccountsInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountsInfoView", "smsr");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FiasCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fiasCode");

                entity.Property(e => e.Flat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flat");

                entity.Property(e => e.House)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("house");

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            modelBuilder.Entity<AccountsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountsView", "smsr");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");

                entity.Property(e => e.WebServiceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("webServiceName");

                entity.Property(e => e.WebServiceUrl)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("webServiceUrl");
            });

            modelBuilder.Entity<AccsOnPay>(entity =>
            {
                entity.ToTable("AccsOnPay", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<AccsOnPayView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccsOnPayView", "smsr");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<AclRecord>(entity =>
            {
                entity.ToTable("AclRecord");

                entity.HasIndex(e => e.CustomerRoleId, "IX_AclRecord_CustomerRoleId");

                entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_AclRecord_EntityId_EntityName");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.AclRecords)
                    .HasForeignKey(d => d.CustomerRoleId);
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ActivityLog");

                entity.HasIndex(e => e.ActivityLogTypeId, "IX_ActivityLog_ActivityLogTypeId");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_ActivityLog_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_ActivityLog_CustomerId");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.EntityName).HasMaxLength(400);

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.ActivityLogTypeId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.ToTable("ActivityLogType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

                entity.HasIndex(e => e.StateProvinceId, "IX_Address_StateProvinceId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateProvinceId);
            });

            modelBuilder.Entity<AddressAttribute>(entity =>
            {
                entity.ToTable("AddressAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<AddressAttributeValue>(entity =>
            {
                entity.ToTable("AddressAttributeValue");

                entity.HasIndex(e => e.AddressAttributeId, "IX_AddressAttributeValue_AddressAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.AddressAttribute)
                    .WithMany(p => p.AddressAttributeValues)
                    .HasForeignKey(d => d.AddressAttributeId);
            });

            modelBuilder.Entity<Addrobj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADDROBJ", "fias");

                entity.HasIndex(e => new { e.Actstatus, e.Aoguid, e.Aolevel }, "IX__fiasAddrob_actstatus_aoguid_aolevel");

                entity.HasIndex(e => e.Parentguid, "IX__fiasAdrob_parentguid");

                entity.HasIndex(e => e.Livestatus, "IX_fiasAddrob_livestatus");

                entity.HasIndex(e => new { e.Actstatus, e.Aolevel, e.Livestatus, e.Regioncode }, "IX_fiasAddrobj_regionCode_livestatus");

                entity.Property(e => e.Actstatus).HasColumnName("ACTSTATUS");

                entity.Property(e => e.Aoguid).HasColumnName("AOGUID");

                entity.Property(e => e.Aoid).HasColumnName("AOID");

                entity.Property(e => e.Aolevel).HasColumnName("AOLEVEL");

                entity.Property(e => e.Areacode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREACODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Autocode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTOCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("CADNUM");

                entity.Property(e => e.Centstatus).HasColumnName("CENTSTATUS");

                entity.Property(e => e.Citycode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CITYCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Ctarcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CTARCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Currstatus).HasColumnName("CURRSTATUS");

                entity.Property(e => e.Divtype).HasColumnName("DIVTYPE");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Extrcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EXTRCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Formalname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("FORMALNAME");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IFNSFL")
                    .IsFixedLength(true);

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IFNSUL")
                    .IsFixedLength(true);

                entity.Property(e => e.Livestatus).HasColumnName("LIVESTATUS");

                entity.Property(e => e.Nextid).HasColumnName("NEXTID");

                entity.Property(e => e.Normdoc).HasColumnName("NORMDOC");

                entity.Property(e => e.Offname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("OFFNAME");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OKATO")
                    .IsFixedLength(true);

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OKTMO")
                    .IsFixedLength(true);

                entity.Property(e => e.Operstatus).HasColumnName("OPERSTATUS");

                entity.Property(e => e.Parentguid).HasColumnName("PARENTGUID");

                entity.Property(e => e.Placecode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PLACECODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Plaincode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PLAINCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Plancode)
                    .HasMaxLength(4)
                    .HasColumnName("PLANCODE");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("POSTALCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Previd).HasColumnName("PREVID");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REGIONCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Sextcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SEXTCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Shortname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SHORTNAME")
                    .IsFixedLength(true);

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Streetcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STREETCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TERRIFNSFL")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TERRIFNSUL")
                    .IsFixedLength(true);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATEDATE");
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.ToTable("Affiliate");

                entity.HasIndex(e => e.AddressId, "IX_Affiliate_AddressId");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Affiliates)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ApartmentLsNumberFia>(entity =>
            {
                entity.ToTable("ApartmentLsNumberFIAS", "smsr");

                entity.Property(e => e.Accnumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.LocalAddresses)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("localAddresses");

                entity.Property(e => e.Room)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("room");

                entity.HasOne(d => d.FiasNameWebServices)
                    .WithMany(p => p.ApartmentLsNumberFia)
                    .HasForeignKey(d => d.FiasNameWebServicesId)
                    .HasConstraintName("FK__FiasNameWebSevice_id");
            });

            modelBuilder.Entity<ApartmentLsNumberFias2>(entity =>
            {
                entity.ToTable("ApartmentLsNumberFIAS2", "smsr");

                entity.Property(e => e.Accnumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.LocalAddresses)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("localAddresses");

                entity.Property(e => e.Room)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("room");

                entity.HasOne(d => d.FiasNameWebServices)
                    .WithMany(p => p.ApartmentLsNumberFias2s)
                    .HasForeignKey(d => d.FiasNameWebServicesId)
                    .HasConstraintName("FK__FiasNameWebSevice2_id");
            });

            modelBuilder.Entity<ApiClaim>(entity =>
            {
                entity.HasIndex(e => e.ApiResourceId, "IX_ApiClaims_ApiResourceId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiClaims)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiResource>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_ApiResources_Name")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ApiScope>(entity =>
            {
                entity.HasIndex(e => e.ApiResourceId, "IX_ApiScopes_ApiResourceId");

                entity.HasIndex(e => e.Name, "IX_ApiScopes_Name")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiScopes)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiScopeClaim>(entity =>
            {
                entity.HasIndex(e => e.ApiScopeId, "IX_ApiScopeClaims_ApiScopeId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiScope)
                    .WithMany(p => p.ApiScopeClaims)
                    .HasForeignKey(d => d.ApiScopeId);
            });

            modelBuilder.Entity<ApiSecret>(entity =>
            {
                entity.HasIndex(e => e.ApiResourceId, "IX_ApiSecrets_ApiResourceId");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiSecrets)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<AppealType>(entity =>
            {
                entity.ToTable("AppealTypes", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NeedSendToCrm)
                    .HasColumnName("needSendToCRM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("typeName");
            });

            modelBuilder.Entity<BackInStockSubscription>(entity =>
            {
                entity.ToTable("BackInStockSubscription");

                entity.HasIndex(e => e.CustomerId, "IX_BackInStockSubscription_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_BackInStockSubscription_ProductId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BackInStockSubscriptions)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BackInStockSubscriptions)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.ToTable("BankAccounts", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodePsservice).HasColumnName("codePSService");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("merchantId");

                entity.Property(e => e.NameAccount)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nameAccount");

                entity.Property(e => e.NamePid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("namePID");

                entity.Property(e => e.OrgFindName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("orgFindName");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("orgName");

                entity.Property(e => e.OrgSnCode).HasColumnName("orgSnCode");

                entity.Property(e => e.OrgSnId).HasColumnName("orgSnId");

                entity.Property(e => e.TypePayId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePayId");

                entity.HasOne(d => d.TypePay)
                    .WithMany(p => p.BankAccounts)
                    .HasForeignKey(d => d.TypePayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TypePays");
            });

            modelBuilder.Entity<BankFaset>(entity =>
            {
                entity.HasKey(e => e.BankCode)
                    .HasName("PK__BankFase__7C3F297B6856A076");

                entity.ToTable("BankFaset", "smsr");

                entity.Property(e => e.BankCode)
                    .ValueGeneratedNever()
                    .HasColumnName("bankCode");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BaseSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaseSettings", "crm");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("settingName");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.ToTable("BlogComment");

                entity.HasIndex(e => e.BlogPostId, "IX_BlogComment_BlogPostId");

                entity.HasIndex(e => e.CustomerId, "IX_BlogComment_CustomerId");

                entity.HasIndex(e => e.StoreId, "IX_BlogComment_StoreId");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.BlogPostId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.ToTable("BlogPost");

                entity.HasIndex(e => e.LanguageId, "IX_BlogPost_LanguageId");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.ToTable("Campaign");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.Deleted, "IX_Category_Deleted_Extended");

                entity.HasIndex(e => e.DisplayOrder, "IX_Category_DisplayOrder");

                entity.HasIndex(e => e.LimitedToStores, "IX_Category_LimitedToStores");

                entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Category_SubjectToAcl");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<CategoryTemplate>(entity =>
            {
                entity.ToTable("CategoryTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ChatHouse>(entity =>
            {
                entity.ToTable("ChatHouse", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.HouseId).HasColumnName("houseId");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<CheckPayOrdersStatus>(entity =>
            {
                entity.ToTable("CheckPayOrdersStatus", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkDate");

                entity.Property(e => e.PayId).HasColumnName("payId");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.CheckPayOrdersStatuses)
                    .HasForeignKey(d => d.PayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckPayOrdersStatus_payId");
            });

            modelBuilder.Entity<CheckoutAttribute>(entity =>
            {
                entity.ToTable("CheckoutAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttributeValue>(entity =>
            {
                entity.ToTable("CheckoutAttributeValue");

                entity.HasIndex(e => e.CheckoutAttributeId, "IX_CheckoutAttributeValue_CheckoutAttributeId");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CheckoutAttribute)
                    .WithMany(p => p.CheckoutAttributeValues)
                    .HasForeignKey(d => d.CheckoutAttributeId);
            });

            modelBuilder.Entity<CityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CityView", "fias");

                entity.Property(e => e.Actstatus).HasColumnName("actstatus");

                entity.Property(e => e.Aoguid).HasColumnName("aoguid");

                entity.Property(e => e.Aoid).HasColumnName("aoid");

                entity.Property(e => e.Aolevel).HasColumnName("aolevel");

                entity.Property(e => e.Areacode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("areacode")
                    .IsFixedLength(true);

                entity.Property(e => e.Autocode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("autocode")
                    .IsFixedLength(true);

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("cadnum");

                entity.Property(e => e.Centstatus).HasColumnName("centstatus");

                entity.Property(e => e.Citycode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("citycode")
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Ctarcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ctarcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Currstatus).HasColumnName("currstatus");

                entity.Property(e => e.Divtype).HasColumnName("divtype");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Extrcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extrcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Formalname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("formalname");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Livestatus).HasColumnName("livestatus");

                entity.Property(e => e.Nextid).HasColumnName("nextid");

                entity.Property(e => e.Normdoc).HasColumnName("normdoc");

                entity.Property(e => e.Offname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("offname");

                entity.Property(e => e.OffnameParent)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("offnameParent");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato")
                    .IsFixedLength(true);

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("oktmo")
                    .IsFixedLength(true);

                entity.Property(e => e.Operstatus).HasColumnName("operstatus");

                entity.Property(e => e.Parentguid).HasColumnName("parentguid");

                entity.Property(e => e.Placecode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("placecode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plaincode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("plaincode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plancode)
                    .HasMaxLength(4)
                    .HasColumnName("plancode");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("postalcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Previd).HasColumnName("previd");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("regioncode")
                    .IsFixedLength(true);

                entity.Property(e => e.Sextcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sextcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Shortname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shortname")
                    .IsFixedLength(true);

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Streetcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("streetcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("date")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Clients_ClientId")
                    .IsUnique();

                entity.Property(e => e.BackChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.ClientClaimsPrefix).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.ClientUri).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FrontChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.LogoUri).HasMaxLength(2000);

                entity.Property(e => e.PairWiseSubjectSalt).HasMaxLength(200);

                entity.Property(e => e.ProtocolType)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ClientClaim>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientClaims_ClientId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientClaims)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientCorsOrigin>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientCorsOrigins_ClientId");

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCorsOrigins)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientGrantType>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientGrantTypes_ClientId");

                entity.Property(e => e.GrantType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientGrantTypes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientIdPrestriction>(entity =>
            {
                entity.ToTable("ClientIdPRestrictions");

                entity.HasIndex(e => e.ClientId, "IX_ClientIdPRestrictions_ClientId");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientIdPrestrictions)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientPostLogoutRedirectUri>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientPostLogoutRedirectUris_ClientId");

                entity.Property(e => e.PostLogoutRedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPostLogoutRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientProperty>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientProperties_ClientId");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProperties)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientRedirectUri>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientRedirectUris_ClientId");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientScope>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientScopes_ClientId");

                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientScopes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientSecret>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_ClientSecrets_ClientId");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSecrets)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Communication0820Sn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Communication0820_SN", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Number)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasIndex(e => e.DisplayOrder, "IX_Country_DisplayOrder");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<CrossSellProduct>(entity =>
            {
                entity.ToTable("CrossSellProduct");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.HasIndex(e => e.DisplayOrder, "IX_Currency_DisplayOrder");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.BillingAddressId, "IX_Customer_BillingAddress_Id");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Customer_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerGuid, "IX_Customer_CustomerGuid");

                entity.HasIndex(e => e.Email, "IX_Customer_Email");

                entity.HasIndex(e => e.ShippingAddressId, "IX_Customer_ShippingAddress_Id");

                entity.HasIndex(e => e.SystemName, "IX_Customer_SystemName");

                entity.HasIndex(e => e.Username, "IX_Customer_Username");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);

                entity.Property(e => e.IdentificationUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username).HasMaxLength(1000);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomerBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId);

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId);
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId });

                entity.HasIndex(e => e.AddressId, "IX_CustomerAddresses_Address_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                entity.ToTable("CustomerAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CustomerAttributeValue>(entity =>
            {
                entity.ToTable("CustomerAttributeValue");

                entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerAttributeValue_CustomerAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerAttributeValues)
                    .HasForeignKey(d => d.CustomerAttributeId);
            });

            modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId });

                entity.ToTable("Customer_CustomerRole_Mapping");

                entity.HasIndex(e => e.CustomerRoleId, "IX_Customer_CustomerRole_Mapping_CustomerRole_Id");

                entity.HasIndex(e => e.CustomerId, "IX_Customer_CustomerRole_Mapping_Customer_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId);
            });

            modelBuilder.Entity<CustomerPassword>(entity =>
            {
                entity.ToTable("CustomerPassword");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerPassword_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPasswords)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerRole>(entity =>
            {
                entity.ToTable("CustomerRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<DeletedAccount>(entity =>
            {
                entity.ToTable("DeletedAccounts", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDeleted");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("systemName")
                    .HasDefaultValueSql("('LK')");
            });

            modelBuilder.Entity<DeletedPhone>(entity =>
            {
                entity.ToTable("DeletedPhones", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDeleted");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<DeliveryDate>(entity =>
            {
                entity.ToTable("DeliveryDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DiscountAppliedToCategory>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CategoryId });

                entity.ToTable("Discount_AppliedToCategories");

                entity.HasIndex(e => e.CategoryId, "IX_Discount_AppliedToCategories_Category_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.DiscountId);
            });

            modelBuilder.Entity<DiscountAppliedToManufacturer>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ManufacturerId });

                entity.ToTable("Discount_AppliedToManufacturers");

                entity.HasIndex(e => e.ManufacturerId, "IX_Discount_AppliedToManufacturers_Manufacturer_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.ManufacturerId);
            });

            modelBuilder.Entity<DiscountAppliedToProduct>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ProductId });

                entity.ToTable("Discount_AppliedToProducts");

                entity.HasIndex(e => e.ProductId, "IX_Discount_AppliedToProducts_Product_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<DiscountRequirement>(entity =>
            {
                entity.ToTable("DiscountRequirement");

                entity.HasIndex(e => e.DiscountId, "IX_DiscountRequirement_DiscountId");

                entity.HasIndex(e => e.ParentId, "IX_DiscountRequirement_ParentId");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountRequirements)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<DiscountUsageHistory>(entity =>
            {
                entity.ToTable("DiscountUsageHistory");

                entity.HasIndex(e => e.DiscountId, "IX_DiscountUsageHistory_DiscountId");

                entity.HasIndex(e => e.OrderId, "IX_DiscountUsageHistory_OrderId");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.ToTable("Download");
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.ToTable("EmailAccount");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLogs", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorCode).HasColumnName("errorCode");

                entity.Property(e => e.ErrorMessage)
                    .IsUnicode(false)
                    .HasColumnName("errorMessage");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Ls)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ls");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("place");
            });

            modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                entity.ToTable("ExternalAuthenticationRecord");

                entity.HasIndex(e => e.CustomerId, "IX_ExternalAuthenticationRecord_CustomerId");

                entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalAuthenticationRecords)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<FiasNameWebService>(entity =>
            {
                entity.ToTable("FiasNameWebServices", "smsr");

                entity.HasIndex(e => new { e.Guid, e.NameWebService }, "UIX_FiasNameWebServices__Guid_NameWebService")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameWebService)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiasNameWebServices2>(entity =>
            {
                entity.ToTable("FiasNameWebServices2", "smsr");

                entity.HasIndex(e => new { e.Guid, e.NameWebService }, "UIX_FiasNameWebServices2__Guid_NameWebService")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameWebService)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiasNameWebServicesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FiasNameWebServicesView", "smsr");

                entity.Property(e => e.Accnumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LocalAddresses)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("localAddresses");

                entity.Property(e => e.NameWebService)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Room)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("room");
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.ToTable("Forums_Forum");

                entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Forum_DisplayOrder");

                entity.HasIndex(e => e.ForumGroupId, "IX_Forums_Forum_ForumGroupId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumGroupId);
            });

            modelBuilder.Entity<ForumsGroup>(entity =>
            {
                entity.ToTable("Forums_Group");

                entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Group_DisplayOrder");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ForumsPost>(entity =>
            {
                entity.ToTable("Forums_Post");

                entity.HasIndex(e => e.CustomerId, "IX_Forums_Post_CustomerId");

                entity.HasIndex(e => e.TopicId, "IX_Forums_Post_TopicId");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsPosts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ForumsPosts)
                    .HasForeignKey(d => d.TopicId);
            });

            modelBuilder.Entity<ForumsPostVote>(entity =>
            {
                entity.ToTable("Forums_PostVote");

                entity.HasIndex(e => e.ForumPostId, "IX_Forums_PostVote_ForumPostId");

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumsPostVotes)
                    .HasForeignKey(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumsPrivateMessage>(entity =>
            {
                entity.ToTable("Forums_PrivateMessage");

                entity.HasIndex(e => e.FromCustomerId, "IX_Forums_PrivateMessage_FromCustomerId");

                entity.HasIndex(e => e.ToCustomerId, "IX_Forums_PrivateMessage_ToCustomerId");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.FromCustomer)
                    .WithMany(p => p.ForumsPrivateMessageFromCustomers)
                    .HasForeignKey(d => d.FromCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ToCustomer)
                    .WithMany(p => p.ForumsPrivateMessageToCustomers)
                    .HasForeignKey(d => d.ToCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ForumsSubscription>(entity =>
            {
                entity.ToTable("Forums_Subscription");

                entity.HasIndex(e => e.CustomerId, "IX_Forums_Subscription_CustomerId");

                entity.HasIndex(e => e.ForumId, "IX_Forums_Subscription_ForumId");

                entity.HasIndex(e => e.TopicId, "IX_Forums_Subscription_TopicId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsSubscriptions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ForumsTopic>(entity =>
            {
                entity.ToTable("Forums_Topic");

                entity.HasIndex(e => e.CustomerId, "IX_Forums_Topic_CustomerId");

                entity.HasIndex(e => e.ForumId, "IX_Forums_Topic_ForumId");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsTopics)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsTopics)
                    .HasForeignKey(d => d.ForumId);
            });

            modelBuilder.Entity<GdprConsent>(entity =>
            {
                entity.ToTable("GdprConsent");

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<GdprLog>(entity =>
            {
                entity.ToTable("GdprLog");
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.ToTable("GenericAttribute");

                entity.HasIndex(e => new { e.EntityId, e.KeyGroup }, "IX_GenericAttribute_EntityId_and_KeyGroup");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.ToTable("GiftCard");

                entity.HasIndex(e => e.PurchasedWithOrderItemId, "IX_GiftCard_PurchasedWithOrderItemId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.PurchasedWithOrderItem)
                    .WithMany(p => p.GiftCards)
                    .HasForeignKey(d => d.PurchasedWithOrderItemId);
            });

            modelBuilder.Entity<GiftCardUsageHistory>(entity =>
            {
                entity.ToTable("GiftCardUsageHistory");

                entity.HasIndex(e => e.GiftCardId, "IX_GiftCardUsageHistory_GiftCardId");

                entity.HasIndex(e => e.UsedWithOrderId, "IX_GiftCardUsageHistory_UsedWithOrderId");

                entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.GiftCardId);

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.UsedWithOrderId);
            });

            modelBuilder.Entity<House>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HOUSE", "fias");

                entity.HasIndex(e => e.Aoguid, "IX_House_aoguid");

                entity.HasIndex(e => e.Houseguid, "IX_House_houseguid");

                entity.Property(e => e.Aoguid).HasColumnName("AOGUID");

                entity.Property(e => e.Buildnum)
                    .HasMaxLength(10)
                    .HasColumnName("BUILDNUM");

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("CADNUM");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Divtype).HasColumnName("DIVTYPE");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Eststatus).HasColumnName("ESTSTATUS");

                entity.Property(e => e.Houseguid).HasColumnName("HOUSEGUID");

                entity.Property(e => e.Houseid).HasColumnName("HOUSEID");

                entity.Property(e => e.Housenum)
                    .HasMaxLength(20)
                    .HasColumnName("HOUSENUM");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .HasColumnName("IFNSFL");

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .HasColumnName("IFNSUL");

                entity.Property(e => e.Normdoc).HasColumnName("NORMDOC");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .HasColumnName("OKATO");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .HasColumnName("OKTMO");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .HasColumnName("POSTALCODE");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(2)
                    .HasColumnName("REGIONCODE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Statstatus).HasColumnName("STATSTATUS");

                entity.Property(e => e.Strstatus).HasColumnName("STRSTATUS");

                entity.Property(e => e.Strucnum)
                    .HasMaxLength(10)
                    .HasColumnName("STRUCNUM");

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .HasColumnName("TERRIFNSFL");

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .HasColumnName("TERRIFNSUL");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");
            });

            modelBuilder.Entity<HousesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HousesView", "fias");

                entity.Property(e => e.Aoguid).HasColumnName("aoguid");

                entity.Property(e => e.Buildnum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("buildnum");

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cadnum");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Divtype).HasColumnName("divtype");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Eststatus).HasColumnName("eststatus");

                entity.Property(e => e.Houseguid).HasColumnName("houseguid");

                entity.Property(e => e.Houseid).HasColumnName("houseid");

                entity.Property(e => e.Housenum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("housenum");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsfl");

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsul");

                entity.Property(e => e.Normdoc).HasColumnName("normdoc");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Statstatus).HasColumnName("statstatus");

                entity.Property(e => e.Strstatus).HasColumnName("strstatus");

                entity.Property(e => e.Strucnum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("strucnum");

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsfl");

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsul");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("date")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<IdentityClaim>(entity =>
            {
                entity.HasIndex(e => e.IdentityResourceId, "IX_IdentityClaims_IdentityResourceId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdentityResource)
                    .WithMany(p => p.IdentityClaims)
                    .HasForeignKey(d => d.IdentityResourceId);
            });

            modelBuilder.Entity<IdentityResource>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_IdentityResources_Name")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Images", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Show).HasColumnName("show");
            });

            modelBuilder.Entity<IpPhoneRequest>(entity =>
            {
                entity.ToTable("IpPhoneRequests", "crm");

                entity.HasIndex(e => e.Ip, "IX__IpPhoneRequests_ip_inc_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("account");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCompleted");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RequestTime)
                    .HasColumnType("datetime")
                    .HasColumnName("requestTime");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("userLogin")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.HasIndex(e => e.DisplayOrder, "IX_Language_DisplayOrder");

                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.ToTable("LocaleStringResource");

                entity.HasIndex(e => new { e.ResourceName, e.LanguageId }, "IX_LocaleStringResource");

                entity.HasIndex(e => e.LanguageId, "IX_LocaleStringResource_LanguageId");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResources)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                entity.ToTable("LocalizedProperty");

                entity.HasIndex(e => e.LanguageId, "IX_LocalizedProperty_LanguageId");

                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperties)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Logs", "audit");

                entity.HasIndex(e => new { e.TableId, e.UpdateDate }, "IX_AuditLogs__tableId_UpdateDate")
                    .IsClustered();

                entity.HasIndex(e => e.ActionId, "IX_AuditLogs_actionId");

                entity.HasIndex(e => e.AuditId, "IX_AuditLogs_auditId");

                entity.Property(e => e.ActionId).HasColumnName("actionId");

                entity.Property(e => e.AuditId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AuditID");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.NewValue).HasMaxLength(1000);

                entity.Property(e => e.OldValue).HasMaxLength(1000);

                entity.Property(e => e.PrimaryKeyValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log1>(entity =>
            {
                entity.ToTable("Log");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Log_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_Log_CustomerId");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.ShortMessage).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Log1s)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Log2>(entity =>
            {
                entity.ToTable("Logs", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("error");

                entity.Property(e => e.Gate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gate");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inDate");

                entity.Property(e => e.InMessage)
                    .IsUnicode(false)
                    .HasColumnName("inMessage");

                entity.Property(e => e.IsProcessFinished).HasColumnName("isProcessFinished");

                entity.Property(e => e.IsProcessStarted).HasColumnName("isProcessStarted");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.OutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("outDate");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.QueryTypeId).HasColumnName("queryTypeId");

                entity.HasOne(d => d.QueryType)
                    .WithMany(p => p.Log2s)
                    .HasForeignKey(d => d.QueryTypeId)
                    .HasConstraintName("FK_Logs_QueryTypes");
            });

            modelBuilder.Entity<LogsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LogsView", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.AccountOwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("accountOwnerName");

                entity.Property(e => e.AccountWebServiceId).HasColumnName("accountWebServiceId");

                entity.Property(e => e.AccountWebServiceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accountWebServiceName");

                entity.Property(e => e.AccountWebServiceUrl)
                    .IsUnicode(false)
                    .HasColumnName("accountWebServiceUrl");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("error");

                entity.Property(e => e.Gate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inDate");

                entity.Property(e => e.InMessage)
                    .IsUnicode(false)
                    .HasColumnName("inMessage");

                entity.Property(e => e.IsProcessFinished).HasColumnName("isProcessFinished");

                entity.Property(e => e.IsProcessStarted).HasColumnName("isProcessStarted");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.OutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("outDate");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.QueryTypeCode).HasColumnName("queryTypeCode");

                entity.Property(e => e.QueryTypeId).HasColumnName("queryTypeId");

                entity.Property(e => e.QueryTypeLongName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("queryTypeLongName");

                entity.Property(e => e.QueryTypeShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("queryTypeShortName");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.HasIndex(e => e.DisplayOrder, "IX_Manufacturer_DisplayOrder");

                entity.HasIndex(e => e.LimitedToStores, "IX_Manufacturer_LimitedToStores");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Manufacturer_SubjectToAcl");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<ManufacturerTemplate>(entity =>
            {
                entity.ToTable("ManufacturerTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<MeasureDimension>(entity =>
            {
                entity.ToTable("MeasureDimension");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MeasureWeight>(entity =>
            {
                entity.ToTable("MeasureWeight");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.ToTable("Meetings", "smsr");

                entity.HasIndex(e => e.RiasId, "IX_NonClustered");

                entity.HasIndex(e => e.RiasId, "rias")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressHouse)
                    .HasMaxLength(255)
                    .HasColumnName("addressHouse");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateBeginAbsenteeMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginAbsenteeMeeting");

                entity.Property(e => e.DateBeginIntramuralMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginIntramuralMeeting");

                entity.Property(e => e.DateEndMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateEndMeeting");

                entity.Property(e => e.HouseFiasCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("houseFiasCode");

                entity.Property(e => e.NameTopic)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("nameTopic");

                entity.Property(e => e.RiasId).HasColumnName("riasId");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<MeetingsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MeetingsView", "smsr");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DateBeginAbsenteeMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginAbsenteeMeeting");

                entity.Property(e => e.DateBeginIntramuralMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginIntramuralMeeting");

                entity.Property(e => e.DateEndMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateEndMeeting");

                entity.Property(e => e.FiasNameWebServicesId).HasColumnName("fiasNameWebServicesId");

                entity.Property(e => e.HouseFiasCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("houseFiasCode");

                entity.Property(e => e.MeetingId).HasColumnName("meetingId");

                entity.Property(e => e.NameTopic)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("nameTopic");

                entity.Property(e => e.RiasId).HasColumnName("riasId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.ToTable("MessageTemplate");

                entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<MobilePay>(entity =>
            {
                entity.ToTable("MobilePays", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaysId).HasColumnName("paysId");

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.MobilePays)
                    .HasForeignKey(d => d.PaysId)
                    .HasConstraintName("FK__MobilePay__paysId");
            });

            modelBuilder.Entity<MrtTemplate>(entity =>
            {
                entity.ToTable("MrtTemplate", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActiv).HasColumnName("isActiv");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Template)
                    .HasColumnType("text")
                    .HasColumnName("template");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => e.LanguageId, "IX_News_LanguageId");

                entity.Property(e => e.Full).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Short).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.ToTable("NewsComment");

                entity.HasIndex(e => e.CustomerId, "IX_NewsComment_CustomerId");

                entity.HasIndex(e => e.NewsItemId, "IX_NewsComment_NewsItemId");

                entity.HasIndex(e => e.StoreId, "IX_NewsComment_StoreId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.NewsItemId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                entity.ToTable("NewsLetterSubscription");

                entity.HasIndex(e => new { e.Email, e.StoreId }, "IX_NewsletterSubscription_Email_StoreId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NotOpenLkandDublEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notOpenLKAndDublEmail");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");
            });

            modelBuilder.Entity<NumbersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NumbersView", "smsr");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.BillingAddressId, "IX_Order_BillingAddressId");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Order_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_Order_CustomerId");

                entity.HasIndex(e => e.PickupAddressId, "IX_Order_PickupAddressId");

                entity.HasIndex(e => e.RewardPointsHistoryEntryId, "IX_Order_RewardPointsHistoryEntryId")
                    .IsUnique()
                    .HasFilter("([RewardPointsHistoryEntryId] IS NOT NULL)");

                entity.HasIndex(e => e.ShippingAddressId, "IX_Order_ShippingAddressId");

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CustomOrderNumber).IsRequired();

                entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.PickupAddress)
                    .WithMany(p => p.OrderPickupAddresses)
                    .HasForeignKey(d => d.PickupAddressId);

                entity.HasOne(d => d.RewardPointsHistoryEntry)
                    .WithOne(p => p.Order)
                    .HasForeignKey<Order>(d => d.RewardPointsHistoryEntryId);

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.HasIndex(e => e.OrderId, "IX_OrderItem_OrderId");

                entity.HasIndex(e => e.ProductId, "IX_OrderItem_ProductId");

                entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<OrderNote>(entity =>
            {
                entity.ToTable("OrderNote");

                entity.HasIndex(e => e.OrderId, "IX_OrderNote_OrderId");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNotes)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organizations", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OrganizationW>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrganizationWS", "smsr");

                entity.Property(e => e.OrgId).HasColumnName("orgId");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");

                entity.HasOne(d => d.Org)
                    .WithMany()
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationWS_Organizations");

                entity.HasOne(d => d.WebService)
                    .WithMany()
                    .HasForeignKey(d => d.WebServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationWS_WebServices");
            });

            modelBuilder.Entity<OutMessage>(entity =>
            {
                entity.ToTable("OutMessages", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogId).HasColumnName("logId");

                entity.Property(e => e.ReplyResult)
                    .IsUnicode(false)
                    .HasColumnName("replyResult");

                entity.Property(e => e.Value)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.OutMessages)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs");
            });

            modelBuilder.Entity<PasswordBuff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("passwordBuff", "smsr");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.Value)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.ToTable("Pays", "smsr");

                entity.HasIndex(e => new { e.PspackId, e.Status }, "IX_smsrPays_PSPackId_status_int_id");

                entity.HasIndex(e => e.Guid, "IX_smsrPays_guid")
                    .IsUnique()
                    .HasFilter("([guid] IS NOT NULL)");

                entity.HasIndex(e => e.OrderId, "IX_smsrPays_orderId");

                entity.HasIndex(e => new { e.Status, e.ReqId }, "IX_sn_sms_router_status_reqId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAccount");

                entity.Property(e => e.Comm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comm");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PspackId).HasColumnName("PSPackId");

                entity.Property(e => e.ReqId).HasColumnName("reqId");

                entity.Property(e => e.RequestBilling)
                    .IsUnicode(false)
                    .HasColumnName("requestBilling");

                entity.Property(e => e.RespondBank)
                    .IsUnicode(false)
                    .HasColumnName("respondBank");

                entity.Property(e => e.RespondBilling)
                    .IsUnicode(false)
                    .HasColumnName("respondBilling");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TrxId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_id");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_Pays_PaymentAgents_id");

                entity.HasOne(d => d.TypePayNavigation)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.TypePay)
                    .HasConstraintName("FK_Pays_TypePays");
            });

            modelBuilder.Entity<PayBankComission>(entity =>
            {
                entity.ToTable("PayBankComissions", "smsr");

                entity.HasIndex(e => e.SmsrPayId, "UIX_PayBankComissions_smsrPayId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comm");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResponseBank)
                    .IsUnicode(false)
                    .HasColumnName("responseBank");

                entity.Property(e => e.SmsrPayId).HasColumnName("smsrPayId");

                entity.Property(e => e.Summ)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summ");

                entity.HasOne(d => d.SmsrPay)
                    .WithOne(p => p.PayBankComission)
                    .HasForeignKey<PayBankComission>(d => d.SmsrPayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PayBankCo__smsrP__375B2DB9");
            });

            modelBuilder.Entity<PaymentAgent>(entity =>
            {
                entity.ToTable("PaymentAgents", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.ApplePay).HasColumnName("applePay");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.GooglePay).HasColumnName("googlePay");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Persent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("persent");

                entity.Property(e => e.Regular).HasColumnName("regular");

                entity.Property(e => e.SamsungPay).HasColumnName("samsungPay");

                entity.Property(e => e.Sbp).HasColumnName("SBP");

                entity.HasOne(d => d.BankCodeNavigation)
                    .WithMany(p => p.PaymentAgents)
                    .HasForeignKey(d => d.BankCode)
                    .HasConstraintName("FK__PaymentAg__bankC__7073AF84");
            });

            modelBuilder.Entity<PaymentBasesArhiv09022018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentBases_arhiv09022018", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<PaymentBasesTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentBasesTemp", "smsr");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<PaymentBasesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaymentBasesView", "smsr");

                entity.Property(e => e.AddressBankPay)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("addressBankPay");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agentName");

                entity.Property(e => e.ApplePay).HasColumnName("applePay");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.BankCodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankCodeName");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.CertName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.CheckUrlBank)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("checkUrlBank");

                entity.Property(e => e.GooglePay).HasColumnName("googlePay");

                entity.Property(e => e.LongCertName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("longCertName");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PathCert)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.Persent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("persent");

                entity.Property(e => e.Regular).HasColumnName("regular");

                entity.Property(e => e.SamsungPay).HasColumnName("samsungPay");

                entity.Property(e => e.Shluz).HasColumnName("shluz");

                entity.Property(e => e.Srvnum).HasColumnName("srvnum");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");

                entity.Property(e => e.WebServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("webServiceName");
            });

            modelBuilder.Entity<PaymentBasis>(entity =>
            {
                entity.ToTable("PaymentBases", "smsr");

                entity.HasIndex(e => new { e.PaymentAgentId, e.WebServiceId }, "IX_PaymentBases")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");

                entity.HasOne(d => d.PaymentAgent)
                    .WithMany(p => p.PaymentBases)
                    .HasForeignKey(d => d.PaymentAgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentBases_PaymentAgents");

                entity.HasOne(d => d.TypePayNavigation)
                    .WithMany(p => p.PaymentBases)
                    .HasForeignKey(d => d.TypePay)
                    .HasConstraintName("FK_PaymentBases_typePay");

                entity.HasOne(d => d.WebService)
                    .WithMany(p => p.PaymentBases)
                    .HasForeignKey(d => d.WebServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentBases_WebServices");
            });

            modelBuilder.Entity<PaymentCase>(entity =>
            {
                entity.ToTable("PaymentCase", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxSumPay).HasColumnName("maxSumPay");

                entity.Property(e => e.MinSumPay).HasColumnName("minSumPay");

                entity.Property(e => e.TypePaysId).HasColumnName("typePaysId");
            });

            modelBuilder.Entity<PaymentService>(entity =>
            {
                entity.ToTable("PaymentServices", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PaymentCaseId).HasColumnName("paymentCaseId");

                entity.Property(e => e.PaymentPage).HasColumnName("paymentPage");

                entity.Property(e => e.ServiceCode).HasColumnName("serviceCode");

                entity.Property(e => e.TypeAction)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("typeAction");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");

                entity.HasOne(d => d.WebService)
                    .WithMany(p => p.PaymentServices)
                    .HasForeignKey(d => d.WebServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentServices_WebServices");
            });

            modelBuilder.Entity<PaymentServiceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaymentServiceView", "smsr");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.AddressBankPay)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("addressBankPay");

                entity.Property(e => e.ApplePay).HasColumnName("applePay");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.CertName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.CheckUrlBank)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("checkUrlBank");

                entity.Property(e => e.GooglePay).HasColumnName("googlePay");

                entity.Property(e => e.HasBankComission).HasColumnName("hasBankComission");

                entity.Property(e => e.HasServiceComission).HasColumnName("hasServiceComission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LongCertName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("longCertName");

                entity.Property(e => e.MaxCom).HasColumnName("maxCom");

                entity.Property(e => e.MaxSummPaidForLk).HasColumnName("maxSummPaidForLk");

                entity.Property(e => e.MinCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minCom");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PathCert)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.PaymentAgentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentAgentName");

                entity.Property(e => e.PaymentBaseId).HasColumnName("paymentBaseId");

                entity.Property(e => e.PaymentPage).HasColumnName("paymentPage");

                entity.Property(e => e.PersentCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("persentCom");

                entity.Property(e => e.Regular).HasColumnName("regular");

                entity.Property(e => e.SamsungPay).HasColumnName("samsungPay");

                entity.Property(e => e.Sbp).HasColumnName("SBP");

                entity.Property(e => e.ServiceCode).HasColumnName("serviceCode");

                entity.Property(e => e.Shluz).HasColumnName("shluz");

                entity.Property(e => e.TypeAction)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("typeAction");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<PaymentServiceViewTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaymentServiceView_test", "smsr");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.AddressBankPay)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("addressBankPay");

                entity.Property(e => e.ApplePay).HasColumnName("applePay");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.CertName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.CheckUrlBank)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("checkUrlBank");

                entity.Property(e => e.GooglePay).HasColumnName("googlePay");

                entity.Property(e => e.HasBankComission).HasColumnName("hasBankComission");

                entity.Property(e => e.HasServiceComission).HasColumnName("hasServiceComission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LongCertName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("longCertName");

                entity.Property(e => e.MaxCom).HasColumnName("maxCom");

                entity.Property(e => e.MaxSummPaidForLk).HasColumnName("maxSummPaidForLk");

                entity.Property(e => e.MinCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minCom");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PathCert)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.PaymentAgentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentAgentName");

                entity.Property(e => e.PaymentBaseId).HasColumnName("paymentBaseId");

                entity.Property(e => e.PaymentPage).HasColumnName("paymentPage");

                entity.Property(e => e.PersentCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("persentCom");

                entity.Property(e => e.Regular).HasColumnName("regular");

                entity.Property(e => e.SamsungPay).HasColumnName("samsungPay");

                entity.Property(e => e.Sbp).HasColumnName("SBP");

                entity.Property(e => e.ServiceCode).HasColumnName("serviceCode");

                entity.Property(e => e.Shluz).HasColumnName("shluz");

                entity.Property(e => e.TypeAction)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("typeAction");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<PaysEpd47View>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaysEpd47View", "smsr");

                entity.Property(e => e.ДатаПроведенияПлатежа)
                    .HasColumnType("datetime")
                    .HasColumnName("Дата проведения платежа");

                entity.Property(e => e.ДатаСозданияПлатежа)
                    .HasColumnType("datetime")
                    .HasColumnName("Дата создания платежа");

                entity.Property(e => e.ЛицевойСчет)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Лицевой счет");

                entity.Property(e => e.Логин)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ОтветБанка)
                    .IsUnicode(false)
                    .HasColumnName("Ответ банка");

                entity.Property(e => e.ПериодОплаты)
                    .HasColumnType("datetime")
                    .HasColumnName("Период оплаты");

                entity.Property(e => e.Район)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.СостояниеПлатежа)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Состояние платежа");

                entity.Property(e => e.СуммаПлатежа)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Сумма платежа");
            });

            modelBuilder.Entity<PaysView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PaysView", "smsr");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentName");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAccount");

                entity.Property(e => e.CertName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.Comm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comm");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.PathCert)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PspackId).HasColumnName("PSPackId");

                entity.Property(e => e.ReqId).HasColumnName("reqId");

                entity.Property(e => e.RequestBilling)
                    .IsUnicode(false)
                    .HasColumnName("requestBilling");

                entity.Property(e => e.RespondBank)
                    .IsUnicode(false)
                    .HasColumnName("respondBank");

                entity.Property(e => e.RespondBilling)
                    .IsUnicode(false)
                    .HasColumnName("respondBilling");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TrxId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_id");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<PermissionRecord>(entity =>
            {
                entity.ToTable("PermissionRecord");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId });

                entity.ToTable("PermissionRecord_Role_Mapping");

                entity.HasIndex(e => e.CustomerRoleId, "IX_PermissionRecord_Role_Mapping_CustomerRole_Id");

                entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId);

                entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.PermissionRecordId);
            });

            modelBuilder.Entity<PersistedGrant>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_PersistedGrants_SubjectId_ClientId_Type");

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Persons", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personINN");

                entity.Property(e => e.PersonSnId).HasColumnName("personSnId");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personSNILS");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("Phones", "smsr");

                entity.HasIndex(e => e.Value, "IX_smsr_Phones_value")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptingPolicy).HasColumnName("acceptingPolicy");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contactPhone");

                entity.Property(e => e.CountShowMeassage).HasColumnName("countShowMeassage");

                entity.Property(e => e.DateConfirmation).HasColumnType("datetime");

                entity.Property(e => e.DateRegistration).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.GenerateToken).HasColumnName("generateToken");

                entity.Property(e => e.GenerateTokenForEmail).HasColumnName("generateTokenForEmail");

                entity.Property(e => e.InfoId).HasColumnName("infoId");

                entity.Property(e => e.Jkhid).HasColumnName("JKHId");

                entity.Property(e => e.LastloginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastloginDate");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<PhoneInfo>(entity =>
            {
                entity.ToTable("PhoneInfo", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountShowMeassage).HasColumnName("countShowMeassage");

                entity.Property(e => e.CountShowSend).HasColumnName("countShowSend");

                entity.Property(e => e.DateChangeLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("dateChangeLogin");

                entity.Property(e => e.Device)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("device");

                entity.Property(e => e.GuidInShop).HasColumnName("guidInShop");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Send)
                    .HasColumnName("send")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Token)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("token");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneInfos)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("FK_PhoneInfo_Phones");
            });

            modelBuilder.Entity<PhoneInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PhoneInfoView", "smsr");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contactPhone");

                entity.Property(e => e.DateChangeLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("dateChangeLogin");

                entity.Property(e => e.DateConfirmation).HasColumnType("datetime");

                entity.Property(e => e.DateRegistration).HasColumnType("datetime");

                entity.Property(e => e.Device)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("device");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.GenerateTokenForEmail).HasColumnName("generateTokenForEmail");

                entity.Property(e => e.GuidInShop).HasColumnName("guidInShop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Send).HasColumnName("send");

                entity.Property(e => e.Token)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("token");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<PhoneNotification>(entity =>
            {
                entity.ToTable("PhoneNotifications", "smsr");

                entity.HasIndex(e => e.PhoneId, "IX_PhoneNotifications")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfirmedSendEmail)
                    .IsRequired()
                    .HasColumnName("confirmedSendEmail")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendEmail)
                    .IsRequired()
                    .HasDefaultValueSql("([smsr].[NotificDefaultValue]('DefaultNotificEmail'))");

                entity.Property(e => e.IsSendMobileApp)
                    .IsRequired()
                    .HasDefaultValueSql("([smsr].[NotificDefaultValue]('DefaultNotificMobileApp'))");

                entity.Property(e => e.IsSendViber)
                    .IsRequired()
                    .HasDefaultValueSql("([smsr].[NotificDefaultValue]('DefaultNotificViber'))");

                entity.Property(e => e.IsSendWebApp)
                    .IsRequired()
                    .HasDefaultValueSql("([smsr].[NotificDefaultValue]('DefaultNotificWebApp'))");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Phone)
                    .WithOne(p => p.PhoneNotification)
                    .HasForeignKey<PhoneNotification>(d => d.PhoneId)
                    .HasConstraintName("FK_PhoneNotifications_Phones");
            });

            modelBuilder.Entity<PhoneSend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PhoneSend");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<PhoneService>(entity =>
            {
                entity.ToTable("PhoneServices", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("Picture");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<PictureBinary>(entity =>
            {
                entity.ToTable("PictureBinary");

                entity.HasIndex(e => e.PictureId, "IX_PictureBinary_PictureId")
                    .IsUnique();

                entity.HasOne(d => d.Picture)
                    .WithOne(p => p.PictureBinary)
                    .HasForeignKey<PictureBinary>(d => d.PictureId);
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.ToTable("Poll");

                entity.HasIndex(e => e.LanguageId, "IX_Poll_LanguageId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Polls)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<PollAnswer>(entity =>
            {
                entity.ToTable("PollAnswer");

                entity.HasIndex(e => e.PollId, "IX_PollAnswer_PollId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollAnswers)
                    .HasForeignKey(d => d.PollId);
            });

            modelBuilder.Entity<PollVotingRecord>(entity =>
            {
                entity.ToTable("PollVotingRecord");

                entity.HasIndex(e => e.CustomerId, "IX_PollVotingRecord_CustomerId");

                entity.HasIndex(e => e.PollAnswerId, "IX_PollVotingRecord_PollAnswerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PollVotingRecords)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.PollAnswer)
                    .WithMany(p => p.PollVotingRecords)
                    .HasForeignKey(d => d.PollAnswerId);
            });

            modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
            {
                entity.ToTable("PredefinedProductAttributeValue");

                entity.HasIndex(e => e.ProductAttributeId, "IX_PredefinedProductAttributeValue_ProductAttributeId");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.PredefinedProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => new { e.Deleted, e.VendorId, e.ProductTypeId, e.ManageInventoryMethodId, e.MinStockQuantity, e.UseMultipleWarehouses }, "IX_GetLowStockProducts");

                entity.HasIndex(e => new { e.Deleted, e.Id }, "IX_Product_Delete_Id");

                entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Deleted_and_Published");

                entity.HasIndex(e => e.LimitedToStores, "IX_Product_LimitedToStores");

                entity.HasIndex(e => e.ParentGroupedProductId, "IX_Product_ParentGroupedProductId");

                entity.HasIndex(e => new { e.Price, e.AvailableStartDateTimeUtc, e.AvailableEndDateTimeUtc, e.Published, e.Deleted }, "IX_Product_PriceDatesEtc");

                entity.HasIndex(e => e.Published, "IX_Product_Published");

                entity.HasIndex(e => e.ShowOnHomePage, "IX_Product_ShowOnHomepage");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Product_SubjectToAcl");

                entity.HasIndex(e => e.VisibleIndividually, "IX_Product_VisibleIndividually");

                entity.HasIndex(e => new { e.VisibleIndividually, e.Published, e.Deleted }, "IX_Product_VisibleIndividually_Published_Deleted_Extended");

                entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OverriddenGiftCardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductAttributeCombination>(entity =>
            {
                entity.ToTable("ProductAttributeCombination");

                entity.HasIndex(e => e.ProductId, "IX_ProductAttributeCombination_ProductId");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeCombinations)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.ToTable("ProductAttributeValue");

                entity.HasIndex(e => e.ProductAttributeMappingId, "IX_ProductAttributeValue_ProductAttributeMappingId");

                entity.HasIndex(e => new { e.ProductAttributeMappingId, e.DisplayOrder }, "IX_ProductAttributeValue_ProductAttributeMappingId_DisplayOrder");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttributeMapping)
                    .WithMany(p => p.ProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeMappingId);
            });

            modelBuilder.Entity<ProductAvailabilityRange>(entity =>
            {
                entity.ToTable("ProductAvailabilityRange");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                entity.ToTable("Product_Category_Mapping");

                entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PCM_ProductId_Extended");

                entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category");

                entity.HasIndex(e => e.CategoryId, "IX_Product_Category_Mapping_CategoryId");

                entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Category_Mapping_IsFeaturedProduct");

                entity.HasIndex(e => e.ProductId, "IX_Product_Category_Mapping_ProductId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                entity.ToTable("Product_Manufacturer_Mapping");

                entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PMM_ProductId_Extended");

                entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer");

                entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Manufacturer_Mapping_IsFeaturedProduct");

                entity.HasIndex(e => e.ManufacturerId, "IX_Product_Manufacturer_Mapping_ManufacturerId");

                entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ManufacturerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasIndex(e => e.PictureId, "IX_Product_Picture_Mapping_PictureId");

                entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                entity.ToTable("Product_ProductAttribute_Mapping");

                entity.HasIndex(e => e.ProductAttributeId, "IX_Product_ProductAttribute_Mapping_ProductAttributeId");

                entity.HasIndex(e => e.ProductId, "IX_Product_ProductAttribute_Mapping_ProductId");

                entity.HasIndex(e => new { e.ProductId, e.DisplayOrder }, "IX_Product_ProductAttribute_Mapping_ProductId_DisplayOrder");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductTagId });

                entity.ToTable("Product_ProductTag_Mapping");

                entity.HasIndex(e => e.ProductTagId, "IX_Product_ProductTag_Mapping_ProductTag_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductTagId);
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");

                entity.HasIndex(e => e.CustomerId, "IX_ProductReview_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId");

                entity.HasIndex(e => e.StoreId, "IX_ProductReview_StoreId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.ToTable("ProductReviewHelpfulness");

                entity.HasIndex(e => e.ProductReviewId, "IX_ProductReviewHelpfulness_ProductReviewId");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulnesses)
                    .HasForeignKey(d => d.ProductReviewId);
            });

            modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
            {
                entity.ToTable("ProductReview_ReviewType_Mapping");

                entity.HasIndex(e => e.ProductReviewId, "IX_ProductReview_ReviewType_Mapping_ProductReviewId");

                entity.HasIndex(e => e.ReviewTypeId, "IX_ProductReview_ReviewType_Mapping_ReviewTypeId");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ProductReviewId);

                entity.HasOne(d => d.ReviewType)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ReviewTypeId);
            });

            modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                entity.ToTable("Product_SpecificationAttribute_Mapping");

                entity.HasIndex(e => e.AllowFiltering, "IX_PSAM_AllowFiltering");

                entity.HasIndex(e => new { e.SpecificationAttributeOptionId, e.AllowFiltering }, "IX_PSAM_SpecificationAttributeOptionId_AllowFiltering");

                entity.HasIndex(e => e.ProductId, "IX_Product_SpecificationAttribute_Mapping_ProductId");

                entity.HasIndex(e => e.SpecificationAttributeOptionId, "IX_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId");

                entity.Property(e => e.CustomValue).HasMaxLength(4000);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId);
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.ToTable("ProductTag");

                entity.HasIndex(e => e.Name, "IX_ProductTag_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.ToTable("ProductTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductWarehouseInventory>(entity =>
            {
                entity.ToTable("ProductWarehouseInventory");

                entity.HasIndex(e => e.ProductId, "IX_ProductWarehouseInventory_ProductId");

                entity.HasIndex(e => e.WarehouseId, "IX_ProductWarehouseInventory_WarehouseId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductWarehouseInventories)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouseInventories)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<ProviderInfo>(entity =>
            {
                entity.ToTable("ProviderInfo", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ServiceIdentityName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("serviceIdentityName")
                    .HasDefaultValueSql("('123')");

                entity.Property(e => e.TypePay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.HasOne(d => d.TypePayNavigation)
                    .WithMany(p => p.ProviderInfos)
                    .HasForeignKey(d => d.TypePay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderInfo_typePay");
            });

            modelBuilder.Entity<ProviderInfoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProviderInfoView", "smsr");

                entity.Property(e => e.AddressBankPay)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("addressBankPay");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApplePay).HasColumnName("applePay");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.CertName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.Certhash)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("certhash");

                entity.Property(e => e.CheckUrlBank)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("checkUrlBank");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.GooglePay).HasColumnName("googlePay");

                entity.Property(e => e.HasBankComission).HasColumnName("hasBankComission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LongCertName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("longCertName");

                entity.Property(e => e.MaxSumPayForLk).HasColumnName("maxSumPayForLk");

                entity.Property(e => e.MinCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minCom");

                entity.Property(e => e.MinSummPaidForLk).HasColumnName("minSummPaidForLk");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PathCert)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.PersentCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("persentCom");

                entity.Property(e => e.Regular).HasColumnName("regular");

                entity.Property(e => e.SamsungPay).HasColumnName("samsungPay");

                entity.Property(e => e.Sbp).HasColumnName("SBP");

                entity.Property(e => e.ServiceIdentityName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("serviceIdentityName");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("serviceName");

                entity.Property(e => e.Shluz).HasColumnName("shluz");

                entity.Property(e => e.TypePay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.TypePayId).HasColumnName("typePayId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<PushMeetingsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PushMeetingsView", "smsr");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DateBeginAbsenteeMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginAbsenteeMeeting");

                entity.Property(e => e.DateBeginIntramuralMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateBeginIntramuralMeeting");

                entity.Property(e => e.DateEndMeeting)
                    .HasColumnType("date")
                    .HasColumnName("dateEndMeeting");

                entity.Property(e => e.HouseFiasCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("houseFiasCode");

                entity.Property(e => e.NameTopic)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("nameTopic");

                entity.Property(e => e.PushMeetingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pushMeetingId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<QueryType>(entity =>
            {
                entity.ToTable("QueryTypes", "smsr");

                entity.HasIndex(e => e.Code, "UX_QueryTypes__Code")
                    .IsUnique();

                entity.HasIndex(e => e.LongName, "UX_QueryTypes__Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.LongName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("longName");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shortName");
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QuestionAnswers", "smsr");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("answer");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("question");

                entity.Property(e => e.Show)
                    .IsRequired()
                    .HasColumnName("show")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.ToTable("QueuedEmail");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_QueuedEmail_CreatedOnUtc");

                entity.HasIndex(e => e.EmailAccountId, "IX_QueuedEmail_EmailAccountId");

                entity.HasIndex(e => new { e.SentOnUtc, e.DontSendBeforeDateUtc }, "IX_QueuedEmail_SentOnUtc_DontSendBeforeDateUtc_Extended");

                entity.Property(e => e.Bcc).HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .HasColumnName("CC");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FromName).HasMaxLength(500);

                entity.Property(e => e.ReplyTo).HasMaxLength(500);

                entity.Property(e => e.ReplyToName).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(1000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ToName).HasMaxLength(500);

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmails)
                    .HasForeignKey(d => d.EmailAccountId);
            });

            modelBuilder.Entity<Qwerty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qwerty", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<RecurringPayment>(entity =>
            {
                entity.ToTable("RecurringPayment");

                entity.HasIndex(e => e.InitialOrderId, "IX_RecurringPayment_InitialOrderId");

                entity.HasOne(d => d.InitialOrder)
                    .WithMany(p => p.RecurringPayments)
                    .HasForeignKey(d => d.InitialOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RecurringPaymentHistory>(entity =>
            {
                entity.ToTable("RecurringPaymentHistory");

                entity.HasIndex(e => e.RecurringPaymentId, "IX_RecurringPaymentHistory_RecurringPaymentId");

                entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.RecurringPaymentHistories)
                    .HasForeignKey(d => d.RecurringPaymentId);
            });

            modelBuilder.Entity<RegistrationRequest>(entity =>
            {
                entity.ToTable("RegistrationRequests", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastPay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastPay");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.RoomSpace)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("roomSpace");
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.ToTable("RelatedProduct");

                entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Requests", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AppealTypesId).HasColumnName("appealTypesId");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("externalNumber");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ReturnRequest>(entity =>
            {
                entity.ToTable("ReturnRequest");

                entity.HasIndex(e => e.CustomerId, "IX_ReturnRequest_CustomerId");

                entity.Property(e => e.ReasonForReturn).IsRequired();

                entity.Property(e => e.RequestedAction).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReturnRequests)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ReturnRequestAction>(entity =>
            {
                entity.ToTable("ReturnRequestAction");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReturnRequestReason>(entity =>
            {
                entity.ToTable("ReturnRequestReason");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReviewType>(entity =>
            {
                entity.ToTable("ReviewType");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<RewardPointsHistory>(entity =>
            {
                entity.ToTable("RewardPointsHistory");

                entity.HasIndex(e => e.CustomerId, "IX_RewardPointsHistory_CustomerId");

                entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RewardPointsHistories)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROOM", "fias");

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("CADNUM");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Flatnumber)
                    .HasMaxLength(50)
                    .HasColumnName("FLATNUMBER");

                entity.Property(e => e.Flattype).HasColumnName("FLATTYPE");

                entity.Property(e => e.Houseguid).HasColumnName("HOUSEGUID");

                entity.Property(e => e.Livestatus).HasColumnName("LIVESTATUS");

                entity.Property(e => e.Nextid).HasColumnName("NEXTID");

                entity.Property(e => e.Normdoc).HasColumnName("NORMDOC");

                entity.Property(e => e.Operstatus).HasColumnName("OPERSTATUS");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .HasColumnName("POSTALCODE");

                entity.Property(e => e.Previd).HasColumnName("PREVID");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(2)
                    .HasColumnName("REGIONCODE");

                entity.Property(e => e.Roomcadnum)
                    .HasMaxLength(100)
                    .HasColumnName("ROOMCADNUM");

                entity.Property(e => e.Roomguid).HasColumnName("ROOMGUID");

                entity.Property(e => e.Roomid).HasColumnName("ROOMID");

                entity.Property(e => e.Roomnumber)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNUMBER");

                entity.Property(e => e.Roomtype).HasColumnName("ROOMTYPE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");
            });

            modelBuilder.Entity<ScheduleTask>(entity =>
            {
                entity.ToTable("ScheduleTask");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<SearchTerm>(entity =>
            {
                entity.ToTable("SearchTerm");
            });

            modelBuilder.Entity<SendChecksToEmail>(entity =>
            {
                entity.ToTable("SendChecksToEmail", "smsr");

                entity.HasIndex(e => e.SmsrPaysId, "IND_smsrSendChecksToEmail_SmsrPayId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.SmsrPaysId).HasColumnName("smsrPaysId");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SendChecksToEmailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SendChecksToEmailView", "smsr");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.SmsrPaysId).HasColumnName("smsrPaysId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<SendMessage>(entity =>
            {
                entity.ToTable("SendMessages", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("error");

                entity.Property(e => e.Gate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gate");

                entity.Property(e => e.IsProcessFinished).HasColumnName("isProcessFinished");

                entity.Property(e => e.IsProcessStarted).HasColumnName("isProcessStarted");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.QuerySmsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("querySmsId");

                entity.Property(e => e.TextMessage)
                    .IsUnicode(false)
                    .HasColumnName("textMessage");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<SendMessagesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SendMessagesView", "smsr");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Error)
                    .IsUnicode(false)
                    .HasColumnName("error");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsProcessFinished).HasColumnName("isProcessFinished");

                entity.Property(e => e.IsProcessStarted).HasColumnName("isProcessStarted");

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.QuerySmsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("querySmsId");

                entity.Property(e => e.TextMessage)
                    .IsUnicode(false)
                    .HasColumnName("textMessage");
            });

            modelBuilder.Entity<SentSmsLog>(entity =>
            {
                entity.ToTable("SentSmsLogs", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Gate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gate");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RespondGate)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("respondGate");

                entity.Property(e => e.SmsText)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("smsText");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Settings", "crm");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.Value)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Setting1>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<Setting2>(entity =>
            {
                entity.ToTable("Settings", "smsr");

                entity.HasIndex(e => e.Name, "UX_Settings_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");

                entity.HasIndex(e => e.OrderId, "IX_Shipment_OrderId");

                entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.ToTable("ShipmentItem");

                entity.HasIndex(e => e.ShipmentId, "IX_ShipmentItem_ShipmentId");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId);
            });

            modelBuilder.Entity<ShippingByWeightByTotalRecord>(entity =>
            {
                entity.ToTable("ShippingByWeightByTotalRecord");

                entity.Property(e => e.AdditionalFixedCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LowerWeightLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderSubtotalFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderSubtotalTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PercentageRateOfSubtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RatePerWeightUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zip).HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.ToTable("ShippingMethod");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethodRestriction>(entity =>
            {
                entity.HasKey(e => new { e.ShippingMethodId, e.CountryId });

                entity.HasIndex(e => e.CountryId, "IX_ShippingMethodRestrictions_Country_Id");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.ShippingMethodId);
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.ToTable("ShoppingCartItem");

                entity.HasIndex(e => e.CustomerId, "IX_ShoppingCartItem_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_ShoppingCartItem_ProductId");

                entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId }, "IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId");

                entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Socrbase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SOCRBASE", "fias");

                entity.Property(e => e.KodTSt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("KOD_T_ST")
                    .IsFixedLength(true);

                entity.Property(e => e.Level)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL")
                    .IsFixedLength(true);

                entity.Property(e => e.Scname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SCNAME")
                    .IsFixedLength(true);

                entity.Property(e => e.Socrname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOCRNAME")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SpecificationAttribute>(entity =>
            {
                entity.ToTable("SpecificationAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SpecificationAttributeOption>(entity =>
            {
                entity.ToTable("SpecificationAttributeOption");

                entity.HasIndex(e => e.SpecificationAttributeId, "IX_SpecificationAttributeOption_SpecificationAttributeId");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOptions)
                    .HasForeignKey(d => d.SpecificationAttributeId);
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.ToTable("StateProvince");

                entity.HasIndex(e => e.CountryId, "IX_StateProvince_CountryId");

                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvinces)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<StatmentInfo>(entity =>
            {
                entity.ToTable("StatmentInfo", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.Issued)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("issued");

                entity.Property(e => e.PNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("pNumber");

                entity.Property(e => e.PSeries)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pSeries");
            });

            modelBuilder.Entity<StatusPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StatusPays", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<StockQuantityHistory>(entity =>
            {
                entity.ToTable("StockQuantityHistory");

                entity.HasIndex(e => e.ProductId, "IX_StockQuantityHistory_ProductId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockQuantityHistories)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.CompanyVat).HasMaxLength(1000);

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<StoreMapping>(entity =>
            {
                entity.ToTable("StoreMapping");

                entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_StoreMapping_EntityId_EntityName");

                entity.HasIndex(e => e.StoreId, "IX_StoreMapping_StoreId");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreMappings)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<StorePickupPoint>(entity =>
            {
                entity.ToTable("StorePickupPoint");

                entity.Property(e => e.PickupFee).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<StreetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StreetView", "fias");

                entity.Property(e => e.Actstatus).HasColumnName("actstatus");

                entity.Property(e => e.Aoguid).HasColumnName("aoguid");

                entity.Property(e => e.Aoid).HasColumnName("aoid");

                entity.Property(e => e.Aolevel).HasColumnName("aolevel");

                entity.Property(e => e.Areacode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("areacode")
                    .IsFixedLength(true);

                entity.Property(e => e.Autocode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("autocode")
                    .IsFixedLength(true);

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("cadnum");

                entity.Property(e => e.Centstatus).HasColumnName("centstatus");

                entity.Property(e => e.Citycode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("citycode")
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Ctarcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ctarcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Currstatus).HasColumnName("currstatus");

                entity.Property(e => e.Divtype).HasColumnName("divtype");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Extrcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extrcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Formalname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("formalname");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Livestatus).HasColumnName("livestatus");

                entity.Property(e => e.Nextid).HasColumnName("nextid");

                entity.Property(e => e.Normdoc).HasColumnName("normdoc");

                entity.Property(e => e.Offname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("offname");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato")
                    .IsFixedLength(true);

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("oktmo")
                    .IsFixedLength(true);

                entity.Property(e => e.Operstatus).HasColumnName("operstatus");

                entity.Property(e => e.Parentguid).HasColumnName("parentguid");

                entity.Property(e => e.Placecode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("placecode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plaincode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("plaincode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plancode)
                    .HasMaxLength(4)
                    .HasColumnName("plancode");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("postalcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Previd).HasColumnName("previd");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("regioncode")
                    .IsFixedLength(true);

                entity.Property(e => e.Sextcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sextcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Shortname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shortname")
                    .IsFixedLength(true);

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Streetcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("streetcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("date")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<SubjectsCountryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubjectsCountryView", "fias");

                entity.Property(e => e.Actstatus).HasColumnName("actstatus");

                entity.Property(e => e.Aoguid).HasColumnName("aoguid");

                entity.Property(e => e.Aoid).HasColumnName("aoid");

                entity.Property(e => e.Aolevel).HasColumnName("aolevel");

                entity.Property(e => e.Areacode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("areacode")
                    .IsFixedLength(true);

                entity.Property(e => e.Autocode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("autocode")
                    .IsFixedLength(true);

                entity.Property(e => e.Cadnum)
                    .HasMaxLength(100)
                    .HasColumnName("cadnum");

                entity.Property(e => e.Centstatus).HasColumnName("centstatus");

                entity.Property(e => e.Citycode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("citycode")
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Ctarcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ctarcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Currstatus).HasColumnName("currstatus");

                entity.Property(e => e.Divtype).HasColumnName("divtype");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Extrcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extrcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Formalname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("formalname");

                entity.Property(e => e.Ifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Ifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Livestatus).HasColumnName("livestatus");

                entity.Property(e => e.Nextid).HasColumnName("nextid");

                entity.Property(e => e.Normdoc).HasColumnName("normdoc");

                entity.Property(e => e.Offname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("offname");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato")
                    .IsFixedLength(true);

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("oktmo")
                    .IsFixedLength(true);

                entity.Property(e => e.Operstatus).HasColumnName("operstatus");

                entity.Property(e => e.Parentguid).HasColumnName("parentguid");

                entity.Property(e => e.Placecode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("placecode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plaincode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("plaincode")
                    .IsFixedLength(true);

                entity.Property(e => e.Plancode)
                    .HasMaxLength(4)
                    .HasColumnName("plancode");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("postalcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Previd).HasColumnName("previd");

                entity.Property(e => e.Regioncode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("regioncode")
                    .IsFixedLength(true);

                entity.Property(e => e.Sextcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sextcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Shortname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shortname")
                    .IsFixedLength(true);

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Streetcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("streetcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsfl)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsfl")
                    .IsFixedLength(true);

                entity.Property(e => e.Terrifnsul)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("terrifnsul")
                    .IsFixedLength(true);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("date")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<SubscribeAcc>(entity =>
            {
                entity.ToTable("SubscribeAccs", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orgName");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TypeSubcribe).HasColumnName("typeSubcribe");
            });

            modelBuilder.Entity<SubscribeAccsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubscribeAccsView", "smsr");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orgName");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TypeSubcribe).HasColumnName("typeSubcribe");
            });

            modelBuilder.Entity<SystemType>(entity =>
            {
                entity.ToTable("SystemType", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameSystem).IsRequired();
            });

            modelBuilder.Entity<T220520220>(entity =>
            {
                entity.ToTable("t220520220");

                entity.HasIndex(e => e.Pass, "IX_T_22052020");

                entity.HasIndex(e => e.Pass, "IX_T_22052020_filtered")
                    .HasFilter("([unhash] IS NULL)");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Pass)
                    .HasMaxLength(10)
                    .HasColumnName("pass");

                entity.Property(e => e.Unhash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unhash");
            });

            modelBuilder.Entity<T220520220Last>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t220520220LAST");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pass)
                    .HasMaxLength(10)
                    .HasColumnName("pass");

                entity.Property(e => e.Unhash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unhash");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Tables", "audit");

                entity.HasIndex(e => new { e.TableName, e.SchemaName }, "IX_auditTables_schemaName_tableName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuditEnabled).HasColumnName("auditEnabled");

                entity.Property(e => e.AuditFor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auditFor")
                    .HasDefaultValueSql("('insert, update, delete')");

                entity.Property(e => e.AuditMaxRowsCount).HasColumnName("auditMaxRowsCount");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("schemaName");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tableName");

                entity.Property(e => e.TablePk)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("tablePK");
            });

            modelBuilder.Entity<TaxCategory>(entity =>
            {
                entity.ToTable("TaxCategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.ToTable("TaxRate");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Temp090419>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp09_04_19");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Addres)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIO");

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pnumber)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Pseries)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempAccountInfo2019>(entity =>
            {
                entity.ToTable("TempAccountInfo2019", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FiasCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fiasCode");

                entity.Property(e => e.Flat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flat");

                entity.Property(e => e.House)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("house");

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            modelBuilder.Entity<TempAccountInfo2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAccountInfo2020", "smsr");

                entity.HasIndex(e => e.Accountnumber, "IX_TempAccountInfo2020_accountNumber");

                entity.HasIndex(e => new { e.City, e.Street, e.House, e.Accountnumber }, "IX_TempAccountInfo2020_city_street_house_number")
                    .IsUnique();

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("accountnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.BaseId).HasColumnName("baseId");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FiasCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fiasCode");

                entity.Property(e => e.Flat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flat");

                entity.Property(e => e.House)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("house");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            modelBuilder.Entity<TempAccountPhonesViewSv1208>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAccountPhonesView_SV1208", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.BaseIp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("baseIp");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempAccounts0209>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempAccounts0209", "smsr");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempAccounts110719>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempAccounts11_07_19");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("tempId");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempAccounts120719>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempAccounts12_07_19");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("tempId");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempAccounts30112019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAccounts_30_11_2019");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempAccountsSv1208>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAccounts_SV1208", "smsr");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("toDate");

                entity.Property(e => e.TypeRegistration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("typeRegistration");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempApartmentLsNumberFias18022020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_ApartmentLsNumberFIAS_18_02_2020");

                entity.Property(e => e.Accnumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accnumber");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");

                entity.Property(e => e.LocalAddresses)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("localAddresses");

                entity.Property(e => e.Room)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("room");
            });

            modelBuilder.Entity<TempFiasNameWebServices18022020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_FiasNameWebServices_18_02_2020");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameWebService)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempIpPhoneRequests24032020>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PK__TempIpPh__3213E823DDBC1340");

                entity.ToTable("TempIpPhoneRequests24_03_2020", "crm");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TempOblastAccounts04062019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempOblastAccounts04062019", "smsr");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountNumber");

                entity.Property(e => e.BaseIp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("baseIp");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ownerName");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.WebServiceId).HasColumnName("webServiceId");
            });

            modelBuilder.Entity<TempPay031019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempPay031019");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<TempPay2203>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempPay2203", "smsr");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAccount");

                entity.Property(e => e.Comm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comm");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PspackId).HasColumnName("PSPackId");

                entity.Property(e => e.ReqId).HasColumnName("reqId");

                entity.Property(e => e.RequestBilling)
                    .IsUnicode(false)
                    .HasColumnName("requestBilling");

                entity.Property(e => e.RespondBank)
                    .IsUnicode(false)
                    .HasColumnName("respondBank");

                entity.Property(e => e.RespondBilling)
                    .IsUnicode(false)
                    .HasColumnName("respondBilling");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TrxId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_id");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<TempPays2003>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempPays2003", "smsr");

                entity.Property(e => e.Accpu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accpu");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAccount");

                entity.Property(e => e.Comm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comm");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("datePay");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Period)
                    .HasColumnType("datetime")
                    .HasColumnName("period");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PspackId).HasColumnName("PSPackId");

                entity.Property(e => e.ReqId).HasColumnName("reqId");

                entity.Property(e => e.RequestBilling)
                    .IsUnicode(false)
                    .HasColumnName("requestBilling");

                entity.Property(e => e.RespondBank)
                    .IsUnicode(false)
                    .HasColumnName("respondBank");

                entity.Property(e => e.RespondBilling)
                    .IsUnicode(false)
                    .HasColumnName("respondBilling");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionNumber");

                entity.Property(e => e.TrxId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_id");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");
            });

            modelBuilder.Entity<TempPhonesSv1208>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempPhones_SV1208", "smsr");

                entity.Property(e => e.AcceptingPolicy).HasColumnName("acceptingPolicy");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contactPhone");

                entity.Property(e => e.CountShowMeassage).HasColumnName("countShowMeassage");

                entity.Property(e => e.DateConfirmation).HasColumnType("datetime");

                entity.Property(e => e.DateRegistration).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.GenerateToken).HasColumnName("generateToken");

                entity.Property(e => e.GenerateTokenForEmail).HasColumnName("generateTokenForEmail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InfoId).HasColumnName("infoId");

                entity.Property(e => e.LastloginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastloginDate");

                entity.Property(e => e.Owner)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.PersonInn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("personInn");

                entity.Property(e => e.PersonSnils)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("personSnils");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TierPrice>(entity =>
            {
                entity.ToTable("TierPrice");

                entity.HasIndex(e => e.CustomerRoleId, "IX_TierPrice_CustomerRoleId");

                entity.HasIndex(e => e.ProductId, "IX_TierPrice_ProductId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.TierPrices)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TierPrices)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<TmpPay031019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TmpPay031019");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");
            });

            modelBuilder.Entity<TopicTemplate>(entity =>
            {
                entity.ToTable("TopicTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Tt22052020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tt22052020");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<TypePay>(entity =>
            {
                entity.HasKey(e => e.TypePay1);

                entity.ToTable("TypePays", "smsr");

                entity.Property(e => e.TypePay1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typePay");

                entity.Property(e => e.AddressBankPay)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("addressBankPay");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.CertName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certName");

                entity.Property(e => e.Certhash)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("certhash");

                entity.Property(e => e.CheckUrlBank)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("checkUrlBank");

                entity.Property(e => e.HasBankComission).HasColumnName("hasBankComission");

                entity.Property(e => e.HasServiceComission).HasColumnName("hasServiceComission");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LongCertName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("longCertName");

                entity.Property(e => e.MaxCom).HasColumnName("maxCom");

                entity.Property(e => e.MinCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minCom");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PathCert)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pathCert");

                entity.Property(e => e.PaymentAgentId).HasColumnName("paymentAgentId");

                entity.Property(e => e.PersentCom)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("persentCom");

                entity.Property(e => e.Shluz).HasColumnName("shluz");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.PaymentAgent)
                    .WithMany(p => p.TypePays)
                    .HasForeignKey(d => d.PaymentAgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypePays_paymentAgentAId");
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.ToTable("UrlRecord");

                entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive }, "IX_UrlRecord_Custom_1");

                entity.HasIndex(e => e.Slug, "IX_UrlRecord_Slug");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UserDevice>(entity =>
            {
                entity.ToTable("UserDevices", "smsr");

                entity.HasIndex(e => e.PhoneId, "IX_UserDevices__phoneId_inc_DeviceID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created).HasPrecision(2);

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasColumnName("DeviceID");

                entity.Property(e => e.FirebaseDeviceToken).IsRequired();

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.Version)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.UserDevices)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDevices_Phones");
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.ToTable("UserSessions", "smsr");

                entity.HasIndex(e => e.PhoneId, "IX_smsr_UserSessions_phoneId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken).HasColumnName("accessToken");

                entity.Property(e => e.ConnectionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("connectionDate");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.RefreshToken).HasColumnName("refreshToken");

                entity.HasOne(d => d.Phone)
                    .WithOne(p => p.UserSession)
                    .HasForeignKey<UserSession>(d => d.PhoneId)
                    .HasConstraintName("FK_UserSessions_Phones");
            });

            modelBuilder.Entity<UsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.RoleId })
                    .HasName("PK_smsr_UsersInRoles");

                entity.ToTable("UsersInRoles", "smsr");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoleId");
            });

            modelBuilder.Entity<UsersInRolesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UsersInRolesView", "smsr");

                entity.Property(e => e.PhoneId).HasColumnName("phoneId");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            });

            modelBuilder.Entity<VendorAttribute>(entity =>
            {
                entity.ToTable("VendorAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<VendorAttributeValue>(entity =>
            {
                entity.ToTable("VendorAttributeValue");

                entity.HasIndex(e => e.VendorAttributeId, "IX_VendorAttributeValue_VendorAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.VendorAttribute)
                    .WithMany(p => p.VendorAttributeValues)
                    .HasForeignKey(d => d.VendorAttributeId);
            });

            modelBuilder.Entity<VendorNote>(entity =>
            {
                entity.ToTable("VendorNote");

                entity.HasIndex(e => e.VendorId, "IX_VendorNote_VendorId");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorNotes)
                    .HasForeignKey(d => d.VendorId);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<WebService>(entity =>
            {
                entity.ToTable("WebServices", "smsr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BaseIp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("baseIp");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.CheckSumm).HasColumnName("checkSumm");

                entity.Property(e => e.Codedb).HasColumnName("CODEDB");

                entity.Property(e => e.IsLkactive).HasColumnName("isLKActive");

                entity.Property(e => e.IsSaveRecalcForIndications)
                    .HasColumnName("isSaveRecalcForIndications")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Srvnum).HasColumnName("srvnum");

                entity.Property(e => e.SrvnumKapRem).HasColumnName("srvnumKapRem");

                entity.Property(e => e.SystemType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("systemType");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<WebServicesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WebServicesView", "smsr");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BaseIp)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("baseIp");

                entity.Property(e => e.BaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseName");

                entity.Property(e => e.CheckSumm).HasColumnName("checkSumm");

                entity.Property(e => e.Codedb).HasColumnName("CODEDB");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsLkactive).HasColumnName("isLKActive");

                entity.Property(e => e.IsSaveRecalcForIndications).HasColumnName("isSaveRecalcForIndications");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Srvnum).HasColumnName("srvnum");

                entity.Property(e => e.SrvnumKapRem).HasColumnName("srvnumKapRem");

                entity.Property(e => e.SystemType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("systemType");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<ОплатаМибапрельРицульяновск>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ОплатаМИБАпрельРИЦУльяновск");

                entity.Property(e => e.Датаплатежа).HasColumnType("datetime");

                entity.Property(e => e.Номерзаказа).HasMaxLength(255);

                entity.Property(e => e.Пп).HasColumnName("пп");
            });

            modelBuilder.Entity<СборыМибУлЭнергоОктябрь>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("сборыМибУлЭнергоОктябрь");

                entity.Property(e => e.DatePay)
                    .HasColumnType("datetime")
                    .HasColumnName("DatePAy");

                entity.Property(e => e.Descripshion)
                    .HasMaxLength(255)
                    .HasColumnName("descripshion");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Pp).HasColumnName("pp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
