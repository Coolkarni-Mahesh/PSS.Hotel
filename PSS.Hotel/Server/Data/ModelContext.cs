using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PSS.Hotel.Shared.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdiscountDetail> AdiscountDetails { get; set; }

    public virtual DbSet<AlertChequePayment> AlertChequePayments { get; set; }

    public virtual DbSet<AlertDaysDefine> AlertDaysDefines { get; set; }

    public virtual DbSet<AlertUserDefineReport> AlertUserDefineReports { get; set; }

    public virtual DbSet<BalancePaymentReport> BalancePaymentReports { get; set; }

    public virtual DbSet<BankMaster> BankMasters { get; set; }

    public virtual DbSet<BarCounterMaster> BarCounterMasters { get; set; }

    public virtual DbSet<BarIssueDetailOrg> BarIssueDetailOrgs { get; set; }

    public virtual DbSet<BillEndMessage> BillEndMessages { get; set; }

    public virtual DbSet<BillSetting> BillSettings { get; set; }

    public virtual DbSet<BillSummary> BillSummaries { get; set; }

    public virtual DbSet<BillSummary1> BillSummary1s { get; set; }

    public virtual DbSet<BillSummary2> BillSummary2s { get; set; }

    public virtual DbSet<BillSummaryWithVat> BillSummaryWithVats { get; set; }

    public virtual DbSet<BulkSmssending> BulkSmssendings { get; set; }

    public virtual DbSet<BulkSmssendingDetail> BulkSmssendingDetails { get; set; }

    public virtual DbSet<BulkSmssendingDetail1> BulkSmssendingDetail1s { get; set; }

    public virtual DbSet<CancelItemAfterBill> CancelItemAfterBills { get; set; }

    public virtual DbSet<CancelItemAfterBilling> CancelItemAfterBillings { get; set; }

    public virtual DbSet<CancelItemReport> CancelItemReports { get; set; }

    public virtual DbSet<CancelItemRpt> CancelItemRpts { get; set; }

    public virtual DbSet<CaptainPadGroup> CaptainPadGroups { get; set; }

    public virtual DbSet<CaptainWiseCommissionBoundry> CaptainWiseCommissionBoundries { get; set; }

    public virtual DbSet<CaptainWiseSale> CaptainWiseSales { get; set; }

    public virtual DbSet<CaptionOrWetterWiseGss> CaptionOrWetterWiseGsses { get; set; }

    public virtual DbSet<Casess1Report> Casess1Reports { get; set; }

    public virtual DbSet<CasessDiscountDetail> CasessDiscountDetails { get; set; }

    public virtual DbSet<CasessExpensessDetail> CasessExpensessDetails { get; set; }

    public virtual DbSet<CasessIireport> CasessIireports { get; set; }

    public virtual DbSet<CasessOtherDeposit> CasessOtherDeposits { get; set; }

    public virtual DbSet<CasessTransaction> CasessTransactions { get; set; }

    public virtual DbSet<CashCollection> CashCollections { get; set; }

    public virtual DbSet<CashDenotation> CashDenotations { get; set; }

    public virtual DbSet<CashMemoReport> CashMemoReports { get; set; }

    public virtual DbSet<CashMemoSubReport> CashMemoSubReports { get; set; }

    public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }

    public virtual DbSet<Citymaster> Citymasters { get; set; }

    public virtual DbSet<CollectionReport> CollectionReports { get; set; }

    public virtual DbSet<ComplimentaryBill> ComplimentaryBills { get; set; }

    public virtual DbSet<ComplimentaryBillWise> ComplimentaryBillWises { get; set; }

    public virtual DbSet<CounCases1Creditor> CounCases1Creditors { get; set; }

    public virtual DbSet<CounCases1CreditorD> CounCases1CreditorDs { get; set; }

    public virtual DbSet<CounCasess1> CounCasess1s { get; set; }

    public virtual DbSet<CounCasess1Depositor> CounCasess1Depositors { get; set; }

    public virtual DbSet<CounCasess1DepositorD> CounCasess1DepositorDs { get; set; }

    public virtual DbSet<CounCasess1Discount> CounCasess1Discounts { get; set; }

    public virtual DbSet<CounCasess1Expense> CounCasess1Expenses { get; set; }

    public virtual DbSet<CounCasess1ExpensesD> CounCasess1ExpensesDs { get; set; }

    public virtual DbSet<CounCasess1OtherDepositor> CounCasess1OtherDepositors { get; set; }

    public virtual DbSet<CounCasess1OwnerDeposit> CounCasess1OwnerDeposits { get; set; }

    public virtual DbSet<CounCasess2> CounCasess2s { get; set; }

    public virtual DbSet<CounCasess2Creditor> CounCasess2Creditors { get; set; }

    public virtual DbSet<CounCasess2Depositor> CounCasess2Depositors { get; set; }

    public virtual DbSet<CounCasess2Expense> CounCasess2Expenses { get; set; }

    public virtual DbSet<CounCasessIiexpensesReport> CounCasessIiexpensesReports { get; set; }

    public virtual DbSet<CounCasher1LodgeCharge> CounCasher1LodgeCharges { get; set; }

    public virtual DbSet<CounterCashierCreditorReport> CounterCashierCreditorReports { get; set; }

    public virtual DbSet<CounterCashierDepositorReport> CounterCashierDepositorReports { get; set; }

    public virtual DbSet<CounterCashierReport> CounterCashierReports { get; set; }

    public virtual DbSet<CountryMaster> CountryMasters { get; set; }

    public virtual DbSet<CreditEntry> CreditEntries { get; set; }

    public virtual DbSet<CreditMaster> CreditMasters { get; set; }

    public virtual DbSet<CreditReferenceCashMemoReport> CreditReferenceCashMemoReports { get; set; }

    public virtual DbSet<CreditorBalanceReport> CreditorBalanceReports { get; set; }

    public virtual DbSet<CreditorDetailReport> CreditorDetailReports { get; set; }

    public virtual DbSet<CurrentStock> CurrentStocks { get; set; }

    public virtual DbSet<CurrentStockAll> CurrentStockAlls { get; set; }

    public virtual DbSet<CurrentStockAllReport> CurrentStockAllReports { get; set; }

    public virtual DbSet<CurrentStockAverageRate> CurrentStockAverageRates { get; set; }

    public virtual DbSet<CurrentStockReport> CurrentStockReports { get; set; }

    public virtual DbSet<CurrentTableStock> CurrentTableStocks { get; set; }

    public virtual DbSet<CustTransactionDetail> CustTransactionDetails { get; set; }

    public virtual DbSet<CustomerBunching> CustomerBunchings { get; set; }

    public virtual DbSet<CustomerConsumeCoupanReport> CustomerConsumeCoupanReports { get; set; }

    public virtual DbSet<CustomerCoupanDepositDetail> CustomerCoupanDepositDetails { get; set; }

    public virtual DbSet<CustomerCoupanDepositReturnDetail> CustomerCoupanDepositReturnDetails { get; set; }

    public virtual DbSet<CustomerCreditReportUser> CustomerCreditReportUsers { get; set; }

    public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

    public virtual DbSet<CustomerDetailReport> CustomerDetailReports { get; set; }

    public virtual DbSet<CustomerFineCharge> CustomerFineCharges { get; set; }

    public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }

    public virtual DbSet<CustomerInformationReport> CustomerInformationReports { get; set; }

    public virtual DbSet<CustomerWiseCoupanDetail> CustomerWiseCoupanDetails { get; set; }

    public virtual DbSet<CustomerWiseCoupanDetailDateWise> CustomerWiseCoupanDetailDateWises { get; set; }

    public virtual DbSet<CutomerWisePaymentDetailMess> CutomerWisePaymentDetailMesses { get; set; }

    public virtual DbSet<DailBillNo> DailBillNos { get; set; }

    public virtual DbSet<DailyCancelKot> DailyCancelKots { get; set; }

    public virtual DbSet<DailyDeptDotno> DailyDeptDotnos { get; set; }

    public virtual DbSet<DailyKotno> DailyKotnos { get; set; }

    public virtual DbSet<DailyTable> DailyTables { get; set; }

    public virtual DbSet<DailyTableCd> DailyTableCds { get; set; }

    public virtual DbSet<DailyTableDetail> DailyTableDetails { get; set; }

    public virtual DbSet<DailyTableDetailCd> DailyTableDetailCds { get; set; }

    public virtual DbSet<DataEmailSending> DataEmailSendings { get; set; }

    public virtual DbSet<DateWiseItemPurchaseReport> DateWiseItemPurchaseReports { get; set; }

    public virtual DbSet<Datum> Data { get; set; }

    public virtual DbSet<DayCloseProcessReport> DayCloseProcessReports { get; set; }

    public virtual DbSet<DbillFood> DbillFoods { get; set; }

    public virtual DbSet<DebtorOpening> DebtorOpenings { get; set; }

    public virtual DbSet<DebtorsName> DebtorsNames { get; set; }

    public virtual DbSet<DeliverySmssending> DeliverySmssendings { get; set; }

    public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }

    public virtual DbSet<DepartmentWiseSale> DepartmentWiseSales { get; set; }

    public virtual DbSet<DepartmentWiseSalesDetail> DepartmentWiseSalesDetails { get; set; }

    public virtual DbSet<DepositorMaster> DepositorMasters { get; set; }

    public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }

    public virtual DbSet<DeviceMaster> DeviceMasters { get; set; }

    public virtual DbSet<DistrictMaster> DistrictMasters { get; set; }

    public virtual DbSet<DotseriesReportTable> DotseriesReportTables { get; set; }

    public virtual DbSet<EmailSendingDetail> EmailSendingDetails { get; set; }

    public virtual DbSet<EmailSendingFileType> EmailSendingFileTypes { get; set; }

    public virtual DbSet<EmpAdvanceReport> EmpAdvanceReports { get; set; }

    public virtual DbSet<EmployeeAttandance> EmployeeAttandances { get; set; }

    public virtual DbSet<EmployeeAttandanceReport> EmployeeAttandanceReports { get; set; }

    public virtual DbSet<EmployeeAttendenceReport> EmployeeAttendenceReports { get; set; }

    public virtual DbSet<EmployeeDeposit> EmployeeDeposits { get; set; }

    public virtual DbSet<EmployeeLedger> EmployeeLedgers { get; set; }

    public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }

    public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }

    public virtual DbSet<EmployeeWiseTableDefine> EmployeeWiseTableDefines { get; set; }

    public virtual DbSet<Example> Examples { get; set; }

    public virtual DbSet<ExciseBillPrintingBeer> ExciseBillPrintingBeers { get; set; }

    public virtual DbSet<ExciseBillPrintingSpirit> ExciseBillPrintingSpirits { get; set; }

    public virtual DbSet<ExciseBillSummaryReport> ExciseBillSummaryReports { get; set; }

    public virtual DbSet<ExciseCustomer> ExciseCustomers { get; set; }

    public virtual DbSet<ExciseDatewiseReport> ExciseDatewiseReports { get; set; }

    public virtual DbSet<ExciseFlr3> ExciseFlr3s { get; set; }

    public virtual DbSet<ExciseFlr3liquerTotal> ExciseFlr3liquerTotals { get; set; }

    public virtual DbSet<ExciseFlr4> ExciseFlr4s { get; set; }

    public virtual DbSet<ExciseFlr5> ExciseFlr5s { get; set; }

    public virtual DbSet<ExciseFlr5beerShoopy> ExciseFlr5beerShoopies { get; set; }

    public virtual DbSet<ExciseFlr5liquerTotal> ExciseFlr5liquerTotals { get; set; }

    public virtual DbSet<ExciseFlrcl23> ExciseFlrcl23s { get; set; }

    public virtual DbSet<ExciseGroup> ExciseGroups { get; set; }

    public virtual DbSet<ExciseLooseBalance> ExciseLooseBalances { get; set; }

    public virtual DbSet<ExciseLooseBalanceTemp> ExciseLooseBalanceTemps { get; set; }

    public virtual DbSet<ExciseReport> ExciseReports { get; set; }

    public virtual DbSet<ExciseSaleBillReport> ExciseSaleBillReports { get; set; }

    public virtual DbSet<ExciseSaleBillSummaryReport> ExciseSaleBillSummaryReports { get; set; }

    public virtual DbSet<ExciseSummaryReport> ExciseSummaryReports { get; set; }

    public virtual DbSet<ExciseUnitLimit> ExciseUnitLimits { get; set; }

    public virtual DbSet<ExciseUnitSetting> ExciseUnitSettings { get; set; }

    public virtual DbSet<ExciseUnitSettingFlr3> ExciseUnitSettingFlr3s { get; set; }

    public virtual DbSet<ExciseUnitSettingFlrcl23> ExciseUnitSettingFlrcl23s { get; set; }

    public virtual DbSet<ExpensesGroup> ExpensesGroups { get; set; }

    public virtual DbSet<ExpensesMaster> ExpensesMasters { get; set; }

    public virtual DbSet<ExpensesRegister> ExpensesRegisters { get; set; }

    public virtual DbSet<ExpiryBeerItemsDetailReport> ExpiryBeerItemsDetailReports { get; set; }

    public virtual DbSet<FbquestionMaster> FbquestionMasters { get; set; }

    public virtual DbSet<FbresultMaster> FbresultMasters { get; set; }

    public virtual DbSet<FeedbackResultReport> FeedbackResultReports { get; set; }

    public virtual DbSet<FinishGoodGeneration> FinishGoodGenerations { get; set; }

    public virtual DbSet<FinishGoodGenerationDetail> FinishGoodGenerationDetails { get; set; }

    public virtual DbSet<FoodAdjustment> FoodAdjustments { get; set; }

    public virtual DbSet<FoodAdjustmentTemp> FoodAdjustmentTemps { get; set; }

    public virtual DbSet<FoodBill> FoodBills { get; set; }

    public virtual DbSet<FoodBillMain> FoodBillMains { get; set; }

    public virtual DbSet<FoodBillMultipale> FoodBillMultipales { get; set; }

    public virtual DbSet<FoodBillRoundOff> FoodBillRoundOffs { get; set; }

    public virtual DbSet<FoodBillSummary1> FoodBillSummary1s { get; set; }

    public virtual DbSet<FoodBillSummary2> FoodBillSummary2s { get; set; }

    public virtual DbSet<FoodBillSummaryCreditBill> FoodBillSummaryCreditBills { get; set; }

    public virtual DbSet<FoodBillSummaryReport> FoodBillSummaryReports { get; set; }

    public virtual DbSet<FoodBillsDateWise> FoodBillsDateWises { get; set; }

    public virtual DbSet<FoodDataGrouping> FoodDataGroupings { get; set; }

    public virtual DbSet<FoodDataGroupingTemp> FoodDataGroupingTemps { get; set; }

    public virtual DbSet<FoodGstreport> FoodGstreports { get; set; }

    public virtual DbSet<FoodGstreportNew> FoodGstreportNews { get; set; }

    public virtual DbSet<FoodStockDetail> FoodStockDetails { get; set; }

    public virtual DbSet<FoodStockDetailReportBefore> FoodStockDetailReportBefores { get; set; }

    public virtual DbSet<FunctionProspectu> FunctionProspectus { get; set; }

    public virtual DbSet<FunctionProspectusDetail> FunctionProspectusDetails { get; set; }

    public virtual DbSet<FunctionProspectusDetailSub> FunctionProspectusDetailSubs { get; set; }

    public virtual DbSet<FunctionProspectusDetailSubTemp> FunctionProspectusDetailSubTemps { get; set; }

    public virtual DbSet<FunctionProspectusItemNameCombine> FunctionProspectusItemNameCombines { get; set; }

    public virtual DbSet<FunctionProspectusReport> FunctionProspectusReports { get; set; }

    public virtual DbSet<FunctionProspectusReportMgm> FunctionProspectusReportMgms { get; set; }

    public virtual DbSet<FunctionTypeMaster> FunctionTypeMasters { get; set; }

    public virtual DbSet<FydeleteTableDatum> FydeleteTableData { get; set; }

    public virtual DbSet<Fymaster> Fymasters { get; set; }

    public virtual DbSet<HallMaster> HallMasters { get; set; }

    public virtual DbSet<HotelBackupItemTitle> HotelBackupItemTitles { get; set; }

    public virtual DbSet<HotelBackupMainTitle> HotelBackupMainTitles { get; set; }

    public virtual DbSet<IssueDetail> IssueDetails { get; set; }

    public virtual DbSet<IssueToBar> IssueToBars { get; set; }

    public virtual DbSet<IssueToBarDetail> IssueToBarDetails { get; set; }

    public virtual DbSet<ItemBunching> ItemBunchings { get; set; }

    public virtual DbSet<ItemDapartmentwiseDailySale> ItemDapartmentwiseDailySales { get; set; }

    public virtual DbSet<ItemDetail> ItemDetails { get; set; }

    public virtual DbSet<ItemGroup> ItemGroups { get; set; }

    public virtual DbSet<ItemGroupWiseDailySale> ItemGroupWiseDailySales { get; set; }

    public virtual DbSet<ItemInfoReport> ItemInfoReports { get; set; }

    public virtual DbSet<ItemLiquer> ItemLiquers { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<ItemNameSplitQuery> ItemNameSplitQueries { get; set; }

    public virtual DbSet<ItemRateChangeReport> ItemRateChangeReports { get; set; }

    public virtual DbSet<ItemRateSetting> ItemRateSettings { get; set; }

    public virtual DbSet<ItemRecipe> ItemRecipes { get; set; }

    public virtual DbSet<ItemTitlel> ItemTitlels { get; set; }

    public virtual DbSet<ItemWiseConsumption> ItemWiseConsumptions { get; set; }

    public virtual DbSet<ItemWisePurchase> ItemWisePurchases { get; set; }

    public virtual DbSet<ItemWisePurchasedetail> ItemWisePurchasedetails { get; set; }

    public virtual DbSet<ItemWiseSalesDetail> ItemWiseSalesDetails { get; set; }

    public virtual DbSet<ItemWiseSalesWithMrprateReport> ItemWiseSalesWithMrprateReports { get; set; }

    public virtual DbSet<ItemWiseTransaction> ItemWiseTransactions { get; set; }

    public virtual DbSet<Itemreatedetail> Itemreatedetails { get; set; }

    public virtual DbSet<ItemwiseSalesQtyReport> ItemwiseSalesQtyReports { get; set; }

    public virtual DbSet<ItemwiseTransactionReport> ItemwiseTransactionReports { get; set; }

    public virtual DbSet<KbccancelPrinting> KbccancelPrintings { get; set; }

    public virtual DbSet<KbcduplicatePrinting> KbcduplicatePrintings { get; set; }

    public virtual DbSet<Kbcprinting> Kbcprintings { get; set; }

    public virtual DbSet<KotBotCancelItem> KotBotCancelItems { get; set; }

    public virtual DbSet<KotBotDetailReport> KotBotDetailReports { get; set; }

    public virtual DbSet<KotBotWiseBillDetailReport> KotBotWiseBillDetailReports { get; set; }

    public virtual DbSet<KotBotdatum> KotBotdata { get; set; }

    public virtual DbSet<KotPrinting> KotPrintings { get; set; }

    public virtual DbSet<KotbotSectionwisesaleReport> KotbotSectionwisesaleReports { get; set; }

    public virtual DbSet<KotbotseriesReportTable> KotbotseriesReportTables { get; set; }

    public virtual DbSet<KotstyleMaster> KotstyleMasters { get; set; }

    public virtual DbSet<LiquerCosting> LiquerCostings { get; set; }

    public virtual DbSet<LiquorGroupWiseSale> LiquorGroupWiseSales { get; set; }

    public virtual DbSet<LiquorType> LiquorTypes { get; set; }

    public virtual DbSet<LodgingBillDetail> LodgingBillDetails { get; set; }

    public virtual DbSet<LooseLiquorSetting> LooseLiquorSettings { get; set; }

    public virtual DbSet<MainTitle> MainTitles { get; set; }

    public virtual DbSet<MasterExportDate> MasterExportDates { get; set; }

    public virtual DbSet<MaxCustomerBillNo> MaxCustomerBillNos { get; set; }

    public virtual DbSet<MenuTaste> MenuTastes { get; set; }

    public virtual DbSet<MenuTypeMaster> MenuTypeMasters { get; set; }

    public virtual DbSet<MessageMaster> MessageMasters { get; set; }

    public virtual DbSet<MonthWiseStockValuation> MonthWiseStockValuations { get; set; }

    public virtual DbSet<MonthlyFoodBillSummary> MonthlyFoodBillSummaries { get; set; }

    public virtual DbSet<MsummeryReport> MsummeryReports { get; set; }

    public virtual DbSet<OnlineExUnitWiseSalesAndPurchase> OnlineExUnitWiseSalesAndPurchases { get; set; }

    public virtual DbSet<OpeningStockDetail> OpeningStockDetails { get; set; }

    public virtual DbSet<OpeningStockFormatReport> OpeningStockFormatReports { get; set; }

    public virtual DbSet<OpeningStockMaster> OpeningStockMasters { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OtherDepositDetail> OtherDepositDetails { get; set; }

    public virtual DbSet<OwnerDepositDetail> OwnerDepositDetails { get; set; }

    public virtual DbSet<PasteError> PasteErrors { get; set; }

    public virtual DbSet<PhysicalLiuorSetting> PhysicalLiuorSettings { get; set; }

    public virtual DbSet<PortMaster> PortMasters { get; set; }

    public virtual DbSet<PresentyDefine> PresentyDefines { get; set; }

    public virtual DbSet<PrintingSetting> PrintingSettings { get; set; }

    public virtual DbSet<PurchaseBill> PurchaseBills { get; set; }

    public virtual DbSet<PurchaseBilldetail> PurchaseBilldetails { get; set; }

    public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }

    public virtual DbSet<PurchaseLedgerReport> PurchaseLedgerReports { get; set; }

    public virtual DbSet<PurchaseOutstanding> PurchaseOutstandings { get; set; }

    public virtual DbSet<PurchasePayment> PurchasePayments { get; set; }

    public virtual DbSet<PurchasePaymentReturndetail> PurchasePaymentReturndetails { get; set; }

    public virtual DbSet<PurchaseReturn> PurchaseReturns { get; set; }

    public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }

    public virtual DbSet<Qrimage> Qrimages { get; set; }

    public virtual DbSet<RawItemConvert> RawItemConverts { get; set; }

    public virtual DbSet<RawItemConvertDetailReport> RawItemConvertDetailReports { get; set; }

    public virtual DbSet<RawItemConvertTemp> RawItemConvertTemps { get; set; }

    public virtual DbSet<RawItemIssuedetail> RawItemIssuedetails { get; set; }

    public virtual DbSet<RawItemReturn> RawItemReturns { get; set; }

    public virtual DbSet<RawItemReturnDetail> RawItemReturnDetails { get; set; }

    public virtual DbSet<RawItemissue> RawItemissues { get; set; }

    public virtual DbSet<Rawitem> Rawitems { get; set; }

    public virtual DbSet<RawitemDetail> RawitemDetails { get; set; }

    public virtual DbSet<RconsumptionRecipeWise> RconsumptionRecipeWises { get; set; }

    public virtual DbSet<RconsumptionRecipeWise1> RconsumptionRecipeWise1s { get; set; }

    public virtual DbSet<RefferenceTransactionDetail> RefferenceTransactionDetails { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<ReportAlignmentMaster> ReportAlignmentMasters { get; set; }

    public virtual DbSet<ReportPrinterSetMaster> ReportPrinterSetMasters { get; set; }

    public virtual DbSet<ReturnFromBar> ReturnFromBars { get; set; }

    public virtual DbSet<ReturnFromBarDetail> ReturnFromBarDetails { get; set; }

    public virtual DbSet<RoundOffQuery> RoundOffQueries { get; set; }

    public virtual DbSet<SalaryAdvance> SalaryAdvances { get; set; }

    public virtual DbSet<SalaryAdvanceReport> SalaryAdvanceReports { get; set; }

    public virtual DbSet<SalaryAdvanceSummary> SalaryAdvanceSummaries { get; set; }

    public virtual DbSet<SalaryPayment> SalaryPayments { get; set; }

    public virtual DbSet<SalarySheet> SalarySheets { get; set; }

    public virtual DbSet<SalarySheetReport> SalarySheetReports { get; set; }

    public virtual DbSet<SaleBill1CancelKot> SaleBill1CancelKots { get; set; }

    public virtual DbSet<SaleBillDailyCancelKot> SaleBillDailyCancelKots { get; set; }

    public virtual DbSet<SalesBil1Gstdetail> SalesBil1Gstdetails { get; set; }

    public virtual DbSet<SalesBilGstdetail> SalesBilGstdetails { get; set; }

    public virtual DbSet<SalesBill> SalesBills { get; set; }

    public virtual DbSet<SalesBill1> SalesBill1s { get; set; }

    public virtual DbSet<SalesBill1Modify> SalesBill1Modifies { get; set; }

    public virtual DbSet<SalesBillDaily> SalesBillDailies { get; set; }

    public virtual DbSet<SalesBillDailyGstdetail> SalesBillDailyGstdetails { get; set; }

    public virtual DbSet<SalesBillDailyModify> SalesBillDailyModifies { get; set; }

    public virtual DbSet<SalesBillDetail> SalesBillDetails { get; set; }

    public virtual DbSet<SalesBillDetailDaily> SalesBillDetailDailies { get; set; }

    public virtual DbSet<SalesBillDetailDailyModify> SalesBillDetailDailyModifies { get; set; }

    public virtual DbSet<SalesBillDetailTemp> SalesBillDetailTemps { get; set; }

    public virtual DbSet<SalesBillNoteDefine> SalesBillNoteDefines { get; set; }

    public virtual DbSet<SalesBillPrint> SalesBillPrints { get; set; }

    public virtual DbSet<SalesBillPrintReport> SalesBillPrintReports { get; set; }

    public virtual DbSet<SalesBillTemp> SalesBillTemps { get; set; }

    public virtual DbSet<SalesDaily> SalesDailies { get; set; }

    public virtual DbSet<SalesDiscount> SalesDiscounts { get; set; }

    public virtual DbSet<SalesItemSummeryReport> SalesItemSummeryReports { get; set; }

    public virtual DbSet<Salesbilldetail1> Salesbilldetail1s { get; set; }

    public virtual DbSet<Salesbilldetail1Modify> Salesbilldetail1Modifies { get; set; }

    public virtual DbSet<SectionMaster> SectionMasters { get; set; }

    public virtual DbSet<SectionWiseBillSummary> SectionWiseBillSummaries { get; set; }

    public virtual DbSet<SectionWiseSale> SectionWiseSales { get; set; }

    public virtual DbSet<SectionWiseServiceCharge> SectionWiseServiceCharges { get; set; }

    public virtual DbSet<SessionMaster> SessionMasters { get; set; }

    public virtual DbSet<SessionWiseTodaysSalesReport> SessionWiseTodaysSalesReports { get; set; }

    public virtual DbSet<ShiftDefineDetail> ShiftDefineDetails { get; set; }

    public virtual DbSet<ShiftDefineMaster> ShiftDefineMasters { get; set; }

    public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }

    public virtual DbSet<ShortcutNameMaster> ShortcutNameMasters { get; set; }

    public virtual DbSet<Smsapisetting> Smsapisettings { get; set; }

    public virtual DbSet<SmsmessageMaster> SmsmessageMasters { get; set; }

    public virtual DbSet<SmssendingDetail> SmssendingDetails { get; set; }

    public virtual DbSet<SnacksRateDiscountDefine> SnacksRateDiscountDefines { get; set; }

    public virtual DbSet<SoftwareRegistration> SoftwareRegistrations { get; set; }

    public virtual DbSet<SoftwareSetting> SoftwareSettings { get; set; }

    public virtual DbSet<SoftwareSettingCd> SoftwareSettingCds { get; set; }

    public virtual DbSet<SpecialDishGroupMaster> SpecialDishGroupMasters { get; set; }

    public virtual DbSet<SpecialDishItemMaster> SpecialDishItemMasters { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<StockConsumption> StockConsumptions { get; set; }

    public virtual DbSet<StockConsumptionDetail> StockConsumptionDetails { get; set; }

    public virtual DbSet<StockConsumptionReport> StockConsumptionReports { get; set; }

    public virtual DbSet<StockDeletedDate> StockDeletedDates { get; set; }

    public virtual DbSet<StockDetail> StockDetails { get; set; }

    public virtual DbSet<StockStatusBar> StockStatusBars { get; set; }

    public virtual DbSet<StockStatusStore> StockStatusStores { get; set; }

    public virtual DbSet<StockVarifactionLooseReport> StockVarifactionLooseReports { get; set; }

    public virtual DbSet<StockVarifactionReport> StockVarifactionReports { get; set; }

    public virtual DbSet<SubTitle> SubTitles { get; set; }

    public virtual DbSet<SubgroupMaster> SubgroupMasters { get; set; }

    public virtual DbSet<SupplierPaymentDetail> SupplierPaymentDetails { get; set; }

    public virtual DbSet<Supplierinfo> Supplierinfos { get; set; }

    public virtual DbSet<TableMaster> TableMasters { get; set; }

    public virtual DbSet<TableName> TableNames { get; set; }

    public virtual DbSet<TableRotaion> TableRotaions { get; set; }

    public virtual DbSet<TableSummaryReport> TableSummaryReports { get; set; }

    public virtual DbSet<TasteMaster> TasteMasters { get; set; }

    public virtual DbSet<TaxTable> TaxTables { get; set; }

    public virtual DbSet<TempBulkInLitterWithMrp> TempBulkInLitterWithMrps { get; set; }

    public virtual DbSet<TempBulkInLtr> TempBulkInLtrs { get; set; }

    public virtual DbSet<TempConsumeCoupanDetail> TempConsumeCoupanDetails { get; set; }

    public virtual DbSet<TempCreditorDetailYc> TempCreditorDetailYcs { get; set; }

    public virtual DbSet<TempCurrentStockAverageRate> TempCurrentStockAverageRates { get; set; }

    public virtual DbSet<TempCustomerConsumeCoupan> TempCustomerConsumeCoupans { get; set; }

    public virtual DbSet<TempCustomerInfo> TempCustomerInfos { get; set; }

    public virtual DbSet<TempDataTablesQuery> TempDataTablesQueries { get; set; }

    public virtual DbSet<TempDeptWiseCounterCashier> TempDeptWiseCounterCashiers { get; set; }

    public virtual DbSet<TempEmpAdvanceBal> TempEmpAdvanceBals { get; set; }

    public virtual DbSet<TempExpensesAndPurPaymentDetail> TempExpensesAndPurPaymentDetails { get; set; }

    public virtual DbSet<TempExportOpening> TempExportOpenings { get; set; }

    public virtual DbSet<TempFoodStockDetail> TempFoodStockDetails { get; set; }

    public virtual DbSet<TempFoodStockSettingReport> TempFoodStockSettingReports { get; set; }

    public virtual DbSet<TempGrossProfit> TempGrossProfits { get; set; }

    public virtual DbSet<TempGstdetail> TempGstdetails { get; set; }

    public virtual DbSet<TempGstrate> TempGstrates { get; set; }

    public virtual DbSet<TempIssueToBarDetail> TempIssueToBarDetails { get; set; }

    public virtual DbSet<TempItemDetail> TempItemDetails { get; set; }

    public virtual DbSet<TempItemDetailRaw> TempItemDetailRaws { get; set; }

    public virtual DbSet<TempItemGroupWiseDailySale> TempItemGroupWiseDailySales { get; set; }

    public virtual DbSet<TempItemMaster> TempItemMasters { get; set; }

    public virtual DbSet<TempItemRateDefine> TempItemRateDefines { get; set; }

    public virtual DbSet<TempItemWiseSalesWithMrprate> TempItemWiseSalesWithMrprates { get; set; }

    public virtual DbSet<TempItemwiseTransReport> TempItemwiseTransReports { get; set; }

    public virtual DbSet<TempLiquorItemStockLedgerReport> TempLiquorItemStockLedgerReports { get; set; }

    public virtual DbSet<TempMonthlyStockValuation> TempMonthlyStockValuations { get; set; }

    public virtual DbSet<TempOnlineExUnitWiseOpening> TempOnlineExUnitWiseOpenings { get; set; }

    public virtual DbSet<TempOpeningStockDetail> TempOpeningStockDetails { get; set; }

    public virtual DbSet<TempPresentyDefine> TempPresentyDefines { get; set; }

    public virtual DbSet<TempPresentyDownload> TempPresentyDownloads { get; set; }

    public virtual DbSet<TempPresentyDownloadDatum> TempPresentyDownloadData { get; set; }

    public virtual DbSet<TempPurchaseRate> TempPurchaseRates { get; set; }

    public virtual DbSet<TempRawItem> TempRawItems { get; set; }

    public virtual DbSet<TempRawItemConsumption> TempRawItemConsumptions { get; set; }

    public virtual DbSet<TempSalesBill> TempSalesBills { get; set; }

    public virtual DbSet<TempSb> TempSbs { get; set; }

    public virtual DbSet<TempSbdetail> TempSbdetails { get; set; }

    public virtual DbSet<TempSessionWiseTodaySale> TempSessionWiseTodaySales { get; set; }

    public virtual DbSet<TempStockConsumption> TempStockConsumptions { get; set; }

    public virtual DbSet<TempStockConsumptionDetail> TempStockConsumptionDetails { get; set; }

    public virtual DbSet<TempStockConsumptionReport> TempStockConsumptionReports { get; set; }

    public virtual DbSet<TempStockStatus> TempStockStatuses { get; set; }

    public virtual DbSet<TempStockVarifaction> TempStockVarifactions { get; set; }

    public virtual DbSet<TempStockVarifactionLoose> TempStockVarifactionLooses { get; set; }

    public virtual DbSet<TempTableRoom> TempTableRooms { get; set; }

    public virtual DbSet<TempTodaysProdCost> TempTodaysProdCosts { get; set; }

    public virtual DbSet<TempcounCasess1MonthlyReport> TempcounCasess1MonthlyReports { get; set; }

    public virtual DbSet<TempmissingKotBot> TempmissingKotBots { get; set; }

    public virtual DbSet<Tmpclp140231> Tmpclp140231s { get; set; }

    public virtual DbSet<Tmpclp376191> Tmpclp376191s { get; set; }

    public virtual DbSet<TodayDiscount> TodayDiscounts { get; set; }

    public virtual DbSet<TodaySDiscountDetail> TodaySDiscountDetails { get; set; }

    public virtual DbSet<TodaySale> TodaySales { get; set; }

    public virtual DbSet<TodaySalesItemWiseCaptain> TodaySalesItemWiseCaptains { get; set; }

    public virtual DbSet<TodaySalesItemWiseCaptainReport> TodaySalesItemWiseCaptainReports { get; set; }

    public virtual DbSet<TodaySalesReport> TodaySalesReports { get; set; }

    public virtual DbSet<TodaySalesReportTemp> TodaySalesReportTemps { get; set; }

    public virtual DbSet<TodaysParcelDeliveryReport> TodaysParcelDeliveryReports { get; set; }

    public virtual DbSet<TotalLiquorConsumption> TotalLiquorConsumptions { get; set; }

    public virtual DbSet<TouchScreenMainGroupMaster> TouchScreenMainGroupMasters { get; set; }

    public virtual DbSet<TouchScreenSubGroupMaster> TouchScreenSubGroupMasters { get; set; }

    public virtual DbSet<Transactiondate> Transactiondates { get; set; }

    public virtual DbSet<UnitMaster> UnitMasters { get; set; }

    public virtual DbSet<UnitWiseSale> UnitWiseSales { get; set; }

    public virtual DbSet<UpdationFlag> UpdationFlags { get; set; }

    public virtual DbSet<UserDefineAlert> UserDefineAlerts { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<UserMaster> UserMasters { get; set; }

    public virtual DbSet<UserWiseBillDetail> UserWiseBillDetails { get; set; }

    public virtual DbSet<Wastage> Wastages { get; set; }

    public virtual DbSet<Wastagedetail> Wastagedetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdiscountDetail>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("ADiscountDetail");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Billamt).HasDefaultValueSql("0");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<AlertChequePayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlertChequePayment");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.SupplierName).HasMaxLength(120);
        });

        modelBuilder.Entity<AlertDaysDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlertDaysDefine");

            entity.HasIndex(e => e.BeerExpDays, "NoOfDays");

            entity.HasIndex(e => e.NoOfDays, "Unitcode");

            entity.Property(e => e.BeerExpDays).HasDefaultValueSql("0");
            entity.Property(e => e.NoOfDays).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<AlertUserDefineReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AlertUserDefineReport");

            entity.Property(e => e.AlertSubject).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<BalancePaymentReport>(entity =>
        {
            entity.HasKey(e => e.SupplierCode).HasName("PrimaryKey");

            entity.ToTable("BalancePaymentReport");

            entity.HasIndex(e => e.SupplierCode, "Suppliercode");

            entity.Property(e => e.SupplierCode).HasDefaultValueSql("0");
            entity.Property(e => e.BalancePayment).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<BankMaster>(entity =>
        {
            entity.HasKey(e => e.BankCode).HasName("PrimaryKey");

            entity.ToTable("BankMaster");

            entity.HasIndex(e => e.Citycode, "Citycode");

            entity.HasIndex(e => e.BankCode, "Customercode");

            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(120);
            entity.Property(e => e.Citycode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag)
                .HasMaxLength(1)
                .HasColumnName("deleteflag");
            entity.Property(e => e.Phone).HasMaxLength(120);
        });

        modelBuilder.Entity<BarCounterMaster>(entity =>
        {
            entity.HasKey(e => e.BarCounterId).HasName("PrimaryKey");

            entity.ToTable("BarCounterMaster");

            entity.HasIndex(e => e.BarCounterId, "Itemgroupcode");

            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.BarCounterName).HasMaxLength(120);
            entity.Property(e => e.BarPrinterName).HasMaxLength(120);
            entity.Property(e => e.CounterPrinterName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.KitchenPrinterName).HasMaxLength(120);
            entity.Property(e => e.SalesBillPrinterName).HasMaxLength(120);
        });

        modelBuilder.Entity<BarIssueDetailOrg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BarIssueDetail ORG");

            entity.Property(e => e.BarCounterId).HasColumnName("BarCounterID");
            entity.Property(e => e.BarCounterName).HasMaxLength(120);
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.IssueId).HasColumnName("IssueID");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<BillEndMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillEndMessage");

            entity.HasIndex(e => e.TableEndFlag, "CaptainCode");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.TableEndFlag).HasMaxLength(1);
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
        });

        modelBuilder.Entity<BillSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillSetting");

            entity.HasIndex(e => e.Subgroupcode, "Subgroupcode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Subgroupcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<BillSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillSummary");

            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.FoodDiscount).HasMaxLength(255);
            entity.Property(e => e.Holdno)
                .HasDefaultValueSql("0")
                .HasColumnName("holdno");
            entity.Property(e => e.LiquareDiscount).HasMaxLength(255);
            entity.Property(e => e.LiquerBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.ServiceChargeAmt).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceTaxAmt).HasDefaultValueSql("0");
            entity.Property(e => e.TableNo).HasMaxLength(50);
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.VatAmount)
                .HasDefaultValueSql("0")
                .HasColumnName("vatAmount");
        });

        modelBuilder.Entity<BillSummary1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BillSummary1");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<BillSummary2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillSummary2");

            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno)
                .HasDefaultValueSql("0")
                .HasColumnName("holdno");
            entity.Property(e => e.LiquerBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerBillNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<BillSummaryWithVat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillSummaryWithVat");

            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.Fdiscount)
                .HasDefaultValueSql("0")
                .HasColumnName("FDiscount");
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.FtaxationAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FTaxationAmt");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno)
                .HasDefaultValueSql("0")
                .HasColumnName("holdno");
            entity.Property(e => e.Ldiscount)
                .HasDefaultValueSql("0")
                .HasColumnName("LDiscount");
            entity.Property(e => e.LiquerBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.LtaxationAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LTaxationAmt");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.OtherDiscount).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<BulkSmssending>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BulkSMSSending");

            entity.HasIndex(e => e.SmsmessageCode, "SMSMessageCode");

            entity.HasIndex(e => e.Tid, "TID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Remark).HasMaxLength(110);
            entity.Property(e => e.SmsmessageCode)
                .HasDefaultValueSql("0")
                .HasColumnName("SMSMessageCode");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<BulkSmssendingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BulkSMSSendingDetail");

            entity.HasIndex(e => e.CustomerCode, "PatientCode");

            entity.HasIndex(e => e.Tid, "TID");

            entity.Property(e => e.CustomerCode).HasDefaultValueSql("0");
            entity.Property(e => e.MobileNo).HasMaxLength(120);
            entity.Property(e => e.SendingStatus).HasMaxLength(1);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<BulkSmssendingDetail1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BulkSMSSendingDetail1");

            entity.HasIndex(e => e.CustomerCode, "PatientCode");

            entity.HasIndex(e => e.Tid, "TID");

            entity.Property(e => e.CustomerCode).HasDefaultValueSql("0");
            entity.Property(e => e.MobileNo).HasMaxLength(120);
            entity.Property(e => e.SendingStatus).HasMaxLength(1);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<CancelItemAfterBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CancelItemAfterBill");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Reason).HasMaxLength(120);
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CancelItemAfterBilling>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CancelItemAfterBilling");

            entity.HasIndex(e => e.Icode, "Icode");

            entity.HasIndex(e => e.Ucode, "Ucode");

            entity.Property(e => e.BillNo).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CancelItem).HasDefaultValueSql("0");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Icode).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Reason).HasMaxLength(120);
            entity.Property(e => e.SalesRate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Ucode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CancelItemReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CancelItemReport");

            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CancelItemRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CancelItemRpt");

            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CaptainPadGroup>(entity =>
        {
            entity.HasKey(e => e.CpgroupCode).HasName("PrimaryKey");

            entity.ToTable("CaptainPadGroup");

            entity.HasIndex(e => e.CpgroupCode, "Itemgroupcode");

            entity.Property(e => e.CpgroupCode)
                .HasDefaultValueSql("0")
                .HasColumnName("CPGroupCode");
            entity.Property(e => e.CpgroupName)
                .HasMaxLength(120)
                .HasColumnName("CPGroupName");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
        });

        modelBuilder.Entity<CaptainWiseCommissionBoundry>(entity =>
        {
            entity.HasKey(e => e.EmpCode).HasName("PrimaryKey");

            entity.HasIndex(e => e.EmpCode, "EmpCode");

            entity.Property(e => e.EmpCode).ValueGeneratedNever();
            entity.Property(e => e.EmpName).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CaptainWiseSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CaptainWiseSales");

            entity.Property(e => e.AliasName).HasMaxLength(120);
            entity.Property(e => e.Bamt).HasColumnName("BAmt");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CaptionOrWetterWiseGss>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CaptionOrWetterWiseGSS");

            entity.Property(e => e.BillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.EmpType).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<Casess1Report>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Casess1Report");

            entity.Property(e => e.DepositName).HasMaxLength(120);
            entity.Property(e => e.Softdrink).HasColumnName("softdrink");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CasessDiscountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CasessDiscountDetail");

            entity.Property(e => e.Billtype)
                .HasMaxLength(120)
                .HasColumnName("billtype");
            entity.Property(e => e.Custname)
                .HasMaxLength(120)
                .HasColumnName("custname");
            entity.Property(e => e.Customercode).HasColumnName("customercode");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Reason).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CasessExpensessDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CasessExpensessDetail");

            entity.Property(e => e.EgroupName).HasMaxLength(120);
            entity.Property(e => e.Expenses).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemDescription).HasMaxLength(255);
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CasessIireport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CasessIIReport");

            entity.Property(e => e.Orcash).HasColumnName("ORCash");
            entity.Property(e => e.Orcheque).HasColumnName("ORCheque");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CasessOtherDeposit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CasessOtherDeposit");

            entity.Property(e => e.DepositorId).HasColumnName("DepositorID");
            entity.Property(e => e.DepositorName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CasessTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CasessTransaction");

            entity.HasIndex(e => e.CasessTransactionid, "CasessTransactionid");

            entity.Property(e => e.CasessTransactionid).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CashCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CashCollection");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TrDate).HasMaxLength(50);
        });

        modelBuilder.Entity<CashDenotation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CashDenotation");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Note).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CashMemoReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CashMemoReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Cityname).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CashMemoSubReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CashMemoSubReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LserviceCharge).HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt).HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax).HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt).HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CategoryCode).HasName("PrimaryKey");

            entity.ToTable("CategoryMaster");

            entity.HasIndex(e => e.CategoryCode, "Itemgroupcode");

            entity.Property(e => e.CategoryCode).HasDefaultValueSql("0");
            entity.Property(e => e.CategoryName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
        });

        modelBuilder.Entity<Citymaster>(entity =>
        {
            entity.HasKey(e => e.Citycode).HasName("PrimaryKey");

            entity.ToTable("Citymaster");

            entity.HasIndex(e => e.Citycode, "Citycode");

            entity.HasIndex(e => e.DistrictCode, "Statecode");

            entity.Property(e => e.Citycode).HasDefaultValueSql("0");
            entity.Property(e => e.Cityname).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.DistrictCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CollectionReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollectionReport");

            entity.Property(e => e.ChequeNo).HasMaxLength(120);
            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.PaidAmount).HasDefaultValueSql("0");
            entity.Property(e => e.PaidType).HasMaxLength(120);
            entity.Property(e => e.Pdate).HasColumnName("PDate");
        });

        modelBuilder.Entity<ComplimentaryBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComplimentaryBill");

            entity.HasIndex(e => e.Tid, "TID");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.ComplimentaryType).HasMaxLength(120);
            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.PbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("PBillNo");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ComplimentaryBillWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComplimentaryBillWise");

            entity.HasIndex(e => e.Tid, "TID");

            entity.Property(e => e.ComplimentaryType).HasMaxLength(120);
            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.PbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("PBillNo");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<CounCases1Creditor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCases1Creditor");

            entity.HasIndex(e => e.BillId, "BillID");

            entity.HasIndex(e => e.CreditId, "CreditID");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.HasIndex(e => e.LodgeTransactionId, "LodgeTransactionID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.BillId)
                .HasMaxLength(120)
                .HasColumnName("BillID");
            entity.Property(e => e.CaredNo).HasMaxLength(120);
            entity.Property(e => e.CreditId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditID");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.LodgeTransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("LodgeTransactionID");
            entity.Property(e => e.Lodging).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCases1CreditorD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCases1CreditorD");

            entity.HasIndex(e => e.BillId, "BillID");

            entity.HasIndex(e => e.CreditId, "CreditID");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.LodgeTransactionId, "LodgeTransactionID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.BillId)
                .HasMaxLength(120)
                .HasColumnName("BillID");
            entity.Property(e => e.CaredNo).HasMaxLength(120);
            entity.Property(e => e.CreditId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditID");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.LodgeTransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("LodgeTransactionID");
            entity.Property(e => e.Lodging).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounCasess1>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("counCasess1");

            entity.HasIndex(e => e.BankCode, "BankCode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Bar).HasDefaultValueSql("0");
            entity.Property(e => e.Beer).HasDefaultValueSql("0");
            entity.Property(e => e.Cigarette).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.DepositAmt).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCash).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCheque).HasDefaultValueSql("0");
            entity.Property(e => e.DepositName).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Expenses).HasDefaultValueSql("0");
            entity.Property(e => e.Food).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.OtherDeposit).HasDefaultValueSql("0");
            entity.Property(e => e.PurchasePayment).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceCharge).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceTax).HasDefaultValueSql("0");
            entity.Property(e => e.Softdrink)
                .HasDefaultValueSql("0")
                .HasColumnName("softdrink");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Vat).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounCasess1Depositor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1Depositor");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess1DepositorD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1DepositorD");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess1Discount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1Discount");

            entity.HasIndex(e => e.BillNo, "ExpenID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.Customercode, "customercode");

            entity.Property(e => e.BillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Billtype)
                .HasMaxLength(120)
                .HasColumnName("billtype");
            entity.Property(e => e.Custname)
                .HasMaxLength(120)
                .HasColumnName("custname");
            entity.Property(e => e.Customercode).HasColumnName("customercode");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Reason).HasMaxLength(120);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess1Expense>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ExpensesId, "ExpenID");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ExpensesId)
                .HasDefaultValueSql("0")
                .HasColumnName("ExpensesID");
            entity.Property(e => e.Free).HasDefaultValueSql("0");
            entity.Property(e => e.ItemDescription).HasMaxLength(255);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounCasess1ExpensesD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1ExpensesD");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.ExpensesId, "ExpenID");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ExpensesId)
                .HasDefaultValueSql("0")
                .HasColumnName("ExpensesID");
            entity.Property(e => e.Free).HasDefaultValueSql("0");
            entity.Property(e => e.ItemDescription).HasMaxLength(255);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounCasess1OtherDepositor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1OtherDepositor");

            entity.HasIndex(e => e.DepositorId, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.DepositorId)
                .HasDefaultValueSql("0")
                .HasColumnName("DepositorID");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess1OwnerDeposit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess1OwnerDeposit");

            entity.HasIndex(e => e.DepositorId, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.DepositorId)
                .HasDefaultValueSql("0")
                .HasColumnName("DepositorID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess2>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("CounCasess2");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.CreditSales).HasDefaultValueSql("0");
            entity.Property(e => e.Food).HasDefaultValueSql("0");
            entity.Property(e => e.Liquer).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.Orcash)
                .HasDefaultValueSql("0")
                .HasColumnName("ORCash");
            entity.Property(e => e.Orcheque)
                .HasDefaultValueSql("0")
                .HasColumnName("ORCheque");
            entity.Property(e => e.PettyExpenses).HasDefaultValueSql("0");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CounCasess2Creditor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("counCasess2Creditor");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess2Depositor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CounCasess2Depositor");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CounCasess2Expense>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ExpensesId, "ExpenID");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ExpensesId)
                .HasDefaultValueSql("0")
                .HasColumnName("ExpensesID");
            entity.Property(e => e.Free).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounCasessIiexpensesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CounCasessIIExpensesReport");

            entity.Property(e => e.Expenses).HasMaxLength(120);
            entity.Property(e => e.ExpensesId).HasColumnName("ExpensesID");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CounCasher1LodgeCharge>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("CounCasher1LodgeCharge");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.BobCard).HasDefaultValueSql("0");
            entity.Property(e => e.HouseGuest).HasDefaultValueSql("0");
            entity.Property(e => e.HouseKeeping).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CounterCashierCreditorReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CounterCashierCreditorReport");

            entity.Property(e => e.Amt).HasColumnName("amt");
            entity.Property(e => e.BillId)
                .HasMaxLength(120)
                .HasColumnName("BillID");
            entity.Property(e => e.CreditName).HasMaxLength(120);
            entity.Property(e => e.Lodgin).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CounterCashierDepositorReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CounterCashierDepositorReport");

            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CounterCashierReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CounterCashierReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CountryMaster>(entity =>
        {
            entity.HasKey(e => e.CountryCode).HasName("PrimaryKey");

            entity.ToTable("CountryMaster");

            entity.HasIndex(e => e.CountryCode, "Citycode");

            entity.Property(e => e.CountryCode).HasDefaultValueSql("0");
            entity.Property(e => e.CountryName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
        });

        modelBuilder.Entity<CreditEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CreditEntry");

            entity.HasIndex(e => e.SupplierCode, "SupplierCode");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.DeletionAllow).HasMaxLength(1);
            entity.Property(e => e.ReferenceNo).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SupplierCode).HasDefaultValueSql("0");
            entity.Property(e => e.Transcod).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CreditMaster>(entity =>
        {
            entity.HasKey(e => e.CreditId).HasName("PrimaryKey");

            entity.ToTable("CreditMaster");

            entity.HasIndex(e => e.CreditId, "CreditID");

            entity.Property(e => e.CreditId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditID");
            entity.Property(e => e.CreditName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
        });

        modelBuilder.Entity<CreditReferenceCashMemoReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CreditReferenceCashMemoReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.DirectSbillNo).HasColumnName("DirectSBillNo");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CreditorBalanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CreditorBalanceReport");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.CreditorName).HasMaxLength(120);
            entity.Property(e => e.MobileNo).HasMaxLength(120);
        });

        modelBuilder.Entity<CreditorDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CreditorDetailReport");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.CreditorName).HasMaxLength(120);
            entity.Property(e => e.MobileNo).HasMaxLength(120);
        });

        modelBuilder.Entity<CurrentStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrentStock");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Bar2Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Bar3Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Bar4Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CurrentStockAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrentStockAll");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Bar2Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Bar3Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Bar4Qty).HasDefaultValueSql("0");
            entity.Property(e => e.BarQty).HasDefaultValueSql("0");
            entity.Property(e => e.Prate)
                .HasDefaultValueSql("0")
                .HasColumnName("PRate");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srate)
                .HasDefaultValueSql("0")
                .HasColumnName("SRate");
            entity.Property(e => e.StoreQty).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CurrentStockAllReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CurrentStockAllReport");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Prate).HasColumnName("PRate");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Srate).HasColumnName("SRate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CurrentStockAverageRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CurrentStockAverageRate");

            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
        });

        modelBuilder.Entity<CurrentStockReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CurrentStockReport");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CurrentTableStock>(entity =>
        {
            entity.HasKey(e => new { e.RawitemId, e.Unitcode }).HasName("PrimaryKey");

            entity.ToTable("CurrentTableStock");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CustTransactionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustTransactionDetail");

            entity.HasIndex(e => e.CustName, "Customercode");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SrNo).HasMaxLength(120);
            entity.Property(e => e.TransactionNo).HasDefaultValueSql("0");
            entity.Property(e => e.Type).HasMaxLength(120);
        });

        modelBuilder.Entity<CustomerBunching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerBunching");

            entity.HasIndex(e => e.SubCustcode, "SubItemcode");

            entity.HasIndex(e => e.Transactionid, "Transactionid");

            entity.HasIndex(e => e.UseCustcode, "UseItemcode");

            entity.Property(e => e.SubCustcode).HasDefaultValueSql("0");
            entity.Property(e => e.Transactionid).HasDefaultValueSql("0");
            entity.Property(e => e.UseCustcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CustomerConsumeCoupanReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerConsumeCoupanReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CustomerCoupanDepositDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerCoupanDepositDetail");

            entity.HasIndex(e => e.ValidDays, "AdjustQty");

            entity.HasIndex(e => e.AdjustQty, "AdvanceQty");

            entity.HasIndex(e => e.CoupanNo, "CoupanID");

            entity.HasIndex(e => e.CoupanQty, "CoupanNo");

            entity.HasIndex(e => e.AdvanceQty, "CoupanQty");

            entity.HasIndex(e => e.CoupanAllow, "CoupanUsed");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.CoupanId, "TransactionID1");

            entity.HasIndex(e => e.Remark, "ValidDays");

            entity.HasIndex(e => e.CoupanUsed, "ValidDays1");

            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.MainSrno).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CustomerCoupanDepositReturnDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerCoupanDepositReturnDetail");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<CustomerCreditReportUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerCreditReportUser");

            entity.Property(e => e.BillId)
                .HasMaxLength(120)
                .HasColumnName("BillID");
            entity.Property(e => e.CreditName).HasMaxLength(120);
            entity.Property(e => e.CustomerType).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CustomerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerDetail");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.BillType).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CustomerDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerDetailReport");

            entity.Property(e => e.Amt).HasColumnName("amt");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<CustomerFineCharge>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.FineCharges, "NoOfDays");

            entity.Property(e => e.FineCharges).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CustomerInfo>(entity =>
        {
            entity.HasKey(e => e.Customercode).HasName("PrimaryKey");

            entity.ToTable("CustomerInfo");

            entity.HasIndex(e => e.Citycode, "Citycode");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.UseCustcode, "UseCustcode");

            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.Citycode).HasDefaultValueSql("0");
            entity.Property(e => e.CustomerType).HasMaxLength(1);
            entity.Property(e => e.Deleteflag)
                .HasMaxLength(1)
                .HasColumnName("deleteflag");
            entity.Property(e => e.DiscountFood).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountLiquer).HasDefaultValueSql("0");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.FavouriteDish).HasMaxLength(120);
            entity.Property(e => e.Fax).HasMaxLength(120);
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Lodgin).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PaymentMode).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.Photpath).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SaleQtyInMl).HasDefaultValueSql("0");
            entity.Property(e => e.UseCustcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<CustomerInformationReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerInformationReport");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Cityname).HasMaxLength(120);
            entity.Property(e => e.CustomerType).HasMaxLength(1);
            entity.Property(e => e.Deleteflag)
                .HasMaxLength(1)
                .HasColumnName("deleteflag");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.FavouriteDish).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Phone).HasMaxLength(120);
        });

        modelBuilder.Entity<CustomerWiseCoupanDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerWiseCoupanDetail");

            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.CoupanId).HasColumnName("CoupanID");
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CustomerWiseCoupanDetailDateWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerWiseCoupanDetailDateWise");

            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.CoupanId).HasColumnName("CoupanID");
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<CutomerWisePaymentDetailMess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CutomerWisePaymentDetailMess");

            entity.Property(e => e.CashType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<DailBillNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailBillNo");

            entity.Property(e => e.BillNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyCancelKot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyCancelKot");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.CancelKotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode)
                .HasDefaultValueSql("0")
                .HasColumnName("itemcode");
            entity.Property(e => e.Printflag).HasMaxLength(1);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.Tableno)
                .HasDefaultValueSql("0")
                .HasColumnName("tableno");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyDeptDotno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyDeptDOTNo");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.Property(e => e.CancelNo).HasDefaultValueSql("0");
            entity.Property(e => e.Departmentcode).HasDefaultValueSql("0");
            entity.Property(e => e.DotNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyKotno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyKOTNo");

            entity.Property(e => e.BotNo).HasDefaultValueSql("0");
            entity.Property(e => e.CancelNo).HasDefaultValueSql("0");
            entity.Property(e => e.CotNo).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyTable");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.HasIndex(e => e.WetterCode, "WetterCode");

            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.WetterCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyTableCd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyTableCD");

            entity.HasIndex(e => e.Empno, "CaptainCode");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Pax).HasDefaultValueSql("0");
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
        });

        modelBuilder.Entity<DailyTableDetail>(entity =>
        {

            entity.HasKey(e => e.DailyTableDetailId).HasName("PrimaryKey");

            entity.ToTable("DailyTableDetail");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.DailyTableDetailId)
                .HasColumnType("counter")
                .HasColumnName("DailyTableDetailID");
            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Cooking).HasDefaultValueSql("0");
            entity.Property(e => e.Delivered).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pending).HasDefaultValueSql("0");
            entity.Property(e => e.Rate)
                .HasDefaultValueSql("0")
                .HasColumnName("rate");
            entity.Property(e => e.Ready).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.Stockded).HasMaxLength(1);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");

         //   entity.HasOne(d => d.itemMaster).WithMany(p => p.DailyTableDetails).HasForeignKey(d => d.Itemcode);





















            //entity
            //    .HasNoKey()
            //    .ToTable("DailyTableDetail");

            //entity.HasIndex(e => e.Itemcode, "Itemcode");

            //entity.HasIndex(e => e.Unitcode, "Unitcode");

            //entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            //entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            //entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            //entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            //entity.Property(e => e.Kotbot)
            //    .HasMaxLength(120)
            //    .HasColumnName("kotbot");
            //entity.Property(e => e.Kotmsg)
            //    .HasMaxLength(255)
            //    .HasColumnName("KOTMsg");
            //entity.Property(e => e.Order).HasDefaultValueSql("0");
            //entity.Property(e => e.Rate)
            //    .HasDefaultValueSql("0")
            //    .HasColumnName("rate");
            //entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            //entity.Property(e => e.Srno)
            //    .HasDefaultValueSql("0")
            //    .HasColumnName("srno");
            //entity.Property(e => e.StartTime).HasMaxLength(120);
            //entity.Property(e => e.Stockded).HasMaxLength(1);
            //entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            //entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DailyTableDetailCd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DailyTableDetailCD");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Rate)
                .HasDefaultValueSql("0")
                .HasColumnName("rate");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
            entity.Property(e => e.TasteName)
                .HasMaxLength(120)
                .HasDefaultValueSql("\"N/A\"");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DataEmailSending>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dataEmailSending");

            entity.HasIndex(e => e.FromEmailId, "FromEmailID");

            entity.HasIndex(e => e.ToEmailId, "ToEmailID");

            entity.Property(e => e.FromEmailId)
                .HasMaxLength(120)
                .HasColumnName("FromEmailID");
            entity.Property(e => e.FromPassword).HasMaxLength(120);
            entity.Property(e => e.Smptserver)
                .HasMaxLength(120)
                .HasColumnName("SMPTServer");
            entity.Property(e => e.StateFlag).HasMaxLength(120);
            entity.Property(e => e.ToEmailId)
                .HasMaxLength(120)
                .HasColumnName("ToEmailID");
        });

        modelBuilder.Entity<DateWiseItemPurchaseReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DateWiseItemPurchaseReport");

            entity.Property(e => e.Amt1).HasDefaultValueSql("0");
            entity.Property(e => e.Amt10).HasDefaultValueSql("0");
            entity.Property(e => e.Amt11).HasDefaultValueSql("0");
            entity.Property(e => e.Amt12).HasDefaultValueSql("0");
            entity.Property(e => e.Amt13).HasDefaultValueSql("0");
            entity.Property(e => e.Amt14).HasDefaultValueSql("0");
            entity.Property(e => e.Amt15).HasDefaultValueSql("0");
            entity.Property(e => e.Amt16).HasDefaultValueSql("0");
            entity.Property(e => e.Amt2).HasDefaultValueSql("0");
            entity.Property(e => e.Amt3).HasDefaultValueSql("0");
            entity.Property(e => e.Amt4).HasDefaultValueSql("0");
            entity.Property(e => e.Amt5).HasDefaultValueSql("0");
            entity.Property(e => e.Amt6).HasDefaultValueSql("0");
            entity.Property(e => e.Amt7).HasDefaultValueSql("0");
            entity.Property(e => e.Amt8).HasDefaultValueSql("0");
            entity.Property(e => e.Amt9).HasDefaultValueSql("0");
            entity.Property(e => e.Qty1).HasDefaultValueSql("0");
            entity.Property(e => e.Qty10).HasDefaultValueSql("0");
            entity.Property(e => e.Qty11).HasDefaultValueSql("0");
            entity.Property(e => e.Qty12).HasDefaultValueSql("0");
            entity.Property(e => e.Qty13).HasDefaultValueSql("0");
            entity.Property(e => e.Qty14).HasDefaultValueSql("0");
            entity.Property(e => e.Qty15).HasDefaultValueSql("0");
            entity.Property(e => e.Qty16).HasDefaultValueSql("0");
            entity.Property(e => e.Qty2).HasDefaultValueSql("0");
            entity.Property(e => e.Qty3).HasDefaultValueSql("0");
            entity.Property(e => e.Qty4).HasDefaultValueSql("0");
            entity.Property(e => e.Qty5).HasDefaultValueSql("0");
            entity.Property(e => e.Qty6).HasDefaultValueSql("0");
            entity.Property(e => e.Qty7).HasDefaultValueSql("0");
            entity.Property(e => e.Qty8).HasDefaultValueSql("0");
            entity.Property(e => e.Qty9).HasDefaultValueSql("0");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.TotalAmt).HasDefaultValueSql("0");
            entity.Property(e => e.TotalQty).HasDefaultValueSql("0");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<Datum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("data");

            entity.HasIndex(e => e.LodgeId, "LodgeID");

            entity.HasIndex(e => e.OrgCodeForSms, "OrgCodeForSMS");

            entity.Property(e => e.Add1).HasMaxLength(255);
            entity.Property(e => e.Add2).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(120);
            entity.Property(e => e.CounterCashierPrinterName).HasMaxLength(120);
            entity.Property(e => e.ExciseExportFileName).HasMaxLength(255);
            entity.Property(e => e.ExciseExportFilePath).HasMaxLength(255);
            entity.Property(e => e.ExciseOrgname)
                .HasMaxLength(255)
                .HasColumnName("ExciseORGName");
            entity.Property(e => e.FoodLicNo).HasMaxLength(120);
            entity.Property(e => e.FoodVatNo).HasMaxLength(120);
            entity.Property(e => e.LicenceNo).HasMaxLength(120);
            entity.Property(e => e.LodgeDatabaseName).HasMaxLength(120);
            entity.Property(e => e.LodgeId)
                .HasMaxLength(4)
                .HasColumnName("LodgeID");
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .HasColumnName("name");
            entity.Property(e => e.OrgCodeForSms).HasColumnName("OrgCodeForSMS");
            entity.Property(e => e.Orgname)
                .HasMaxLength(120)
                .HasColumnName("orgname");
            entity.Property(e => e.PhoneNo).HasMaxLength(120);
            entity.Property(e => e.Prefix)
                .HasMaxLength(255)
                .HasColumnName("prefix");
            entity.Property(e => e.QrpathSetForCaptainTab)
                .HasMaxLength(255)
                .HasColumnName("QRPathSetForCaptainTab");
            entity.Property(e => e.SendBillSmsurl)
                .HasMaxLength(255)
                .HasColumnName("SendBillSMSURL");
            entity.Property(e => e.ServiceTaxNo).HasMaxLength(255);
            entity.Property(e => e.SubName).HasMaxLength(120);
            entity.Property(e => e.Vat).HasMaxLength(120);
        });

        modelBuilder.Entity<DayCloseProcessReport>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PrimaryKey");

            entity.ToTable("DayCloseProcessReport");

            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.Action).HasMaxLength(255);
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.Particular).HasMaxLength(255);
            entity.Property(e => e.Print).HasMaxLength(10);
            entity.Property(e => e.ReportType).HasMaxLength(255);
            entity.Property(e => e.SoftwareSettings).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(10);
        });

        modelBuilder.Entity<DbillFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DbillFood");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.DbillNo).HasColumnName("DBillNo");
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Orderqty).HasColumnName("orderqty");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<DebtorOpening>(entity =>
        {
            entity.HasKey(e => e.Transcod).HasName("PrimaryKey");

            entity.ToTable("DebtorOpening");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.CustomerCode, "SupplierCode");

            entity.Property(e => e.Transcod).HasDefaultValueSql("0");
            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CustomerCode).HasDefaultValueSql("0");
            entity.Property(e => e.DeletionAllow).HasMaxLength(1);
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<DebtorsName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DebtorsName");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.CreditorId)
                .HasDefaultValueSql("0")
                .HasColumnName("CreditorID");
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<DeliverySmssending>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("DeliverySMSSending");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.MobileNo).HasMaxLength(120);
            entity.Property(e => e.SendingStatus).HasMaxLength(1);
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DepartmentMaster>(entity =>
        {
            entity.HasKey(e => e.Departmentcode).HasName("PrimaryKey");

            entity.ToTable("DepartmentMaster");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.Property(e => e.Departmentcode).HasDefaultValueSql("0");
            entity.Property(e => e.CounterPrinterName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.PrinterName).HasMaxLength(120);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
        });

        modelBuilder.Entity<DepartmentWiseSale>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PrimaryKey");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Tdate, "IDate");

            entity.HasIndex(e => e.Tid, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
            entity.Property(e => e.Departmentcode).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<DepartmentWiseSalesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DepartmentWiseSalesDetail");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Tid, "Pbillcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<DepositorMaster>(entity =>
        {
            entity.HasKey(e => e.DepositorId).HasName("PrimaryKey");

            entity.ToTable("DepositorMaster");

            entity.HasIndex(e => e.DepositorId, "Citycode");

            entity.HasIndex(e => e.Note, "Statecode");

            entity.Property(e => e.DepositorId)
                .HasDefaultValueSql("0")
                .HasColumnName("DepositorID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.DepositorName).HasMaxLength(120);
            entity.Property(e => e.Note).HasMaxLength(120);
        });

        modelBuilder.Entity<DesignationMaster>(entity =>
        {
            entity.HasKey(e => e.DesignationCode).HasName("PrimaryKey");

            entity.ToTable("DesignationMaster");

            entity.HasIndex(e => e.DesignationCode, "DesignationCode");

            entity.HasIndex(e => e.Hodcode, "hodcode");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.DesignationCode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Designation).HasMaxLength(120);
            entity.Property(e => e.Hodcode)
                .HasDefaultValueSql("0")
                .HasColumnName("hodcode");
            entity.Property(e => e.Usercode)
                .HasDefaultValueSql("0")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<DeviceMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeviceMaster");

            entity.HasIndex(e => e.DeviceId, "DeviceID");

            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceName).HasMaxLength(120);
            entity.Property(e => e.UpdateFlag).HasMaxLength(1);
        });

        modelBuilder.Entity<DistrictMaster>(entity =>
        {
            entity.HasKey(e => e.DistrictCode).HasName("PrimaryKey");

            entity.ToTable("DistrictMaster");

            entity.HasIndex(e => e.DistrictCode, "DistrictCode");

            entity.HasIndex(e => e.Statecode, "Statecode");

            entity.Property(e => e.DistrictCode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.District).HasMaxLength(120);
            entity.Property(e => e.Statecode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<DotseriesReportTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DOTSeriesReportTable");

            entity.HasIndex(e => e.Tid, "PBillcode");

            entity.Property(e => e.Dotno)
                .HasMaxLength(120)
                .HasColumnName("DOTNo");
            entity.Property(e => e.ItemDepartment).HasMaxLength(120);
            entity.Property(e => e.SalesBillNo).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<EmailSendingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmailSendingDetail");

            entity.Property(e => e.FileName).HasMaxLength(120);
            entity.Property(e => e.Ftype)
                .HasMaxLength(120)
                .HasColumnName("FType");
            entity.Property(e => e.GroupType).HasMaxLength(255);
            entity.Property(e => e.SendFlag).HasMaxLength(1);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<EmailSendingFileType>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PrimaryKey");

            entity.ToTable("EmailSendingFileType");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.FileType).HasMaxLength(120);
        });

        modelBuilder.Entity<EmpAdvanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmpAdvanceReport");

            entity.Property(e => e.Empname)
                .HasMaxLength(255)
                .HasColumnName("empname");
            entity.Property(e => e.IssuedBy).HasMaxLength(120);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<EmployeeAttandance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeAttandance");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Attandance).HasDefaultValueSql("0");
            entity.Property(e => e.EmpNo).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<EmployeeAttandanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmployeeAttandanceReport");

            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<EmployeeAttendenceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeAttendenceReport");

            entity.Property(e => e.EmpName).HasMaxLength(120);
            entity.Property(e => e.EmpNo).HasDefaultValueSql("0");
            entity.Property(e => e.Total).HasDefaultValueSql("0");
            entity.Property(e => e._1)
                .HasDefaultValueSql("0")
                .HasColumnName("1");
            entity.Property(e => e._10)
                .HasDefaultValueSql("0")
                .HasColumnName("10");
            entity.Property(e => e._11)
                .HasDefaultValueSql("0")
                .HasColumnName("11");
            entity.Property(e => e._12)
                .HasDefaultValueSql("0")
                .HasColumnName("12");
            entity.Property(e => e._13)
                .HasDefaultValueSql("0")
                .HasColumnName("13");
            entity.Property(e => e._14)
                .HasDefaultValueSql("0")
                .HasColumnName("14");
            entity.Property(e => e._15)
                .HasDefaultValueSql("0")
                .HasColumnName("15");
            entity.Property(e => e._16)
                .HasDefaultValueSql("0")
                .HasColumnName("16");
            entity.Property(e => e._17)
                .HasDefaultValueSql("0")
                .HasColumnName("17");
            entity.Property(e => e._18)
                .HasDefaultValueSql("0")
                .HasColumnName("18");
            entity.Property(e => e._19)
                .HasDefaultValueSql("0")
                .HasColumnName("19");
            entity.Property(e => e._2)
                .HasDefaultValueSql("0")
                .HasColumnName("2");
            entity.Property(e => e._20)
                .HasDefaultValueSql("0")
                .HasColumnName("20");
            entity.Property(e => e._21)
                .HasDefaultValueSql("0")
                .HasColumnName("21");
            entity.Property(e => e._22)
                .HasDefaultValueSql("0")
                .HasColumnName("22");
            entity.Property(e => e._23)
                .HasDefaultValueSql("0")
                .HasColumnName("23");
            entity.Property(e => e._24)
                .HasDefaultValueSql("0")
                .HasColumnName("24");
            entity.Property(e => e._25)
                .HasDefaultValueSql("0")
                .HasColumnName("25");
            entity.Property(e => e._26)
                .HasDefaultValueSql("0")
                .HasColumnName("26");
            entity.Property(e => e._27)
                .HasDefaultValueSql("0")
                .HasColumnName("27");
            entity.Property(e => e._28)
                .HasDefaultValueSql("0")
                .HasColumnName("28");
            entity.Property(e => e._29)
                .HasDefaultValueSql("0")
                .HasColumnName("29");
            entity.Property(e => e._3)
                .HasDefaultValueSql("0")
                .HasColumnName("3");
            entity.Property(e => e._30)
                .HasDefaultValueSql("0")
                .HasColumnName("30");
            entity.Property(e => e._31)
                .HasDefaultValueSql("0")
                .HasColumnName("31");
            entity.Property(e => e._4)
                .HasDefaultValueSql("0")
                .HasColumnName("4");
            entity.Property(e => e._5)
                .HasDefaultValueSql("0")
                .HasColumnName("5");
            entity.Property(e => e._6)
                .HasDefaultValueSql("0")
                .HasColumnName("6");
            entity.Property(e => e._7)
                .HasDefaultValueSql("0")
                .HasColumnName("7");
            entity.Property(e => e._8)
                .HasDefaultValueSql("0")
                .HasColumnName("8");
            entity.Property(e => e._9)
                .HasDefaultValueSql("0")
                .HasColumnName("9");
        });

        modelBuilder.Entity<EmployeeDeposit>(entity =>
        {
            entity.HasKey(e => e.DepositId).HasName("PrimaryKey");

            entity.ToTable("EmployeeDeposit");

            entity.HasIndex(e => e.DepositId, "TransactionID");

            entity.Property(e => e.DepositId)
                .HasDefaultValueSql("0")
                .HasColumnName("DepositID");
            entity.Property(e => e.Ddate).HasColumnName("DDate");
            entity.Property(e => e.DepositAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
        });

        modelBuilder.Entity<EmployeeLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeLedger");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransType).HasMaxLength(120);
        });

        modelBuilder.Entity<EmployeeMaster>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PrimaryKey");

            entity.ToTable("EmployeeMaster");

            entity.HasIndex(e => e.EmpId, "EmpID");

            entity.HasIndex(e => e.Prcitycode, "Prcitycode");

            entity.HasIndex(e => e.Designationcode, "designationcode");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.AdminFlag).HasMaxLength(1);
            entity.Property(e => e.AliasName).HasMaxLength(120);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Designationcode)
                .HasDefaultValueSql("0")
                .HasColumnName("designationcode");
            entity.Property(e => e.Dol).HasColumnName("DOL");
            entity.Property(e => e.EmpId)
                .HasMaxLength(120)
                .HasColumnName("EmpID");
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.GrossSalary).HasDefaultValueSql("0");
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Pradd).HasMaxLength(255);
            entity.Property(e => e.Prcitycode).HasDefaultValueSql("0");
            entity.Property(e => e.Prphoneno).HasMaxLength(120);
            entity.Property(e => e.Qualification).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Salary).HasDefaultValueSql("0");
            entity.Property(e => e.TabDataAllow).HasMaxLength(1);
        });

        modelBuilder.Entity<EmployeeSalary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeSalary");

            entity.Property(e => e.Basic).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Epf)
                .HasDefaultValueSql("0")
                .HasColumnName("epf");
            entity.Property(e => e.Esic)
                .HasDefaultValueSql("0")
                .HasColumnName("esic");
            entity.Property(e => e.GrossSalary).HasMaxLength(120);
            entity.Property(e => e.Hra)
                .HasDefaultValueSql("0")
                .HasColumnName("hra");
            entity.Property(e => e.Salary).HasDefaultValueSql("0");
            entity.Property(e => e.Ta).HasDefaultValueSql("0");
            entity.Property(e => e.WashingAllow).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<EmployeeWiseTableDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeWiseTableDefine");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.TableId).HasColumnName("TableID");
        });

        modelBuilder.Entity<Example>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("example");

            entity.Property(e => e.Bamt).HasColumnName("BAmt");
            entity.Property(e => e.BillType).HasMaxLength(120);
        });

        modelBuilder.Entity<ExciseBillPrintingBeer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseBillPrintingBeer");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseBillPrintingSpirit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseBillPrintingSpirit");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseBillSummaryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseBillSummaryReport");

            entity.Property(e => e.ExciseType).HasMaxLength(50);
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("0")
                .HasColumnName("MRP");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<ExciseCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseCustomer");

            entity.Property(e => e.CustmerSequence).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseDatewiseReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseDatewiseReport");

            entity.Property(e => e.FoodAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<ExciseFlr3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLR3");

            entity.HasIndex(e => e.ItemName, "Pbillcode");

            entity.Property(e => e.C1).HasDefaultValueSql("0");
            entity.Property(e => e.C2).HasDefaultValueSql("0");
            entity.Property(e => e.C3).HasDefaultValueSql("0");
            entity.Property(e => e.C4).HasDefaultValueSql("0");
            entity.Property(e => e.C5).HasDefaultValueSql("0");
            entity.Property(e => e.C6).HasDefaultValueSql("0");
            entity.Property(e => e.C7).HasDefaultValueSql("0");
            entity.Property(e => e.C8).HasDefaultValueSql("0");
            entity.Property(e => e.C9).HasDefaultValueSql("0");
            entity.Property(e => e.I1).HasDefaultValueSql("0");
            entity.Property(e => e.I2).HasDefaultValueSql("0");
            entity.Property(e => e.I3).HasDefaultValueSql("0");
            entity.Property(e => e.I4).HasDefaultValueSql("0");
            entity.Property(e => e.I5).HasDefaultValueSql("0");
            entity.Property(e => e.I6).HasDefaultValueSql("0");
            entity.Property(e => e.I7).HasDefaultValueSql("0");
            entity.Property(e => e.I8).HasDefaultValueSql("0");
            entity.Property(e => e.I9).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LiquorName).HasMaxLength(120);
            entity.Property(e => e.O1).HasDefaultValueSql("0");
            entity.Property(e => e.O2).HasDefaultValueSql("0");
            entity.Property(e => e.O3).HasDefaultValueSql("0");
            entity.Property(e => e.O4).HasDefaultValueSql("0");
            entity.Property(e => e.O5).HasDefaultValueSql("0");
            entity.Property(e => e.O6).HasDefaultValueSql("0");
            entity.Property(e => e.O7).HasDefaultValueSql("0");
            entity.Property(e => e.O8).HasDefaultValueSql("0");
            entity.Property(e => e.O9).HasDefaultValueSql("0");
            entity.Property(e => e.R1).HasDefaultValueSql("0");
            entity.Property(e => e.R2).HasDefaultValueSql("0");
            entity.Property(e => e.R3).HasDefaultValueSql("0");
            entity.Property(e => e.R4).HasDefaultValueSql("0");
            entity.Property(e => e.R5).HasDefaultValueSql("0");
            entity.Property(e => e.R6).HasDefaultValueSql("0");
            entity.Property(e => e.R7).HasDefaultValueSql("0");
            entity.Property(e => e.R8).HasDefaultValueSql("0");
            entity.Property(e => e.R9).HasDefaultValueSql("0");
            entity.Property(e => e.Tpno)
                .HasMaxLength(120)
                .HasColumnName("TPNo");
        });

        modelBuilder.Entity<ExciseFlr3liquerTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLR3LiquerTotal");

            entity.Property(e => e.C1).HasDefaultValueSql("0");
            entity.Property(e => e.C2).HasDefaultValueSql("0");
            entity.Property(e => e.C3).HasDefaultValueSql("0");
            entity.Property(e => e.C4).HasDefaultValueSql("0");
            entity.Property(e => e.C5).HasDefaultValueSql("0");
            entity.Property(e => e.C6).HasDefaultValueSql("0");
            entity.Property(e => e.C7).HasDefaultValueSql("0");
            entity.Property(e => e.C8).HasDefaultValueSql("0");
            entity.Property(e => e.C9).HasDefaultValueSql("0");
            entity.Property(e => e.I1).HasDefaultValueSql("0");
            entity.Property(e => e.I2).HasDefaultValueSql("0");
            entity.Property(e => e.I3).HasDefaultValueSql("0");
            entity.Property(e => e.I4).HasDefaultValueSql("0");
            entity.Property(e => e.I5).HasDefaultValueSql("0");
            entity.Property(e => e.I6).HasDefaultValueSql("0");
            entity.Property(e => e.I7).HasDefaultValueSql("0");
            entity.Property(e => e.I8).HasDefaultValueSql("0");
            entity.Property(e => e.I9).HasDefaultValueSql("0");
            entity.Property(e => e.LiquorName).HasMaxLength(120);
            entity.Property(e => e.O1).HasDefaultValueSql("0");
            entity.Property(e => e.O2).HasDefaultValueSql("0");
            entity.Property(e => e.O3).HasDefaultValueSql("0");
            entity.Property(e => e.O4).HasDefaultValueSql("0");
            entity.Property(e => e.O5).HasDefaultValueSql("0");
            entity.Property(e => e.O6).HasDefaultValueSql("0");
            entity.Property(e => e.O7).HasDefaultValueSql("0");
            entity.Property(e => e.O8).HasDefaultValueSql("0");
            entity.Property(e => e.O9).HasDefaultValueSql("0");
            entity.Property(e => e.R1).HasDefaultValueSql("0");
            entity.Property(e => e.R2).HasDefaultValueSql("0");
            entity.Property(e => e.R3).HasDefaultValueSql("0");
            entity.Property(e => e.R4).HasDefaultValueSql("0");
            entity.Property(e => e.R5).HasDefaultValueSql("0");
            entity.Property(e => e.R6).HasDefaultValueSql("0");
            entity.Property(e => e.R7).HasDefaultValueSql("0");
            entity.Property(e => e.R8).HasDefaultValueSql("0");
            entity.Property(e => e.R9).HasDefaultValueSql("0");
            entity.Property(e => e.Tpno)
                .HasMaxLength(120)
                .HasColumnName("TPNo");
        });

        modelBuilder.Entity<ExciseFlr4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLR4");

            entity.HasIndex(e => e.GroupId, "GroupID");

            entity.Property(e => e.GroupId)
                .HasDefaultValueSql("0")
                .HasColumnName("GroupID");
            entity.Property(e => e.Oa1)
                .HasDefaultValueSql("0")
                .HasColumnName("OA1");
            entity.Property(e => e.Oa2)
                .HasDefaultValueSql("0")
                .HasColumnName("OA2");
            entity.Property(e => e.Oa3)
                .HasDefaultValueSql("0")
                .HasColumnName("OA3");
            entity.Property(e => e.Oa4)
                .HasDefaultValueSql("0")
                .HasColumnName("OA4");
            entity.Property(e => e.Oa5)
                .HasDefaultValueSql("0")
                .HasColumnName("OA5");
            entity.Property(e => e.Oa6)
                .HasDefaultValueSql("0")
                .HasColumnName("OA6");
            entity.Property(e => e.Oa7)
                .HasDefaultValueSql("0")
                .HasColumnName("OA7");
            entity.Property(e => e.Ob1)
                .HasDefaultValueSql("0")
                .HasColumnName("OB1");
            entity.Property(e => e.Ob2)
                .HasDefaultValueSql("0")
                .HasColumnName("OB2");
            entity.Property(e => e.Ob3)
                .HasDefaultValueSql("0")
                .HasColumnName("OB3");
            entity.Property(e => e.Oc1)
                .HasDefaultValueSql("0")
                .HasColumnName("OC1");
            entity.Property(e => e.Oc2)
                .HasDefaultValueSql("0")
                .HasColumnName("OC2");
            entity.Property(e => e.Oc3)
                .HasDefaultValueSql("0")
                .HasColumnName("OC3");
            entity.Property(e => e.Oc4)
                .HasDefaultValueSql("0")
                .HasColumnName("OC4");
            entity.Property(e => e.Od1)
                .HasDefaultValueSql("0")
                .HasColumnName("OD1");
            entity.Property(e => e.Od2)
                .HasDefaultValueSql("0")
                .HasColumnName("OD2");
            entity.Property(e => e.Od3)
                .HasDefaultValueSql("0")
                .HasColumnName("OD3");
            entity.Property(e => e.Oe1)
                .HasDefaultValueSql("0")
                .HasColumnName("OE1");
            entity.Property(e => e.Oe2)
                .HasDefaultValueSql("0")
                .HasColumnName("OE2");
            entity.Property(e => e.Oe3)
                .HasDefaultValueSql("0")
                .HasColumnName("OE3");
            entity.Property(e => e.Row).HasDefaultValueSql("0");
            entity.Property(e => e.Title).HasMaxLength(120);
        });

        modelBuilder.Entity<ExciseFlr5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLR5");

            entity.HasIndex(e => e.ExpDate, "Customercode");

            entity.HasIndex(e => e.CustmerName, "Pbillcode");

            entity.Property(e => e.Cashmemo)
                .HasDefaultValueSql("0")
                .HasColumnName("CASHMEMO");
            entity.Property(e => e.CustmerName).HasMaxLength(120);
            entity.Property(e => e.Ga1)
                .HasDefaultValueSql("0")
                .HasColumnName("GA1");
            entity.Property(e => e.Ga2)
                .HasDefaultValueSql("0")
                .HasColumnName("GA2");
            entity.Property(e => e.Ga3)
                .HasDefaultValueSql("0")
                .HasColumnName("GA3");
            entity.Property(e => e.Ga4)
                .HasDefaultValueSql("0")
                .HasColumnName("GA4");
            entity.Property(e => e.Ga5)
                .HasDefaultValueSql("0")
                .HasColumnName("GA5");
            entity.Property(e => e.Ga6)
                .HasDefaultValueSql("0")
                .HasColumnName("GA6");
            entity.Property(e => e.Ga7)
                .HasDefaultValueSql("0")
                .HasColumnName("GA7");
            entity.Property(e => e.Gb1)
                .HasDefaultValueSql("0")
                .HasColumnName("GB1");
            entity.Property(e => e.Gb2)
                .HasDefaultValueSql("0")
                .HasColumnName("GB2");
            entity.Property(e => e.Gb3)
                .HasDefaultValueSql("0")
                .HasColumnName("GB3");
            entity.Property(e => e.Gc1)
                .HasDefaultValueSql("0")
                .HasColumnName("GC1");
            entity.Property(e => e.Gc2)
                .HasDefaultValueSql("0")
                .HasColumnName("GC2");
            entity.Property(e => e.Gc3)
                .HasDefaultValueSql("0")
                .HasColumnName("GC3");
            entity.Property(e => e.Gc4)
                .HasDefaultValueSql("0")
                .HasColumnName("GC4");
            entity.Property(e => e.Gd1)
                .HasDefaultValueSql("0")
                .HasColumnName("GD1");
            entity.Property(e => e.Gd2)
                .HasDefaultValueSql("0")
                .HasColumnName("GD2");
            entity.Property(e => e.Gd3)
                .HasDefaultValueSql("0")
                .HasColumnName("GD3");
            entity.Property(e => e.Ge1)
                .HasDefaultValueSql("0")
                .HasColumnName("GE1");
            entity.Property(e => e.Ge2)
                .HasDefaultValueSql("0")
                .HasColumnName("GE2");
            entity.Property(e => e.Ge3)
                .HasDefaultValueSql("0")
                .HasColumnName("GE3");
            entity.Property(e => e.Lno)
                .HasMaxLength(120)
                .HasColumnName("LNo");
            entity.Property(e => e.Place).HasMaxLength(120);
        });

        modelBuilder.Entity<ExciseFlr5beerShoopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ExciseFLR5BeerShoopy");

            entity.Property(e => e.Cashmemo).HasColumnName("CASHMEMO");
            entity.Property(e => e.CustmerName).HasMaxLength(120);
            entity.Property(e => e.Gc1).HasColumnName("GC1");
            entity.Property(e => e.Gc2).HasColumnName("GC2");
            entity.Property(e => e.Gc3).HasColumnName("GC3");
            entity.Property(e => e.Gc4).HasColumnName("GC4");
            entity.Property(e => e.Gd1).HasColumnName("GD1");
            entity.Property(e => e.Gd2).HasColumnName("GD2");
            entity.Property(e => e.Gd3).HasColumnName("GD3");
            entity.Property(e => e.Ge1).HasColumnName("GE1");
            entity.Property(e => e.Ge2).HasColumnName("GE2");
            entity.Property(e => e.Ge3).HasColumnName("GE3");
            entity.Property(e => e.Lno)
                .HasMaxLength(120)
                .HasColumnName("LNo");
            entity.Property(e => e.Place).HasMaxLength(120);
        });

        modelBuilder.Entity<ExciseFlr5liquerTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLR5LiquerTotal");

            entity.Property(e => e.Ga1)
                .HasDefaultValueSql("0")
                .HasColumnName("GA1");
            entity.Property(e => e.Ga2)
                .HasDefaultValueSql("0")
                .HasColumnName("GA2");
            entity.Property(e => e.Ga3)
                .HasDefaultValueSql("0")
                .HasColumnName("GA3");
            entity.Property(e => e.Ga4)
                .HasDefaultValueSql("0")
                .HasColumnName("GA4");
            entity.Property(e => e.Ga5)
                .HasDefaultValueSql("0")
                .HasColumnName("GA5");
            entity.Property(e => e.Ga6)
                .HasDefaultValueSql("0")
                .HasColumnName("GA6");
            entity.Property(e => e.Ga7)
                .HasDefaultValueSql("0")
                .HasColumnName("GA7");
            entity.Property(e => e.Gb1)
                .HasDefaultValueSql("0")
                .HasColumnName("GB1");
            entity.Property(e => e.Gb2)
                .HasDefaultValueSql("0")
                .HasColumnName("GB2");
            entity.Property(e => e.Gb3)
                .HasDefaultValueSql("0")
                .HasColumnName("GB3");
            entity.Property(e => e.Gc1)
                .HasDefaultValueSql("0")
                .HasColumnName("GC1");
            entity.Property(e => e.Gc2)
                .HasDefaultValueSql("0")
                .HasColumnName("GC2");
            entity.Property(e => e.Gc3)
                .HasDefaultValueSql("0")
                .HasColumnName("GC3");
            entity.Property(e => e.Gc4)
                .HasDefaultValueSql("0")
                .HasColumnName("GC4");
            entity.Property(e => e.Gd1)
                .HasDefaultValueSql("0")
                .HasColumnName("GD1");
            entity.Property(e => e.Gd2)
                .HasDefaultValueSql("0")
                .HasColumnName("GD2");
            entity.Property(e => e.Gd3)
                .HasDefaultValueSql("0")
                .HasColumnName("GD3");
            entity.Property(e => e.Ge1)
                .HasDefaultValueSql("0")
                .HasColumnName("GE1");
            entity.Property(e => e.Ge2)
                .HasDefaultValueSql("0")
                .HasColumnName("GE2");
            entity.Property(e => e.Ge3)
                .HasDefaultValueSql("0")
                .HasColumnName("GE3");
        });

        modelBuilder.Entity<ExciseFlrcl23>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseFLRCL23");

            entity.Property(e => e.I1).HasDefaultValueSql("0");
            entity.Property(e => e.I2).HasDefaultValueSql("0");
            entity.Property(e => e.I3).HasDefaultValueSql("0");
            entity.Property(e => e.I4).HasDefaultValueSql("0");
            entity.Property(e => e.I5).HasDefaultValueSql("0");
            entity.Property(e => e.I6).HasDefaultValueSql("0");
            entity.Property(e => e.I7).HasDefaultValueSql("0");
            entity.Property(e => e.I8).HasDefaultValueSql("0");
            entity.Property(e => e.I9).HasDefaultValueSql("0");
            entity.Property(e => e.LiquorName).HasMaxLength(50);
            entity.Property(e => e.O1).HasDefaultValueSql("0");
            entity.Property(e => e.O2).HasDefaultValueSql("0");
            entity.Property(e => e.O3).HasDefaultValueSql("0");
            entity.Property(e => e.O4).HasDefaultValueSql("0");
            entity.Property(e => e.O5).HasDefaultValueSql("0");
            entity.Property(e => e.O6).HasDefaultValueSql("0");
            entity.Property(e => e.O7).HasDefaultValueSql("0");
            entity.Property(e => e.O8).HasDefaultValueSql("0");
            entity.Property(e => e.O9).HasDefaultValueSql("0");
            entity.Property(e => e.R1).HasDefaultValueSql("0");
            entity.Property(e => e.R2).HasDefaultValueSql("0");
            entity.Property(e => e.R3).HasDefaultValueSql("0");
            entity.Property(e => e.R4).HasDefaultValueSql("0");
            entity.Property(e => e.R5).HasDefaultValueSql("0");
            entity.Property(e => e.R6).HasDefaultValueSql("0");
            entity.Property(e => e.R7).HasDefaultValueSql("0");
            entity.Property(e => e.R8).HasDefaultValueSql("0");
            entity.Property(e => e.R9).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseGroup>(entity =>
        {
            entity.HasKey(e => e.ExciseGroupId).HasName("PrimaryKey");

            entity.ToTable("ExciseGroup");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.HasIndex(e => e.UnderId, "UnderID");

            entity.Property(e => e.ExciseGroupId).HasDefaultValueSql("0");
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.ExciseGroupName).HasMaxLength(120);
            entity.Property(e => e.UnderId).HasColumnName("UnderID");
        });

        modelBuilder.Entity<ExciseLooseBalance>(entity =>
        {
            entity.HasKey(e => new { e.RawitemId, e.Unitcode }).HasName("PrimaryKey");

            entity.ToTable("ExciseLooseBalance");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.ExciseBalanceLoose).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseLooseBalanceTemp>(entity =>
        {
            entity.HasKey(e => new { e.RawitemId, e.Unitcode }).HasName("PrimaryKey");

            entity.ToTable("ExciseLooseBalanceTemp");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.ExciseBalanceLoose).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ExciseReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LserviceCharge).HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt).HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax).HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt).HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ExciseSaleBillReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseSaleBillReport");

            entity.HasIndex(e => e.ExpDate, "Customercode");

            entity.HasIndex(e => e.CustmerName, "Pbillcode");

            entity.Property(e => e.AmtBeer).HasDefaultValueSql("0");
            entity.Property(e => e.AmtSpirit).HasDefaultValueSql("0");
            entity.Property(e => e.B1).HasMaxLength(120);
            entity.Property(e => e.B2).HasMaxLength(120);
            entity.Property(e => e.B3).HasMaxLength(120);
            entity.Property(e => e.B4).HasMaxLength(120);
            entity.Property(e => e.B5).HasMaxLength(120);
            entity.Property(e => e.B6).HasMaxLength(120);
            entity.Property(e => e.B7).HasMaxLength(120);
            entity.Property(e => e.Cashmemo)
                .HasDefaultValueSql("0")
                .HasColumnName("CASHMEMO");
            entity.Property(e => e.CustmerName).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Lno)
                .HasMaxLength(120)
                .HasColumnName("LNo");
            entity.Property(e => e.Place).HasMaxLength(120);
            entity.Property(e => e.S1).HasMaxLength(120);
            entity.Property(e => e.S2).HasMaxLength(120);
            entity.Property(e => e.S3).HasMaxLength(120);
            entity.Property(e => e.S4).HasMaxLength(120);
            entity.Property(e => e.S5).HasMaxLength(120);
            entity.Property(e => e.S6).HasMaxLength(120);
            entity.Property(e => e.S7).HasMaxLength(120);
            entity.Property(e => e.Sdate).HasColumnName("SDate");
        });

        modelBuilder.Entity<ExciseSaleBillSummaryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ExciseSaleBillSummaryReport");

            entity.Property(e => e.LserviceChargeAmt).HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTaxAmt).HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<ExciseSummaryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseSummaryReport");

            entity.Property(e => e.BillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("BillNO");
            entity.Property(e => e.Liquor).HasDefaultValueSql("0");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseUnitLimit>(entity =>
        {
            entity.HasKey(e => e.LiquorTypeId).HasName("PrimaryKey");

            entity.ToTable("ExciseUnitLimit");

            entity.HasIndex(e => e.LiquorTypeId, "Unitcode");

            entity.Property(e => e.LiquorTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("LiquorTypeID");
            entity.Property(e => e.UnitLimit).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseUnitSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseUnitSetting");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.HasIndex(e => e.Unitcode1, "Unitcode");

            entity.Property(e => e.ExciseGroupId).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.UnitCode2).HasDefaultValueSql("0");
            entity.Property(e => e.UnitLimit).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode1).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseUnitSettingFlr3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseUnitSettingFLR3");

            entity.HasIndex(e => e.Unitcode1, "Unitcode");

            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.UnitCode2).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode1).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExciseUnitSettingFlrcl23>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ExciseUnitSettingFLRCL23");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ExpensesGroup>(entity =>
        {
            entity.HasKey(e => e.EgroupId).HasName("PrimaryKey");

            entity.ToTable("ExpensesGroup");

            entity.HasIndex(e => e.EgroupId, "ExpensesID");

            entity.Property(e => e.EgroupId)
                .HasDefaultValueSql("0")
                .HasColumnName("EGroupID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.EgroupName).HasMaxLength(120);
        });

        modelBuilder.Entity<ExpensesMaster>(entity =>
        {
            entity.HasKey(e => e.ExpensesId).HasName("PrimaryKey");

            entity.ToTable("ExpensesMaster");

            entity.HasIndex(e => e.EgroupId, "EGroupID");

            entity.HasIndex(e => e.ExpensesId, "ExpensesID");

            entity.Property(e => e.ExpensesId)
                .HasDefaultValueSql("0")
                .HasColumnName("ExpensesID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.EgroupId)
                .HasDefaultValueSql("0")
                .HasColumnName("EGroupID");
            entity.Property(e => e.Expenses).HasMaxLength(120);
        });

        modelBuilder.Entity<ExpensesRegister>(entity =>
        {
            entity.HasKey(e => e.TranNo).HasName("PrimaryKey");

            entity.ToTable("ExpensesRegister");

            entity.Property(e => e.TranNo).HasDefaultValueSql("0");
            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.Description).HasMaxLength(120);
            entity.Property(e => e.Particular).HasMaxLength(120);
        });

        modelBuilder.Entity<ExpiryBeerItemsDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ExpiryBeerItemsDetailReport");

            entity.Property(e => e.BatchNo).HasMaxLength(120);
            entity.Property(e => e.BeerMfgdate).HasColumnName("BeerMFGDate");
            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.Pdate).HasColumnName("PDate");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<FbquestionMaster>(entity =>
        {
            entity.HasKey(e => e.Qid).HasName("PrimaryKey");

            entity.ToTable("FBQuestionMaster");

            entity.HasIndex(e => e.Qid, "QuesID");

            entity.Property(e => e.Qid)
                .ValueGeneratedNever()
                .HasColumnName("QID");
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.Opt1).HasMaxLength(255);
            entity.Property(e => e.Opt2).HasMaxLength(255);
            entity.Property(e => e.Opt3).HasMaxLength(255);
            entity.Property(e => e.Opt4).HasMaxLength(255);
            entity.Property(e => e.Opt5).HasMaxLength(255);
            entity.Property(e => e.OptionAllow).HasMaxLength(1);
            entity.Property(e => e.Question).HasMaxLength(255);
        });

        modelBuilder.Entity<FbresultMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FBResultMaster");

            entity.HasIndex(e => e.Tdate, "QuesID");

            entity.Property(e => e.Qid).HasColumnName("QID");
            entity.Property(e => e.Result).HasMaxLength(255);
            entity.Property(e => e.TableId).HasColumnName("TableID");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TrId).HasColumnName("TrID");
        });

        modelBuilder.Entity<FeedbackResultReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FeedbackResultReport");

            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Qid).HasColumnName("QID");
            entity.Property(e => e.Question).HasMaxLength(255);
            entity.Property(e => e.Result).HasMaxLength(255);
            entity.Property(e => e.TableId).HasColumnName("TableID");
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FinishGoodGeneration>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PrimaryKey");

            entity.ToTable("FinishGoodGeneration");

            entity.HasIndex(e => e.Tdate, "IDate");

            entity.HasIndex(e => e.Tid, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FinishGoodGenerationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FinishGoodGenerationDetail");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Tid, "Pbillcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("0")
                .HasColumnName("TID");
        });

        modelBuilder.Entity<FoodAdjustment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodAdjustment");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.PbillCode, "PbillCode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.PbillCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<FoodAdjustmentTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodAdjustmentTemp");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.SubGroupCode, "SubGroupCode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("SRNo");
            entity.Property(e => e.SubGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBill");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge).HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FoodBillMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillMain");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FoodBillMultipale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillMultipale");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge).HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FoodBillRoundOff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillRoundOff");

            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodBillSummary1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodBillSummary1");

            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodBillSummary2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodBillSummary2");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodBillSummaryCreditBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillSummaryCreditBill");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CreditId).HasColumnName("CreditID");
            entity.Property(e => e.CreditorName).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FoodBillSummaryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillSummaryReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge).HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodBillsDateWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodBillsDateWise");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge).HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FoodDataGrouping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodDataGrouping");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.Property(e => e.ItemGroup).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<FoodDataGroupingTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodDataGroupingTemp");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.LiquorPbillcode, "LiquorPbillcode");

            entity.HasIndex(e => e.PbillCode, "PbillCode");

            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.PbillCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("SRNo");
        });

        modelBuilder.Entity<FoodGstreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodGSTReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodGstreportNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodGSTReportNew");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<FoodStockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FoodStockDetail");

            entity.HasIndex(e => e.RawItemCode, "RawItemCode");

            entity.Property(e => e.ClosingStock).HasDefaultValueSql("0");
            entity.Property(e => e.ComputerC).HasDefaultValueSql("0");
            entity.Property(e => e.Different).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningBalance).HasDefaultValueSql("0");
            entity.Property(e => e.Preturn)
                .HasDefaultValueSql("0")
                .HasColumnName("PReturn");
            entity.Property(e => e.RawItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.RawName).HasMaxLength(120);
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.StockC).HasDefaultValueSql("0");
            entity.Property(e => e.Total).HasDefaultValueSql("0");
            entity.Property(e => e.Wastage).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<FoodStockDetailReportBefore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FoodStockDetailReportBefore");

            entity.Property(e => e.Preturn).HasColumnName("PReturn");
        });

        modelBuilder.Entity<FunctionProspectu>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ExpectedPax, "BookingID");

            entity.HasIndex(e => e.HallId, "CaptainCode");

            entity.HasIndex(e => e.FunctionTypeId, "Customercode");

            entity.HasIndex(e => e.DepositId, "DepositID");

            entity.HasIndex(e => e.CustomerId, "GuestID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.HasIndex(e => e.UserCode, "UserCode");

            entity.Property(e => e.AddOther).HasDefaultValueSql("0");
            entity.Property(e => e.AdvanceAmount).HasDefaultValueSql("0");
            entity.Property(e => e.BankName).HasMaxLength(110);
            entity.Property(e => e.CateringManager).HasMaxLength(255);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(115);
            entity.Property(e => e.CustomerId)
                .HasDefaultValueSql("0")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DeductOther).HasDefaultValueSql("0");
            entity.Property(e => e.DepositId)
                .HasDefaultValueSql("0")
                .HasColumnName("DepositID");
            entity.Property(e => e.Equipment).HasMaxLength(255);
            entity.Property(e => e.ExpectedPax).HasDefaultValueSql("0");
            entity.Property(e => e.Fbinstr)
                .HasMaxLength(255)
                .HasColumnName("FBInstr");
            entity.Property(e => e.FlowOfEvent).HasMaxLength(255);
            entity.Property(e => e.Foinstr)
                .HasMaxLength(255)
                .HasColumnName("FOInstr");
            entity.Property(e => e.FromDateTime).HasMaxLength(50);
            entity.Property(e => e.FunctionTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("FunctionTypeID");
            entity.Property(e => e.HallId)
                .HasDefaultValueSql("0")
                .HasColumnName("HallID");
            entity.Property(e => e.HallRent).HasDefaultValueSql("0");
            entity.Property(e => e.Hkinstr)
                .HasMaxLength(255)
                .HasColumnName("HKInstr");
            entity.Property(e => e.Layout).HasMaxLength(255);
            entity.Property(e => e.Maintain).HasMaxLength(50);
            entity.Property(e => e.MinimumGuaranteed).HasDefaultValueSql("0");
            entity.Property(e => e.NetAmount).HasDefaultValueSql("0");
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.RatePerPax).HasDefaultValueSql("0");
            entity.Property(e => e.RectNo).HasMaxLength(50);
            entity.Property(e => e.SalesBillUsed).HasMaxLength(50);
            entity.Property(e => e.Stores).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.ToDateTime).HasMaxLength(50);
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.UserCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<FunctionProspectusDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FunctionProspectusDetail");

            entity.HasIndex(e => e.Pax, "Amount");

            entity.HasIndex(e => e.Amount, "BookingID");

            entity.HasIndex(e => e.Tdate, "Customercode");

            entity.HasIndex(e => e.MenuTypeId, "MenuTypeID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.MenuTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("MenuTypeID");
            entity.Property(e => e.Pax).HasDefaultValueSql("0");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TdateTime)
                .HasMaxLength(50)
                .HasColumnName("TDateTime");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<FunctionProspectusDetailSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FunctionProspectusDetailSub");

            entity.HasIndex(e => e.Qty, "BookingID");

            entity.HasIndex(e => e.Rate, "Qty");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SrnoMain).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<FunctionProspectusDetailSubTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FunctionProspectusDetailSubTemp");

            entity.HasIndex(e => e.Qty, "BookingID");

            entity.HasIndex(e => e.Rate, "Qty");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SrnoMain).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<FunctionProspectusItemNameCombine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FunctionProspectusItemNameCombine");

            entity.HasIndex(e => e.Qty, "Qty");

            entity.HasIndex(e => e.Rate, "Rate");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SrnoMain).HasDefaultValueSql("0");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<FunctionProspectusReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FunctionProspectusReport");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(110);
            entity.Property(e => e.CateringManager).HasMaxLength(255);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(115);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Equipment).HasMaxLength(255);
            entity.Property(e => e.Fbinstr)
                .HasMaxLength(255)
                .HasColumnName("FBInstr");
            entity.Property(e => e.FlowOfEvent).HasMaxLength(255);
            entity.Property(e => e.Foinstr)
                .HasMaxLength(255)
                .HasColumnName("FOInstr");
            entity.Property(e => e.FromDateTime).HasMaxLength(50);
            entity.Property(e => e.FunctionType).HasMaxLength(120);
            entity.Property(e => e.FunctionTypeId).HasColumnName("FunctionTypeID");
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Hall).HasMaxLength(120);
            entity.Property(e => e.HallId).HasColumnName("HallID");
            entity.Property(e => e.Hkinstr)
                .HasMaxLength(255)
                .HasColumnName("HKInstr");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Layout).HasMaxLength(255);
            entity.Property(e => e.Maintain).HasMaxLength(50);
            entity.Property(e => e.MenuType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.RectNo).HasMaxLength(50);
            entity.Property(e => e.Stores).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TdateDetail).HasColumnName("TDateDetail");
            entity.Property(e => e.TdateTime)
                .HasMaxLength(50)
                .HasColumnName("TDateTime");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.ToDateTime).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FunctionProspectusReportMgm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FunctionProspectusReportMGM");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(110);
            entity.Property(e => e.CateringManager).HasMaxLength(255);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(115);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Equipment).HasMaxLength(255);
            entity.Property(e => e.Fbinstr)
                .HasMaxLength(255)
                .HasColumnName("FBInstr");
            entity.Property(e => e.FlowOfEvent).HasMaxLength(255);
            entity.Property(e => e.Foinstr)
                .HasMaxLength(255)
                .HasColumnName("FOInstr");
            entity.Property(e => e.FromDateTime).HasMaxLength(50);
            entity.Property(e => e.FunctionType).HasMaxLength(120);
            entity.Property(e => e.FunctionTypeId).HasColumnName("FunctionTypeID");
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Hall).HasMaxLength(120);
            entity.Property(e => e.HallId).HasColumnName("HallID");
            entity.Property(e => e.Hkinstr)
                .HasMaxLength(255)
                .HasColumnName("HKInstr");
            entity.Property(e => e.Layout).HasMaxLength(255);
            entity.Property(e => e.Maintain).HasMaxLength(50);
            entity.Property(e => e.MenuType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.RectNo).HasMaxLength(50);
            entity.Property(e => e.Stores).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TdateDetail).HasColumnName("TDateDetail");
            entity.Property(e => e.TdateTime)
                .HasMaxLength(50)
                .HasColumnName("TDateTime");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.ToDateTime).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<FunctionTypeMaster>(entity =>
        {
            entity.HasKey(e => e.FunctionTypeId).HasName("PrimaryKey");

            entity.ToTable("FunctionTypeMaster");

            entity.HasIndex(e => e.FunctionTypeId, "Statecode");

            entity.Property(e => e.FunctionTypeId)
                .ValueGeneratedNever()
                .HasColumnName("FunctionTypeID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.FunctionType).HasMaxLength(120);
        });

        modelBuilder.Entity<FydeleteTableDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FYDeleteTableData");

            entity.Property(e => e.TableName).HasMaxLength(120);
        });

        modelBuilder.Entity<Fymaster>(entity =>
        {
            entity.HasKey(e => e.Fycode).HasName("PrimaryKey");

            entity.ToTable("Fymaster");

            entity.HasIndex(e => e.Fycode, "Fycode");

            entity.Property(e => e.Fycode).HasDefaultValueSql("0");
            entity.Property(e => e.CloseFlag).HasMaxLength(1);
            entity.Property(e => e.Todate).HasColumnName("todate");
        });

        modelBuilder.Entity<HallMaster>(entity =>
        {
            entity.HasKey(e => e.HallId).HasName("PrimaryKey");

            entity.ToTable("HallMaster");

            entity.HasIndex(e => e.HallId, "FacilityId");

            entity.Property(e => e.HallId)
                .HasDefaultValueSql("0")
                .HasColumnName("HallID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Hall).HasMaxLength(120);
        });

        modelBuilder.Entity<HotelBackupItemTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HotelBackupItemTitle");

            entity.HasIndex(e => e.ModuleId, "ModuleID");

            entity.Property(e => e.MenuName).HasMaxLength(255);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleSetting).HasMaxLength(255);
        });

        modelBuilder.Entity<HotelBackupMainTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HotelBackupMainTitle");

            entity.HasIndex(e => e.ModuleId, "ModuleID");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleName).HasMaxLength(255);
        });

        modelBuilder.Entity<IssueDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IssueDetail");

            entity.HasIndex(e => e.RawItemId, "RawItemId1");

            entity.HasIndex(e => e.IssueId, "RawitemID");

            entity.HasIndex(e => e.UnitCode, "UnitCode1");

            entity.HasIndex(e => e.Idate, "Unitcode");

            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.IssueId)
                .HasDefaultValueSql("0")
                .HasColumnName("IssueID");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawItemId).HasDefaultValueSql("0");
            entity.Property(e => e.Unit).HasMaxLength(120);
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<IssueToBar>(entity =>
        {
            entity.HasKey(e => e.IssueId).HasName("PrimaryKey");

            entity.ToTable("IssueToBar");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.Idate, "IDate");

            entity.HasIndex(e => e.IssueId, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.IssueId)
                .HasDefaultValueSql("0")
                .HasColumnName("IssueID");
            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<IssueToBarDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IssueToBarDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.IssueId, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.IssueId)
                .HasDefaultValueSql("0")
                .HasColumnName("IssueID");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemBunching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemBunching");

            entity.HasIndex(e => e.SubItemcode, "SubItemcode");

            entity.HasIndex(e => e.Transactionid, "Transactionid");

            entity.HasIndex(e => e.UseItemcode, "UseItemcode");

            entity.Property(e => e.SubItemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Transactionid).HasDefaultValueSql("0");
            entity.Property(e => e.UseItemcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemDapartmentwiseDailySale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemDetail");

            entity.HasIndex(e => e.Barcode, "Barcode");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.Itemcode, "RawitemID");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupCode).HasName("PrimaryKey");

            entity.ToTable("ItemGroup");

            entity.HasIndex(e => e.ItemGroupCode, "Itemgroupcode");

            entity.HasIndex(e => e.SubGroupcode, "SubGroupcode");

            entity.Property(e => e.ItemGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Gsttax).HasColumnName("GSTTax");
            entity.Property(e => e.Ordertype)
                .HasMaxLength(120)
                .HasColumnName("ordertype");
            entity.Property(e => e.Sacno)
                .HasMaxLength(255)
                .HasDefaultValueSql("0")
                .HasColumnName("SACNo");
            entity.Property(e => e.SubGroupcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemGroupWiseDailySale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemInfoReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("itemInfoReport");

            entity.HasIndex(e => e.Itemgroupcode, "itemgroupcode");

            entity.HasIndex(e => e.Itemid, "itemid");

            entity.Property(e => e.Itemgroupcode).HasColumnName("itemgroupcode");
            entity.Property(e => e.Itemid)
                .HasDefaultValueSql("0")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemname)
                .HasMaxLength(120)
                .HasColumnName("itemname");
            entity.Property(e => e.Salesprice).HasColumnName("salesprice");
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Unit)
                .HasMaxLength(120)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<ItemLiquer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemLiquer");

            entity.HasIndex(e => e.ConvertUnitCode, "ConvertUnitCode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Liquer).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemMaster>(entity =>
        {
            entity.HasKey(e => e.Itemcode).HasName("PrimaryKey");

            entity.ToTable("ItemMaster");

            entity.HasIndex(e => e.CpgroupCode, "CPGroupCode");

            entity.HasIndex(e => e.DepartmentCode, "CategoryCode");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.HasIndex(e => e.ItemGroupCode, "ItemGroupCode");

            entity.HasIndex(e => e.ItemId, "ItemID");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.LiquorTypeId, "LiquorTypeID");

            entity.HasIndex(e => e.Rawitemcode, "Rawitemcode");

            entity.HasIndex(e => e.TsmainGroupcode, "TSMainGroupcode");

            entity.HasIndex(e => e.TssubGroupcode, "TSSubGroupcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.HasIndex(e => e.UseId, "UseID");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.CpgroupCode).HasColumnName("CPGroupCode");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.DepartmentCode).HasDefaultValueSql("0");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ExciseGroupId).HasDefaultValueSql("0");
            entity.Property(e => e.ItemGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemImagePath).HasMaxLength(255);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.ItemShortName).HasMaxLength(120);
            entity.Property(e => e.LiquorTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("LiquorTypeID");
            entity.Property(e => e.PurchasePrice).HasDefaultValueSql("0");
            entity.Property(e => e.Rawitemcode).HasDefaultValueSql("0");
            entity.Property(e => e.SalesPrice).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TsmainGroupcode).HasColumnName("TSMainGroupcode");
            entity.Property(e => e.TssubGroupcode).HasColumnName("TSSubGroupcode");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.UseId)
                .HasDefaultValueSql("0")
                .HasColumnName("UseID");
        });

        modelBuilder.Entity<ItemNameSplitQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Item Name Split Query");

            entity.Property(e => e.ItemName).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemRateChangeReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemRateChangeReport");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemRateSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemRateSetting");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Deleteflag).HasMaxLength(50);
            entity.Property(e => e.FirstRate).HasDefaultValueSql("0");
            entity.Property(e => e.ItemType).HasMaxLength(1);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.RateUpdate).HasMaxLength(1);
            entity.Property(e => e.SecondRate).HasDefaultValueSql("0");
            entity.Property(e => e.SnackFirst).HasDefaultValueSql("0");
            entity.Property(e => e.SnackSecond).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemRecipe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemRecipe");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.HasIndex(e => e.Rawitemid, "rawitemid");

            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Rawitemid).HasColumnName("rawitemid");
            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemTitlel>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PrimaryKey");

            entity.ToTable("ItemTitlel");

            entity.HasIndex(e => e.MenuId, "MenuID");

            entity.HasIndex(e => e.SubId, "SubID");

            entity.Property(e => e.MenuId)
                .HasDefaultValueSql("0")
                .HasColumnName("MenuID");
            entity.Property(e => e.FoodOrLiquor).HasMaxLength(1);
            entity.Property(e => e.MenuName).HasMaxLength(120);
            entity.Property(e => e.ModuleSetting).HasMaxLength(120);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SubId)
                .HasDefaultValueSql("0")
                .HasColumnName("SubID");
        });

        modelBuilder.Entity<ItemWiseConsumption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemWiseConsumption");

            entity.Property(e => e.Ml).HasDefaultValueSql("0");
            entity.Property(e => e.PurQty).HasDefaultValueSql("0");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawItemId).HasDefaultValueSql("0");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemWisePurchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemWisePurchase");

            entity.Property(e => e.DiscountType).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.Pdate).HasColumnName("PDate");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.StockType).HasMaxLength(1);
            entity.Property(e => e.Tcs).HasColumnName("TCS");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemWisePurchasedetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemWisePurchasedetail");

            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Pdate).HasColumnName("PDate");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemWiseSalesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemWiseSalesDetail");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemWiseSalesWithMrprateReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemWiseSalesWithMRPRateReport");

            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.SectionName).HasMaxLength(255);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemWiseTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemWiseTransaction");

            entity.HasIndex(e => e.BillId, "BillID");

            entity.Property(e => e.BillId)
                .HasDefaultValueSql("0")
                .HasColumnName("BillID");
            entity.Property(e => e.IitemName).HasMaxLength(120);
            entity.Property(e => e.Ml).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<Itemreatedetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Itemreatedetail");

            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.ExciseItemCode).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<ItemwiseSalesQtyReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemwiseSalesQtyReport");

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CancelQty).HasDefaultValueSql("0");
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.OrderQty).HasDefaultValueSql("0");
            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.Sales).HasDefaultValueSql("0");
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ItemwiseTransactionReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ItemwiseTransactionReport");

            entity.Property(e => e.PbillCode).HasColumnName("PBillCode");
            entity.Property(e => e.Porder).HasColumnName("POrder");
            entity.Property(e => e.Punit)
                .HasMaxLength(120)
                .HasColumnName("PUnit");
            entity.Property(e => e.SbillCode).HasColumnName("SBillCode");
            entity.Property(e => e.StransNo).HasColumnName("STransNo");
            entity.Property(e => e.Sunit)
                .HasMaxLength(120)
                .HasColumnName("SUnit");
        });

        modelBuilder.Entity<KbccancelPrinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KBCCancelPrinting");

            entity.Property(e => e.CaptainName).HasMaxLength(255);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Ordertype)
                .HasMaxLength(120)
                .HasColumnName("ordertype");
            entity.Property(e => e.PrinterName).HasMaxLength(120);
            entity.Property(e => e.Printflag).HasMaxLength(1);
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Tableno).HasColumnName("tableno");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<KbcduplicatePrinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KBCDuplicatePrinting");

            entity.Property(e => e.CaptainName).HasMaxLength(255);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Ordertype)
                .HasMaxLength(120)
                .HasColumnName("ordertype");
            entity.Property(e => e.PrinterName).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Taste).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<Kbcprinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KBCPrinting");

            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PrinterName).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(4);
            entity.Property(e => e.Taste).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<KotBotCancelItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KotBotCancelItem");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<KotBotDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KotBOtDetailReport");

            entity.Property(e => e.Botdata)
                .HasMaxLength(255)
                .HasColumnName("BOTData");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Kotdata)
                .HasMaxLength(255)
                .HasColumnName("KOTData");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<KotBotWiseBillDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KotBotWiseBillDetailReport");

            entity.HasIndex(e => e.Pbillcode, "PBillcode");

            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.KotBotCotNo).HasMaxLength(120);
            entity.Property(e => e.Pbillcode)
                .HasDefaultValueSql("0")
                .HasColumnName("PBillcode");
            entity.Property(e => e.Ttype)
                .HasMaxLength(120)
                .HasColumnName("TType");
        });

        modelBuilder.Entity<KotBotdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kotBOTData");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.Botdata)
                .HasMaxLength(255)
                .HasColumnName("BOTData");
            entity.Property(e => e.Kotdata)
                .HasMaxLength(255)
                .HasColumnName("KOTData");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<KotPrinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KotPrinting");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.BotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.CotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<KotbotSectionwisesaleReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("kotbotSectionwisesaleReport");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Ordertype)
                .HasMaxLength(120)
                .HasColumnName("ordertype");
        });

        modelBuilder.Entity<KotbotseriesReportTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kotbotseries_ReportTable");

            entity.HasIndex(e => e.Pbillcode, "PBillcode");

            entity.Property(e => e.Pbillcode)
                .HasDefaultValueSql("0")
                .HasColumnName("PBillcode");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<KotstyleMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KOTStyleMaster");

            entity.HasIndex(e => e.KotstyleId, "KOTStyleID");

            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.Description).HasMaxLength(120);
            entity.Property(e => e.Kotstyle)
                .HasMaxLength(3)
                .HasColumnName("KOTStyle");
            entity.Property(e => e.KotstyleId).HasColumnName("KOTStyleID");
        });

        modelBuilder.Entity<LiquerCosting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LiquerCosting");

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.ItemName, "Unitcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode1");

            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Menuvalue).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseValue).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.SalesValue).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<LiquorGroupWiseSale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Unit).HasMaxLength(120);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<LiquorType>(entity =>
        {
            entity.HasKey(e => e.LiquorTypeId).HasName("PrimaryKey");

            entity.ToTable("LiquorType");

            entity.HasIndex(e => e.LiquorTypeId, "LiquorTypeID");

            entity.Property(e => e.LiquorTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("LiquorTypeID");
            entity.Property(e => e.DeleteFlag).HasMaxLength(50);
            entity.Property(e => e.LiquorType1)
                .HasMaxLength(120)
                .HasColumnName("LiquorType");
        });

        modelBuilder.Entity<LodgingBillDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LodgingBillDetail");

            entity.HasIndex(e => e.BillId, "BillId");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.BillId).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.ServiceCharge).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<LooseLiquorSetting>(entity =>
        {
            entity.HasKey(e => e.Unitcode).HasName("PrimaryKey");

            entity.ToTable("LooseLiquorSetting");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.DeductMl)
                .HasDefaultValueSql("0")
                .HasColumnName("DeductML");
        });

        modelBuilder.Entity<MainTitle>(entity =>
        {
            entity.HasKey(e => e.MainId).HasName("PrimaryKey");

            entity.ToTable("MainTitle");

            entity.HasIndex(e => e.MainId, "TraID");

            entity.Property(e => e.MainId)
                .HasDefaultValueSql("0")
                .HasColumnName("MainID");
            entity.Property(e => e.MainTitle1)
                .HasMaxLength(120)
                .HasColumnName("MainTitle");
            entity.Property(e => e.ModuleSetting).HasMaxLength(50);
        });

        modelBuilder.Entity<MasterExportDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MasterExportDate");

            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<MaxCustomerBillNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MaxCustomerBillNo");

            entity.Property(e => e.FbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("FBillNo");
            entity.Property(e => e.LbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("LBillNo");
        });

        modelBuilder.Entity<MenuTaste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MenuTaste");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.Taste, "TasteId");

            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Kotbot)
                .HasMaxLength(255)
                .HasColumnName("KOTBOT");
        });

        modelBuilder.Entity<MenuTypeMaster>(entity =>
        {
            entity.HasKey(e => e.MenuTypeId).HasName("PrimaryKey");

            entity.ToTable("MenuTypeMaster");

            entity.HasIndex(e => e.MenuTypeId, "FacilityId");

            entity.Property(e => e.MenuTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("MenuTypeID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.MenuType).HasMaxLength(120);
        });

        modelBuilder.Entity<MessageMaster>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PrimaryKey");

            entity.ToTable("MessageMaster");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("MessageID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Message).HasMaxLength(255);
        });

        modelBuilder.Entity<MonthWiseStockValuation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MonthWiseStockValuation");

            entity.Property(e => e.Mrp).HasColumnName("MRP");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<MonthlyFoodBillSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyFoodBillSummary");

            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.SoftDrinkAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.VatAmt).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<MsummeryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSummeryReport");

            entity.Property(e => e.Cmonth).HasColumnName("CMonth");
            entity.Property(e => e.ExpensesAmt).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseAmt).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseBalanceAmt).HasDefaultValueSql("0");
            entity.Property(e => e.SalesAmt).HasDefaultValueSql("0");
            entity.Property(e => e.SalesBalanceAmt).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<OnlineExUnitWiseSalesAndPurchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OnlineExUnitWiseSalesAndPurchase");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.Property(e => e.BackSpqty)
                .HasMaxLength(255)
                .HasColumnName("BackSPQty");
            entity.Property(e => e.ExciseGroupName).HasMaxLength(255);
            entity.Property(e => e.Ml)
                .HasMaxLength(255)
                .HasColumnName("ML");
            entity.Property(e => e.TodaySpqty).HasColumnName("TodaySPQty");
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<OpeningStockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OpeningStockDetail");

            entity.HasIndex(e => e.GroupCode, "GroupCode");

            entity.HasIndex(e => e.RawItemId, "RawItemID");

            entity.HasIndex(e => e.SubGroupCode, "SubGroupCode");

            entity.HasIndex(e => e.TransId, "TransID");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.GroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawItemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawItemID");
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SubGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.TransId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransID");
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<OpeningStockFormatReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OpeningStockFormatReport");

            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.ExciseGroupName).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.PackingType).HasMaxLength(120);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<OpeningStockMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OpeningStockMaster");

            entity.HasIndex(e => e.Empno, "ItemGroupID");

            entity.HasIndex(e => e.Tdate, "ItemGroupID1");

            entity.HasIndex(e => e.TransId, "ItemID");

            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningMonth).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransID");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderDetail");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
            entity.Property(e => e.TasteName).HasMaxLength(255);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<OtherDepositDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OtherDepositDetail");

            entity.Property(e => e.DepositorName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<OwnerDepositDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OwnerDepositDetail");

            entity.Property(e => e.DepositorName).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<PasteError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Paste Errors");
        });

        modelBuilder.Entity<PhysicalLiuorSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PhysicalLiuorSetting");

            entity.Property(e => e.Asales).HasColumnName("ASales");
            entity.Property(e => e.Csales).HasColumnName("CSales");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<PortMaster>(entity =>
        {
            entity.HasKey(e => e.Portcode).HasName("PrimaryKey");

            entity.ToTable("PortMaster");

            entity.HasIndex(e => e.Portcode, "Statecode");

            entity.Property(e => e.Portcode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.PortName).HasMaxLength(120);
        });

        modelBuilder.Entity<PresentyDefine>(entity =>
        {
            entity.HasKey(e => new { e.Empno, e.Tdate }).HasName("PrimaryKey");

            entity.ToTable("PresentyDefine");

            entity.HasIndex(e => e.InDate2, "InDate1");

            entity.HasIndex(e => e.InDate1, "MainID");

            entity.HasIndex(e => e.ShiftId, "ShiftID");

            entity.HasIndex(e => e.Empno, "Usercode");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.OutDate1).HasColumnName("outDate1");
            entity.Property(e => e.OutDate2).HasColumnName("outDate2");
            entity.Property(e => e.ShiftId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftID");
            entity.Property(e => e.TotalHours).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<PrintingSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrintingSetting");

            entity.Property(e => e.SalesBillPrinting).HasMaxLength(255);
        });

        modelBuilder.Entity<PurchaseBill>(entity =>
        {
            entity.HasKey(e => e.Pbillcode).HasName("PrimaryKey");

            entity.ToTable("PurchaseBill");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Suppliercode, "Suppliercode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Carting).HasDefaultValueSql("0");
            entity.Property(e => e.CounterPayment).HasMaxLength(1);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountType).HasMaxLength(120);
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Other).HasDefaultValueSql("0");
            entity.Property(e => e.Pdate).HasColumnName("PDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SalesTax).HasDefaultValueSql("0");
            entity.Property(e => e.SchAmt).HasDefaultValueSql("0");
            entity.Property(e => e.StockType).HasMaxLength(1);
            entity.Property(e => e.Suppliercode).HasDefaultValueSql("0");
            entity.Property(e => e.Tcs)
                .HasDefaultValueSql("0")
                .HasColumnName("TCS");
            entity.Property(e => e.Tpdate).HasColumnName("TPDate");
            entity.Property(e => e.Tpno)
                .HasDefaultValueSql("0")
                .HasColumnName("TPNO");
            entity.Property(e => e.TradeDis).HasDefaultValueSql("0");
            entity.Property(e => e.Transport).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<PurchaseBilldetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseBilldetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.OpeningUnitCode, "OpeningUnitCode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.BatchNo).HasMaxLength(120);
            entity.Property(e => e.BeerMfgdate).HasColumnName("BeerMFGDate");
            entity.Property(e => e.BottleQty).HasDefaultValueSql("0");
            entity.Property(e => e.CaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Free).HasDefaultValueSql("0");
            entity.Property(e => e.Gsttax)
                .HasDefaultValueSql("0")
                .HasColumnName("GSTTax");
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("0")
                .HasColumnName("MRP");
            entity.Property(e => e.OpeningUnitCode).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.UnitCaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<PurchaseDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PurchaseDetail");

            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Pdate).HasColumnName("PDate");
        });

        modelBuilder.Entity<PurchaseLedgerReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseLedgerReport");

            entity.Property(e => e.PbillCode)
                .HasColumnType("char(50)")
                .HasColumnName("PBillCode");
            entity.Property(e => e.SupplierName).HasColumnType("char(255)");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Tid)
                .HasColumnType("char(50)")
                .HasColumnName("TID");
            entity.Property(e => e.Ttype)
                .HasColumnType("char(70)")
                .HasColumnName("TType");
        });

        modelBuilder.Entity<PurchaseOutstanding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PurchaseOutstanding");

            entity.Property(e => e.Cityname).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<PurchasePayment>(entity =>
        {
            entity.HasKey(e => e.Ppno).HasName("PrimaryKey");

            entity.ToTable("PurchasePayment");

            entity.HasIndex(e => e.BankCode, "BankCode");

            entity.HasIndex(e => e.Suppliercode, "Suppliercode");

            entity.Property(e => e.Ppno)
                .ValueGeneratedNever()
                .HasColumnName("PPno");
            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Chequeno).HasMaxLength(120);
            entity.Property(e => e.PaymentType).HasMaxLength(120);
            entity.Property(e => e.PbillNo).HasDefaultValueSql("0");
            entity.Property(e => e.PreturnAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("PReturnAmt");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<PurchasePaymentReturndetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchasePaymentReturndetail");

            entity.HasIndex(e => e.Prcode, "prcode");

            entity.Property(e => e.Ppno)
                .HasDefaultValueSql("0")
                .HasColumnName("PPno");
            entity.Property(e => e.Prcode)
                .HasDefaultValueSql("0")
                .HasColumnName("prcode");
            entity.Property(e => e.Returnamt).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<PurchaseReturn>(entity =>
        {
            entity.HasKey(e => e.Prcode).HasName("PrimaryKey");

            entity.ToTable("PurchaseReturn");

            entity.HasIndex(e => e.Paid, "Paid");

            entity.HasIndex(e => e.Prcode, "Pbillcode");

            entity.HasIndex(e => e.Suppliercode, "Suppliercode");

            entity.Property(e => e.Prcode)
                .HasDefaultValueSql("0")
                .HasColumnName("prcode");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountType).HasMaxLength(120);
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Paid).HasMaxLength(1);
            entity.Property(e => e.Paidamt).HasDefaultValueSql("0");
            entity.Property(e => e.Pdate).HasColumnName("PDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StockType).HasMaxLength(1);
            entity.Property(e => e.Suppliercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<PurchaseReturnDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseReturnDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Prcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "unitcode");

            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Prcode)
                .HasDefaultValueSql("0")
                .HasColumnName("prcode");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Unitcode)
                .HasDefaultValueSql("0")
                .HasColumnName("unitcode");
        });

        modelBuilder.Entity<Qrimage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QRImage");
        });

        modelBuilder.Entity<RawItemConvert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RawItemConvert");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.FromUnitcode, "FromUnitcode");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.ConversitionQty).HasDefaultValueSql("0");
            entity.Property(e => e.ExBalanceMl).HasColumnName("ExBalanceML");
            entity.Property(e => e.ExBalanceQty).HasDefaultValueSql("0");
            entity.Property(e => e.FromUnitcode).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<RawItemConvertDetailReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RawItemConvertDetailReport");

            entity.Property(e => e.BarCounterId).HasColumnName("BarCounterID");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<RawItemConvertTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RawItemConvertTemp");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.FromUnitcode, "FromUnitcode");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.ConversitionQty).HasDefaultValueSql("0");
            entity.Property(e => e.ExBalanceMl).HasColumnName("ExBalanceML");
            entity.Property(e => e.ExBalanceQty).HasDefaultValueSql("0");
            entity.Property(e => e.FromUnitcode).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<RawItemIssuedetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RawItemIssuedetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.IssueId, "Pbillcode");

            entity.Property(e => e.IssueId)
                .HasDefaultValueSql("0")
                .HasColumnName("IssueID");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
        });

        modelBuilder.Entity<RawItemReturn>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PrimaryKey");

            entity.ToTable("RawItemReturn");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Idate, "IDate");

            entity.HasIndex(e => e.ReturnId, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.ReturnId)
                .HasDefaultValueSql("0")
                .HasColumnName("ReturnID");
            entity.Property(e => e.Departmentcode).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<RawItemReturnDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RawItemReturnDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.ReturnId, "Pbillcode");

            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.ReturnId)
                .HasDefaultValueSql("0")
                .HasColumnName("ReturnID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
        });

        modelBuilder.Entity<RawItemissue>(entity =>
        {
            entity.HasKey(e => e.IssueId).HasName("PrimaryKey");

            entity.ToTable("RawItemissue");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Idate, "IDate");

            entity.HasIndex(e => e.IssueId, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.IssueId)
                .HasDefaultValueSql("0")
                .HasColumnName("IssueID");
            entity.Property(e => e.Departmentcode).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<Rawitem>(entity =>
        {
            entity.HasKey(e => e.RawitemId).HasName("PrimaryKey");

            entity.ToTable("Rawitem");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.HasIndex(e => e.ItemGroupCode, "ItemGroupCode");

            entity.HasIndex(e => e.LiquorTypeId, "LiquorTypeID");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.ExciseGroupId).HasDefaultValueSql("0");
            entity.Property(e => e.ItemGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquorTypeId)
                .HasDefaultValueSql("0")
                .HasColumnName("LiquorTypeID");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawItem1)
                .HasMaxLength(120)
                .HasColumnName("RawItem");
            entity.Property(e => e.StockEffect).HasMaxLength(1);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<RawitemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RawitemDetail");

            entity.HasIndex(e => e.Barcode, "Barcode");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("0")
                .HasColumnName("MRP");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<RconsumptionRecipeWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RConsumptionRecipeWise");

            entity.HasIndex(e => e.DepartmentCode, "DepartmentCode");

            entity.HasIndex(e => e.Tdate, "IDate");

            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<RconsumptionRecipeWise1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RConsumptionRecipeWise1");

            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<RefferenceTransactionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RefferenceTransactionDetail");

            entity.HasIndex(e => e.CustName, "Customercode");

            entity.Property(e => e.Amount).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.ReferenceName).HasMaxLength(255);
            entity.Property(e => e.SrNo).HasMaxLength(120);
            entity.Property(e => e.TransactionNo).HasDefaultValueSql("0");
            entity.Property(e => e.Type).HasMaxLength(120);
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.HasKey(e => e.Recordno).HasName("PrimaryKey");

            entity.ToTable("Reminder");

            entity.Property(e => e.Recordno).HasDefaultValueSql("0");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Rtime).HasColumnName("rtime");
            entity.Property(e => e.Title).HasMaxLength(120);
        });

        modelBuilder.Entity<ReportAlignmentMaster>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PrimaryKey");

            entity.ToTable("ReportAlignmentMaster");

            entity.HasIndex(e => e.ReportId, "Itemgroupcode");

            entity.HasIndex(e => e.PaperSizeId, "PaperSizeID");

            entity.Property(e => e.ReportId)
                .HasDefaultValueSql("0")
                .HasColumnName("ReportID");
            entity.Property(e => e.PaperSizeId).HasColumnName("PaperSizeID");
            entity.Property(e => e.PresentFlag).HasMaxLength(1);
            entity.Property(e => e.PrinterName).HasMaxLength(255);
            entity.Property(e => e.ReportFileName).HasMaxLength(150);
            entity.Property(e => e.ReportTitle).HasMaxLength(120);
        });

        modelBuilder.Entity<ReportPrinterSetMaster>(entity =>
        {
            entity.HasKey(e => e.PaperSizeId).HasName("PrimaryKey");

            entity.ToTable("ReportPrinterSetMaster");

            entity.HasIndex(e => e.PaperSizeId, "Itemgroupcode");

            entity.Property(e => e.PaperSizeId)
                .HasDefaultValueSql("0")
                .HasColumnName("PaperSizeID");
            entity.Property(e => e.PaperSize).HasMaxLength(50);
            entity.Property(e => e.PrinterName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReturnFromBar>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PrimaryKey");

            entity.ToTable("ReturnFromBar");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.Idate, "IDate");

            entity.HasIndex(e => e.ReturnId, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.ReturnId)
                .HasDefaultValueSql("0")
                .HasColumnName("ReturnID");
            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<ReturnFromBarDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReturnFromBarDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.ReturnId, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.ReturnId)
                .HasDefaultValueSql("0")
                .HasColumnName("ReturnID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<RoundOffQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RoundOffQuery");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<SalaryAdvance>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("SalaryAdvance");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.IssuedBy).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(150);
        });

        modelBuilder.Entity<SalaryAdvanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalaryAdvanceReport");

            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.IssuedBy).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(150);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<SalaryAdvanceSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalaryAdvanceSummary");

            entity.Property(e => e.Firstname).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(120);
            entity.Property(e => e.MiddleName).HasMaxLength(120);
        });

        modelBuilder.Entity<SalaryPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalaryPayment");

            entity.HasIndex(e => e.CreditId, "CreditID");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.CreditId).HasColumnName("CreditID");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<SalarySheet>(entity =>
        {
            entity.HasKey(e => e.TransactionNo).HasName("PrimaryKey");

            entity.ToTable("SalarySheet");

            entity.Property(e => e.TransactionNo).HasDefaultValueSql("0");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.ExtraDays).HasDefaultValueSql("0");
            entity.Property(e => e.Holidays).HasDefaultValueSql("0");
            entity.Property(e => e.OtherDed).HasDefaultValueSql("0");
            entity.Property(e => e.OtherEar).HasDefaultValueSql("0");
            entity.Property(e => e.OverTime).HasDefaultValueSql("0");
            entity.Property(e => e.PaySalary).HasDefaultValueSql("0");
            entity.Property(e => e.PresentDays).HasDefaultValueSql("0");
            entity.Property(e => e.Salary).HasDefaultValueSql("0");
            entity.Property(e => e.WithoutPay).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalarySheetReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalarySheetReport");
        });

        modelBuilder.Entity<SaleBill1CancelKot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SaleBill1CancelKot");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.CancelKotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode)
                .HasDefaultValueSql("0")
                .HasColumnName("itemcode");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.Tableno)
                .HasDefaultValueSql("0")
                .HasColumnName("tableno");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SaleBillDailyCancelKot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SaleBillDailyCancelKot");

            entity.HasIndex(e => e.Departmentcode, "Departmentcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.CancelKotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode)
                .HasDefaultValueSql("0")
                .HasColumnName("itemcode");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.Tableno)
                .HasDefaultValueSql("0")
                .HasColumnName("tableno");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Ttime)
                .HasMaxLength(120)
                .HasColumnName("TTime");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBil1Gstdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBil1GSTDetail");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<SalesBilGstdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBilGSTDetail");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<SalesBill>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBill");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CoupanId1).HasColumnName("CoupanID1");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.DirectSbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("DirectSBillNo");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBill1>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBill1");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.TableNo, "TableID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.HasIndex(e => e.WetterCode, "WetterCode");

            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.StartTime).HasMaxLength(120);
        });

        modelBuilder.Entity<SalesBill1Modify>(entity =>
        {
            entity.HasKey(e => new { e.UpdationSequence, e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBill1Modify");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.TableNo, "TableID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.HasIndex(e => e.WetterCode, "WetterCode");

            entity.Property(e => e.UpdationSequence).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.StartTime).HasMaxLength(120);
        });

        modelBuilder.Entity<SalesBillDaily>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBillDaily");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.TableNo, "TableID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.HasIndex(e => e.WetterCode, "WetterCode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Billamt).HasDefaultValueSql("0");
            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.PaidAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
            entity.Property(e => e.WetterCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillDailyGstdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillDailyGSTDetail");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<SalesBillDailyModify>(entity =>
        {
            entity.HasKey(e => new { e.UpdationSequence, e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBillDailyModify");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.TableNo, "TableID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.HasIndex(e => e.WetterCode, "WetterCode");

            entity.Property(e => e.UpdationSequence).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Billamt).HasDefaultValueSql("0");
            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.PaidAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
            entity.Property(e => e.WetterCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillDetail");

            entity.HasIndex(e => e.ConvertUnitCode, "ConvertUnitCode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode1");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.Billtype)
                .HasMaxLength(120)
                .HasColumnName("billtype");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillDetailDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillDetailDaily");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TransNo, "Pbillcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillDetailDailyModify>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillDetailDailyModify");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TransNo, "Pbillcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.UpdationSequence).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillDetailTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillDetailTemp");

            entity.HasIndex(e => e.ConvertUnitCode, "ConvertUnitCode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode1");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.Billtype)
                .HasMaxLength(120)
                .HasColumnName("billtype");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Liquer).HasColumnName("liquer");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesBillNoteDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillNoteDefine");
        });

        modelBuilder.Entity<SalesBillPrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesBillPrint");

            entity.HasIndex(e => e.CoupanNo, "CoupanNo");

            entity.HasIndex(e => e.CardNo, "CoupanNo1");

            entity.HasIndex(e => e.CoupanQty, "CoupanQty");

            entity.HasIndex(e => e.CoupanBal, "CoupanQty1");

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.Address).HasMaxLength(120);
            entity.Property(e => e.Billamt).HasDefaultValueSql("0");
            entity.Property(e => e.Capt).HasMaxLength(120);
            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.Cust).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Gst).HasMaxLength(120);
            entity.Property(e => e.Gstno)
                .HasMaxLength(120)
                .HasColumnName("GSTNo");
            entity.Property(e => e.Holdno).HasDefaultValueSql("0");
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.PhoneNo).HasMaxLength(120);
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.SalesBillPrint1)
                .HasMaxLength(120)
                .HasColumnName("SalesBillPrint");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit)
                .HasMaxLength(120)
                .HasColumnName("unit");
            entity.Property(e => e.User).HasMaxLength(120);
        });

        modelBuilder.Entity<SalesBillPrintReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesBillPrintReport");

            entity.Property(e => e.Add1).HasMaxLength(255);
            entity.Property(e => e.Add2).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(120);
            entity.Property(e => e.Capt).HasMaxLength(120);
            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.City).HasMaxLength(120);
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.Cust).HasMaxLength(120);
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.FoodLicNo).HasMaxLength(120);
            entity.Property(e => e.FserviceCharge).HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt).HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax).HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt).HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Gst).HasMaxLength(120);
            entity.Property(e => e.Gstno)
                .HasMaxLength(120)
                .HasColumnName("GSTNo");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LicenceNo).HasMaxLength(120);
            entity.Property(e => e.LserviceCharge).HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt).HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax).HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt).HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .HasColumnName("name");
            entity.Property(e => e.OrgPhone).HasMaxLength(120);
            entity.Property(e => e.PhoneNo).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.SalesBillPrint).HasMaxLength(120);
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.SubName).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit)
                .HasMaxLength(120)
                .HasColumnName("unit");
            entity.Property(e => e.User).HasMaxLength(120);
            entity.Property(e => e.Vat).HasMaxLength(120);
        });

        modelBuilder.Entity<SalesBillTemp>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("SalesBillTemp");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.DirectSbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("DirectSBillNo");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesDaily");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SalesDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesDiscount");

            entity.Property(e => e.SalesDiscount1)
                .HasDefaultValueSql("0")
                .HasColumnName("SalesDiscount");
        });

        modelBuilder.Entity<SalesItemSummeryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SalesItemSummeryReport");

            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<Salesbilldetail1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salesbilldetail1");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TransNo, "Pbillcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<Salesbilldetail1Modify>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salesbilldetail1Modify");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.TransNo, "Pbillcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Kotbot)
                .HasMaxLength(120)
                .HasColumnName("kotbot");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.UpdationSequence).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SectionMaster>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PrimaryKey");

            entity.ToTable("SectionMaster");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.SectionName).HasMaxLength(120);
        });

        modelBuilder.Entity<SectionWiseBillSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SectionWiseBillSummary");

            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.CreditCard).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.FoodBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Holdno)
                .HasDefaultValueSql("0")
                .HasColumnName("holdno");
            entity.Property(e => e.LiquerBillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerBillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasMaxLength(120);
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SectionWiseSale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SectionWiseServiceCharge>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("SectionWiseServiceCharge");

            entity.HasIndex(e => e.TransactionId, "Citycode");

            entity.HasIndex(e => e.LserviceCharge, "FServiceCharge");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.FserviceCharge, "Statecode");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FvatCst)
                .HasDefaultValueSql("0")
                .HasColumnName("FVatCST");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LvatCst)
                .HasDefaultValueSql("0")
                .HasColumnName("LVatCST");
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
        });

        modelBuilder.Entity<SessionMaster>(entity =>
        {
            entity.HasKey(e => e.SessionCode).HasName("PrimaryKey");

            entity.ToTable("SessionMaster");

            entity.HasIndex(e => e.SessionCode, "SectionID");

            entity.Property(e => e.SessionCode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasMaxLength(120);
        });

        modelBuilder.Entity<SessionWiseTodaysSalesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SessionWiseTodaysSalesReport");

            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<ShiftDefineDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShiftDefineDetail");

            entity.HasIndex(e => e.ShiftDefineId, "ShiftDefineID");

            entity.HasIndex(e => e.ShiftId, "ShiftID");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.ShiftDefineId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftDefineID");
            entity.Property(e => e.ShiftId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftID");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<ShiftDefineMaster>(entity =>
        {
            entity.HasKey(e => e.ShiftDefineId).HasName("PrimaryKey");

            entity.ToTable("ShiftDefineMaster");

            entity.HasIndex(e => e.ShiftDefineId, "ShiftDefineID");

            entity.Property(e => e.ShiftDefineId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftDefineID");
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<ShiftMaster>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PrimaryKey");

            entity.ToTable("ShiftMaster");

            entity.HasIndex(e => e.ShiftId, "ShiftID");

            entity.Property(e => e.ShiftId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftID");
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.FendTime).HasColumnName("FEndTime");
            entity.Property(e => e.FstartTime).HasColumnName("FStartTime");
            entity.Property(e => e.SendTime).HasColumnName("SEndTime");
            entity.Property(e => e.ShiftName).HasMaxLength(120);
            entity.Property(e => e.SstartTime).HasColumnName("SStartTime");
        });

        modelBuilder.Entity<ShortcutNameMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShortcutNameMaster");

            entity.HasIndex(e => e.MainId, "Citycode");

            entity.HasIndex(e => e.ShortCutKey, "HelpShortCutKey");

            entity.HasIndex(e => e.KeyCode, "KeyCode");

            entity.HasIndex(e => e.ShortcutName, "Statecode");

            entity.Property(e => e.MainId)
                .HasDefaultValueSql("0")
                .HasColumnName("MainID");
            entity.Property(e => e.RowHeight).HasDefaultValueSql("0");
            entity.Property(e => e.ShortCutKey).HasMaxLength(50);
            entity.Property(e => e.ShortcutName).HasMaxLength(120);
            entity.Property(e => e.ShortcutPresentIn).HasMaxLength(120);
            entity.Property(e => e.ShortcutType).HasMaxLength(120);
            entity.Property(e => e.Ttype)
                .HasMaxLength(120)
                .HasColumnName("TType");
        });

        modelBuilder.Entity<Smsapisetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSAPISetting");

            entity.HasIndex(e => e.Apicode, "APICode");

            entity.HasIndex(e => e.SenderId, "SenderID");

            entity.HasIndex(e => e.OwnerMobileNo, "SenderID1");

            entity.Property(e => e.Apicode).HasColumnName("APICode");
            entity.Property(e => e.Apiurl)
                .HasMaxLength(120)
                .HasColumnName("APIURL");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.OrgName).HasMaxLength(120);
            entity.Property(e => e.OwnerMobileNo).HasMaxLength(120);
            entity.Property(e => e.Password).HasMaxLength(120);
            entity.Property(e => e.SenderId)
                .HasMaxLength(120)
                .HasColumnName("SenderID");
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<SmsmessageMaster>(entity =>
        {
            entity.HasKey(e => e.SmsmessageCode).HasName("PrimaryKey");

            entity.ToTable("SMSMessageMaster");

            entity.HasIndex(e => e.SmsmessageCode, "Citycode");

            entity.Property(e => e.SmsmessageCode)
                .ValueGeneratedNever()
                .HasColumnName("SMSMessageCode");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.NoOfVariable).HasDefaultValueSql("0");
            entity.Property(e => e.SendTo).HasMaxLength(1);
            entity.Property(e => e.SmsmessageName).HasColumnName("SMSMessageName");
            entity.Property(e => e.Smstype)
                .HasMaxLength(255)
                .HasColumnName("SMSType");
        });

        modelBuilder.Entity<SmssendingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSSendingDetail");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.Ftype)
                .HasMaxLength(100)
                .HasColumnName("FType");
            entity.Property(e => e.MobileNo).HasMaxLength(120);
            entity.Property(e => e.SendFlag).HasMaxLength(1);
            entity.Property(e => e.SendTo).HasMaxLength(1);
            entity.Property(e => e.SmstextMsg).HasColumnName("SMSTextMsg");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<SnacksRateDiscountDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SnacksRateDiscountDefine");

            entity.Property(e => e.DiscountOnSnacksRate).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SoftwareRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoftwareRegistration");

            entity.Property(e => e.ErrorMessage).HasMaxLength(255);
            entity.Property(e => e.LockAllow).HasMaxLength(1);
            entity.Property(e => e.LockType).HasMaxLength(120);
        });

        modelBuilder.Entity<SoftwareSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoftwareSetting");

            entity.Property(e => e.Condition).HasMaxLength(120);
            entity.Property(e => e.ConditionData).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(120);
            entity.Property(e => e.UsedBy).HasMaxLength(120);
        });

        modelBuilder.Entity<SoftwareSettingCd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoftwareSettingCD");

            entity.Property(e => e.Condition).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(120);
        });

        modelBuilder.Entity<SpecialDishGroupMaster>(entity =>
        {
            entity.HasKey(e => e.SdgroupId).HasName("PrimaryKey");

            entity.ToTable("SpecialDishGroupMaster");

            entity.HasIndex(e => e.SdgroupId, "SDGroupID");

            entity.Property(e => e.SdgroupId)
                .ValueGeneratedNever()
                .HasColumnName("SDGroupID");
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.SdgroupName)
                .HasMaxLength(120)
                .HasColumnName("SDGroupName");
        });

        modelBuilder.Entity<SpecialDishItemMaster>(entity =>
        {
            entity.HasKey(e => e.Itemcode).HasName("PrimaryKey");

            entity.ToTable("SpecialDishItemMaster");

            entity.HasIndex(e => e.Itemcode, "SDGroupID");

            entity.Property(e => e.Itemcode).ValueGeneratedNever();
            entity.Property(e => e.SdgroupId).HasColumnName("SDGroupID");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.Statecode).HasName("PrimaryKey");

            entity.ToTable("StateMaster");

            entity.HasIndex(e => e.CountryCode, "CountryCode");

            entity.HasIndex(e => e.Statecode, "Statecode");

            entity.Property(e => e.Statecode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.StateName).HasMaxLength(120);
        });

        modelBuilder.Entity<StockConsumption>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("StockConsumption");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.TransactionId, "Pbillcode");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<StockConsumptionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockConsumptionDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.TransactionId, "Pbillcode");

            entity.HasIndex(e => e.Section1Qty, "Section1Qty");

            entity.HasIndex(e => e.Section2Qty, "Section2Qty");

            entity.HasIndex(e => e.Section3Qty, "Section3Qty");

            entity.HasIndex(e => e.Section4Qty, "Section4Qty");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Asales)
                .HasDefaultValueSql("0")
                .HasColumnName("ASales");
            entity.Property(e => e.Convertd).HasDefaultValueSql("0");
            entity.Property(e => e.Csales)
                .HasDefaultValueSql("0")
                .HasColumnName("CSales");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Sec1LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec1SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec2LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec2SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec3LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec3SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec4LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec4SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Section1Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section2Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section3Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section4Qty).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<StockConsumptionReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockConsumptionReport");

            entity.Property(e => e.Asales).HasColumnName("ASales");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<StockDeletedDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockDeletedDate");
        });

        modelBuilder.Entity<StockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.Property(e => e.Cancel).HasDefaultValueSql("0");
            entity.Property(e => e.Closing).HasDefaultValueSql("0");
            entity.Property(e => e.RawItemName).HasMaxLength(120);
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Sale).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<StockStatusBar>(entity =>
        {
            entity.HasKey(e => new { e.RawitemId, e.Unitcode, e.BarCounterId }).HasName("PrimaryKey");

            entity.ToTable("StockStatusBar");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<StockStatusStore>(entity =>
        {
            entity.HasKey(e => new { e.RawitemId, e.Unitcode }).HasName("PrimaryKey");

            entity.ToTable("StockStatusStore");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<StockVarifactionLooseReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockVarifactionLooseReport");

            entity.Property(e => e.ActualBalMl).HasColumnName("ActualBalML");
            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<StockVarifactionReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockVarifactionReport");

            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.RclooseBalQty).HasColumnName("RCLooseBalQty");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<SubTitle>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PrimaryKey");

            entity.ToTable("SubTitle");

            entity.HasIndex(e => e.MainId, "NewID");

            entity.HasIndex(e => e.SubId, "Traid");

            entity.Property(e => e.SubId)
                .HasDefaultValueSql("0")
                .HasColumnName("SubID");
            entity.Property(e => e.MainId)
                .HasDefaultValueSql("0")
                .HasColumnName("MainID");
            entity.Property(e => e.ModuleSetting).HasMaxLength(50);
            entity.Property(e => e.SrNo).HasDefaultValueSql("0");
            entity.Property(e => e.SubTitle1)
                .HasMaxLength(120)
                .HasColumnName("SubTitle");
        });

        modelBuilder.Entity<SubgroupMaster>(entity =>
        {
            entity.HasKey(e => e.SubGroupcode).HasName("PrimaryKey");

            entity.ToTable("SubgroupMaster");

            entity.HasIndex(e => e.SubGroupcode, "SubGroupcode");

            entity.Property(e => e.SubGroupcode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
        });

        modelBuilder.Entity<SupplierPaymentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SupplierPaymentDetail");

            entity.Property(e => e.Chequeno).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PaymentType).HasMaxLength(120);
            entity.Property(e => e.Ppno).HasColumnName("PPno");
        });

        modelBuilder.Entity<Supplierinfo>(entity =>
        {
            entity.HasKey(e => e.SupplierCode).HasName("PrimaryKey");

            entity.ToTable("Supplierinfo");

            entity.HasIndex(e => e.Citycode, "Citycode");

            entity.HasIndex(e => e.SupplierCode, "Customercode");

            entity.Property(e => e.SupplierCode).HasDefaultValueSql("0");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Citycode).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Fax).HasMaxLength(120);
            entity.Property(e => e.Gstno)
                .HasMaxLength(255)
                .HasDefaultValueSql("0")
                .HasColumnName("GSTNo");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.Remark).HasMaxLength(255);
        });

        modelBuilder.Entity<TableMaster>(entity =>
        {
            entity.HasKey(e => e.TableNo).HasName("PrimaryKey");

            entity.ToTable("TableMaster");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.DeleteFlag).HasMaxLength(1);
            entity.Property(e => e.Description).HasMaxLength(120);
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
        });

        modelBuilder.Entity<TableName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableName");

            entity.HasIndex(e => e.BarCounterId, "BarCounterID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.SequenceNo, "SectionID1");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.Atype)
                .HasMaxLength(1)
                .HasColumnName("AType");
            entity.Property(e => e.BarCounterId)
                .HasDefaultValueSql("0")
                .HasColumnName("BarCounterID");
            entity.Property(e => e.Ota).HasColumnName("OTA");
            entity.Property(e => e.ParcelTable).HasMaxLength(1);
            entity.Property(e => e.SaleBillPrintAllow).HasMaxLength(1);
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.SelfService).HasMaxLength(1);
            entity.Property(e => e.SequenceNo).HasDefaultValueSql("0");
            entity.Property(e => e.TableId)
                .HasDefaultValueSql("0")
                .HasColumnName("TableID");
            entity.Property(e => e.TableName1)
                .HasMaxLength(4)
                .HasColumnName("TableName");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TableRotaion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableRotaion");

            entity.Property(e => e.Billamt).HasDefaultValueSql("0");
            entity.Property(e => e.ConsumeTime).HasMaxLength(120);
            entity.Property(e => e.EndTime).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TableSummaryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableSummaryReport");

            entity.Property(e => e.TableName).HasMaxLength(120);
        });

        modelBuilder.Entity<TasteMaster>(entity =>
        {
            entity.HasKey(e => e.TasteId).HasName("PrimaryKey");

            entity.ToTable("TasteMaster");

            entity.HasIndex(e => e.TasteId, "TasteID");

            entity.Property(e => e.TasteId)
                .HasDefaultValueSql("0")
                .HasColumnName("TasteID");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.TasteName).HasMaxLength(120);
        });

        modelBuilder.Entity<TaxTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaxTable");

            entity.Property(e => e.FoodTax).HasDefaultValueSql("0");
            entity.Property(e => e.SoftDrink).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempBulkInLitterWithMrp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempBulkInLitterWithMRP");

            entity.Property(e => e.BeerMrpamt).HasColumnName("BeerMRPAmt");
            entity.Property(e => e.CountryMrpamt).HasColumnName("CountryMRPAmt");
            entity.Property(e => e.ExciseLicNo).HasMaxLength(120);
            entity.Property(e => e.ImflbulkInLtr).HasColumnName("IMFLBulkInLtr");
            entity.Property(e => e.Imflmrpamt).HasColumnName("IMFLMRPAmt");
            entity.Property(e => e.NameAddress).HasMaxLength(255);
            entity.Property(e => e.WineMrpamt).HasColumnName("WineMRPAmt");
        });

        modelBuilder.Entity<TempBulkInLtr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempBulkInLtr");

            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TempConsumeCoupanDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempConsumeCoupanDetail");

            entity.HasIndex(e => e.SessionName, "CaptainCode");

            entity.HasIndex(e => e.CustomerName, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.CoupanNo, "SessionName");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.CustomerName).HasMaxLength(120);
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.SessionName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.TransNo).HasDefaultValueSql("0");
            entity.Property(e => e.UsedCoupan).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempCreditorDetailYc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempCreditorDetailYC");

            entity.HasIndex(e => e.CreditorId, "CreditorID");

            entity.Property(e => e.CreditorId).HasColumnName("CreditorID");
            entity.Property(e => e.CreditorName).HasMaxLength(255);
        });

        modelBuilder.Entity<TempCurrentStockAverageRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempCurrentStockAverageRate");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.Property(e => e.AvgRate).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingQty).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingRate).HasDefaultValueSql("0");
            entity.Property(e => e.IssueQty).HasDefaultValueSql("0");
            entity.Property(e => e.IssueRate).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningQty).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningRate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.ReceiveQty).HasDefaultValueSql("0");
            entity.Property(e => e.ReceiveRate).HasDefaultValueSql("0");
            entity.Property(e => e.TotalQty).HasDefaultValueSql("0");
            entity.Property(e => e.TotalRate).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempCustomerConsumeCoupan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempCustomerConsumeCoupan");

            entity.HasIndex(e => e.CoupanQty, "CoupanQty");

            entity.HasIndex(e => e.CoupanId, "Unitcode");

            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
        });

        modelBuilder.Entity<TempCustomerInfo>(entity =>
        {
            entity.HasKey(e => e.Customercode).HasName("PrimaryKey");

            entity.ToTable("TempCustomerInfo");

            entity.HasIndex(e => e.Citycode, "Citycode");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.UseCustcode, "UseCustcode");

            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.Citycode).HasDefaultValueSql("0");
            entity.Property(e => e.CustomerType).HasMaxLength(1);
            entity.Property(e => e.Deleteflag)
                .HasMaxLength(1)
                .HasColumnName("deleteflag");
            entity.Property(e => e.DiscountFood).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountLiquer).HasDefaultValueSql("0");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.FavouriteDish).HasMaxLength(120);
            entity.Property(e => e.Fax).HasMaxLength(120);
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Lodgin).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.PaymentMode).HasMaxLength(120);
            entity.Property(e => e.PermitNo).HasMaxLength(120);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.Photpath).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SaleQtyInMl).HasDefaultValueSql("0");
            entity.Property(e => e.UseCustcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempDataTablesQuery>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PrimaryKey");

            entity.ToTable("TempDataTablesQuery");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.DeleteFlag).HasMaxLength(255);
        });

        modelBuilder.Entity<TempDeptWiseCounterCashier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempDeptWiseCounterCashier");

            entity.Property(e => e.DepertmentName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TempEmpAdvanceBal>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PrimaryKey");

            entity.ToTable("TempEmpAdvanceBal");

            entity.Property(e => e.Empno).ValueGeneratedNever();
        });

        modelBuilder.Entity<TempExpensesAndPurPaymentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempExpensesAndPurPaymentDetail");

            entity.HasIndex(e => e.PaymentBankName, "PaymentBankCode");

            entity.Property(e => e.ExpGroupName).HasMaxLength(255);
            entity.Property(e => e.ExpItemDescription).HasMaxLength(255);
            entity.Property(e => e.Particular).HasMaxLength(255);
            entity.Property(e => e.PaymentChqNo).HasMaxLength(255);
            entity.Property(e => e.PaymentPbillNo).HasColumnName("PaymentPBillNo");
            entity.Property(e => e.PaymentRemark).HasMaxLength(255);
            entity.Property(e => e.PaymentType).HasMaxLength(255);
            entity.Property(e => e.Ppno).HasColumnName("PPNo");
            entity.Property(e => e.TransactionType).HasMaxLength(255);
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<TempExportOpening>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempExportOpening");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.RawItem).HasMaxLength(255);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<TempFoodStockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempFoodStockDetail");

            entity.HasIndex(e => e.RawitemId, "RawItemCode");

            entity.Property(e => e.ComputerC).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningBalance).HasDefaultValueSql("0");
            entity.Property(e => e.Preturn)
                .HasDefaultValueSql("0")
                .HasColumnName("PReturn");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.StockC).HasDefaultValueSql("0");
            entity.Property(e => e.Wastage).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempFoodStockSettingReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempFoodStockSettingReport");

            entity.HasIndex(e => e.RawItemCode, "RawItemCode");

            entity.Property(e => e.ClosingStock).HasDefaultValueSql("0");
            entity.Property(e => e.ComputerC).HasDefaultValueSql("0");
            entity.Property(e => e.Different).HasDefaultValueSql("0");
            entity.Property(e => e.OpeningBalance).HasDefaultValueSql("0");
            entity.Property(e => e.Preturn)
                .HasDefaultValueSql("0")
                .HasColumnName("PReturn");
            entity.Property(e => e.RawItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.RawName).HasMaxLength(120);
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(120);
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.StockC).HasDefaultValueSql("0");
            entity.Property(e => e.Wastage).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempGrossProfit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempGrossProfit");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.ItemName).HasMaxLength(255);
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TempGstdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempGSTDetail");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.Property(e => e.BillType).HasMaxLength(255);
            entity.Property(e => e.Gst)
                .HasMaxLength(255)
                .HasColumnName("GST");
            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.Gstrate).HasColumnName("GSTRate");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TempGstrate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempGSTRate");

            entity.HasIndex(e => e.TableId, "TableID");

            entity.Property(e => e.Gstamt).HasColumnName("GSTAmt");
            entity.Property(e => e.TableId).HasColumnName("TableID");
        });

        modelBuilder.Entity<TempIssueToBarDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempIssueToBarDetail");

            entity.Property(e => e.BarCounterId).HasColumnName("BarCounterID");
            entity.Property(e => e.BarCounterName).HasMaxLength(255);
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.IssueId).HasColumnName("IssueID");
            entity.Property(e => e.RawItem).HasMaxLength(255);
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<TempItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemDetail");

            entity.HasIndex(e => e.Barcode, "Barcode");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.Itemcode, "RawitemID");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempItemDetailRaw>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemDetailRaw");

            entity.HasIndex(e => e.Barcode, "Barcode");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.Itemcode, "RawitemID");

            entity.HasIndex(e => e.SectionId, "SectionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("0")
                .HasColumnName("MRP");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.SectionId)
                .HasDefaultValueSql("0")
                .HasColumnName("SectionID");
            entity.Property(e => e.Snacks).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempItemGroupWiseDailySale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ItemCode, "ItemCode");

            entity.HasIndex(e => e.ItemGroupCode, "ItemGroupCode");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.ItemGroupCode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.UnitCode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemMaster");

            entity.HasIndex(e => e.ItemId, "ItemId");

            entity.HasIndex(e => e.LiquorTypeId, "LiquorId");

            entity.Property(e => e.LiquorTypeId).HasColumnName("LiquorTypeID");
        });

        modelBuilder.Entity<TempItemRateDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemRateDefine");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempItemWiseSalesWithMrprate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemWiseSalesWithMRPRate");

            entity.HasIndex(e => e.Itemcode, "RawitemID");

            entity.HasIndex(e => e.SubGroupcode, "SectionID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.SectionName).HasMaxLength(255);
            entity.Property(e => e.SubGroupcode).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempItemwiseTransReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempItemwiseTransReport");

            entity.HasIndex(e => e.PbillCode, "PBillCode");

            entity.HasIndex(e => e.SbillCode, "SBillCode");

            entity.Property(e => e.PbillCode)
                .HasDefaultValueSql("0")
                .HasColumnName("PBillCode");
            entity.Property(e => e.Porder)
                .HasDefaultValueSql("0")
                .HasColumnName("POrder");
            entity.Property(e => e.Punit)
                .HasMaxLength(120)
                .HasColumnName("PUnit");
            entity.Property(e => e.SbillCode)
                .HasDefaultValueSql("0")
                .HasColumnName("SBillCode");
            entity.Property(e => e.Sorder).HasDefaultValueSql("0");
            entity.Property(e => e.StransNo)
                .HasDefaultValueSql("0")
                .HasColumnName("STransNo");
            entity.Property(e => e.Sunit)
                .HasMaxLength(120)
                .HasColumnName("SUnit");
        });

        modelBuilder.Entity<TempLiquorItemStockLedgerReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempLiquorItemStockLedgerReport");

            entity.HasIndex(e => e.BillId, "BillID");

            entity.HasIndex(e => e.RawitemId, "RawItemID");

            entity.HasIndex(e => e.UnitCode, "UnitCode");

            entity.Property(e => e.BillId)
                .HasDefaultValueSql("0")
                .HasColumnName("BillID");
            entity.Property(e => e.DataPrint).HasMaxLength(50);
            entity.Property(e => e.Excise).HasDefaultValueSql("0");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Type).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<TempMonthlyStockValuation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempMonthlyStockValuation");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Closing).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("0")
                .HasColumnName("MRP");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.SalesRateAmount).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempOnlineExUnitWiseOpening>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempOnlineExUnitWiseOpening");

            entity.HasIndex(e => e.ExciseGroupId, "ExciseGroupId");

            entity.HasIndex(e => e.ExciseItemCode, "ExciseItemCode");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.RawItem).HasMaxLength(255);
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<TempOpeningStockDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempOpeningStockDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.BatchNo).HasMaxLength(120);
            entity.Property(e => e.BeerMfgdate).HasColumnName("BeerMFGDate");
            entity.Property(e => e.BottleQty).HasDefaultValueSql("0");
            entity.Property(e => e.CaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.LooseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Mrp).HasColumnName("MRP");
            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.UnitCaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempPresentyDefine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempPresentyDefine");

            entity.HasIndex(e => e.InDate2, "InDate1");

            entity.HasIndex(e => e.InDate1, "MainID");

            entity.HasIndex(e => e.ShiftId, "ShiftID");

            entity.HasIndex(e => e.Empno, "Usercode");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.OutDate1).HasColumnName("outDate1");
            entity.Property(e => e.OutDate2).HasColumnName("outDate2");
            entity.Property(e => e.ShiftId)
                .HasDefaultValueSql("0")
                .HasColumnName("ShiftID");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempPresentyDownload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempPresentyDownload");

            entity.HasIndex(e => e.TdateTime, "MainID");

            entity.HasIndex(e => e.Empno, "Usercode");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.TdateTime).HasColumnName("TDateTime");
            entity.Property(e => e.UseFlag).HasMaxLength(1);
        });

        modelBuilder.Entity<TempPresentyDownloadDatum>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.TdateTime, "MainID");

            entity.HasIndex(e => e.Empno, "Usercode");

            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.TdateTime).HasColumnName("TDateTime");
        });

        modelBuilder.Entity<TempPurchaseRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempPurchaseRate");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempRawItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempRawItem");

            entity.HasIndex(e => e.LiquorTypeId, "LiquorId");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.Property(e => e.LiquorTypeId).HasColumnName("LiquorTypeID");
            entity.Property(e => e.RawitemId).HasColumnName("RawitemID");
        });

        modelBuilder.Entity<TempRawItemConsumption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempRawItemConsumption");

            entity.HasIndex(e => e.DepartmentCode, "DepartmentCode");

            entity.HasIndex(e => e.Tdate, "TDate");

            entity.Property(e => e.Department).HasMaxLength(120);
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<TempSalesBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempSalesBill");

            entity.Property(e => e.ActualBill).HasDefaultValueSql("0");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.FoodAmt).HasDefaultValueSql("0");
            entity.Property(e => e.LiquerAmt).HasDefaultValueSql("0");
            entity.Property(e => e.NetAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Salesbillno).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempSb>(entity =>
        {
            entity.HasKey(e => new { e.Pbillcode, e.Tdate, e.BillType }).HasName("PrimaryKey");

            entity.ToTable("TempSB");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.CoupanId, "CoupanID");

            entity.HasIndex(e => e.Customercode, "Customercode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CaptainCode).HasDefaultValueSql("0");
            entity.Property(e => e.CoupanId)
                .HasDefaultValueSql("0")
                .HasColumnName("CoupanID");
            entity.Property(e => e.CoupanId1).HasColumnName("CoupanID1");
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Customercode).HasDefaultValueSql("0");
            entity.Property(e => e.DirectSbillNo)
                .HasDefaultValueSql("0")
                .HasColumnName("DirectSBillNo");
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.FserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceCharge");
            entity.Property(e => e.FserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceChargeAmt");
            entity.Property(e => e.FserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTax");
            entity.Property(e => e.FserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("FServiceTaxAmt");
            entity.Property(e => e.Fvat).HasDefaultValueSql("0");
            entity.Property(e => e.FvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.LserviceCharge)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceCharge");
            entity.Property(e => e.LserviceChargeAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceChargeAmt");
            entity.Property(e => e.LserviceTax)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTax");
            entity.Property(e => e.LserviceTaxAmt)
                .HasDefaultValueSql("0")
                .HasColumnName("LServiceTaxAmt");
            entity.Property(e => e.Lvat).HasDefaultValueSql("0");
            entity.Property(e => e.LvatAmount).HasDefaultValueSql("0");
            entity.Property(e => e.Persons).HasDefaultValueSql("0");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RoundOff).HasDefaultValueSql("0");
            entity.Property(e => e.SectionName).HasMaxLength(120);
            entity.Property(e => e.TableNo).HasDefaultValueSql("0");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempSbdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempSBDetail");

            entity.HasIndex(e => e.ConvertUnitCode, "ConvertUnitCode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Pbillcode, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode1");

            entity.Property(e => e.ActualRate).HasDefaultValueSql("0");
            entity.Property(e => e.Billtype)
                .HasMaxLength(120)
                .HasColumnName("billtype");
            entity.Property(e => e.Gstrate)
                .HasDefaultValueSql("0")
                .HasColumnName("GSTRate");
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.Kotmsg)
                .HasMaxLength(255)
                .HasColumnName("KOTMsg");
            entity.Property(e => e.Order).HasDefaultValueSql("0");
            entity.Property(e => e.Pbillcode).HasDefaultValueSql("0");
            entity.Property(e => e.Rate).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Srno).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempSessionWiseTodaySale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CoupanNo, "CoupanNo");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.SessionCode, "Itemcode1");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CoupanNo).HasMaxLength(120);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.SalesPrice).HasDefaultValueSql("0");
            entity.Property(e => e.SalesQty).HasDefaultValueSql("0");
            entity.Property(e => e.SessionCode).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksPrice).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockConsumption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockConsumption");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Section1Qty, "Section1Qty");

            entity.HasIndex(e => e.Section2Qty, "Section2Qty");

            entity.HasIndex(e => e.Section3Qty, "Section3Qty");

            entity.HasIndex(e => e.Section4Qty, "Section4Qty");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Asales)
                .HasDefaultValueSql("0")
                .HasColumnName("ASales");
            entity.Property(e => e.Convertd).HasDefaultValueSql("0");
            entity.Property(e => e.Csales)
                .HasDefaultValueSql("0")
                .HasColumnName("CSales");
            entity.Property(e => e.LiquerRate).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.PurchaseRate).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Sec1LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec1SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec2LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec2SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec3LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec3SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec4LiquorRate).HasDefaultValueSql("0");
            entity.Property(e => e.Sec4SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Section1Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section2Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section3Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section4Qty).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksRate).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockConsumptionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockConsumptionDetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Section1Qty, "Section1Qty");

            entity.HasIndex(e => e.Section2Qty, "Section2Qty");

            entity.HasIndex(e => e.Section3Qty, "Section3Qty");

            entity.HasIndex(e => e.Section4Qty, "Section4Qty");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Asales)
                .HasDefaultValueSql("0")
                .HasColumnName("ASales");
            entity.Property(e => e.Convertd).HasDefaultValueSql("0");
            entity.Property(e => e.Csales).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Section1Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section2Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section3Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Section4Qty).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockConsumptionReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockConsumptionReport");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Asales)
                .HasDefaultValueSql("0")
                .HasColumnName("ASales");
            entity.Property(e => e.Convertd).HasDefaultValueSql("0");
            entity.Property(e => e.Csales).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Receipt).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockStatus");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockVarifaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockVarifaction");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CurrLooseQty).HasDefaultValueSql("0");
            entity.Property(e => e.CurrPackQty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.RclooseBalQty).HasColumnName("RCLooseBalQty");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempStockVarifactionLoose>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStockVarifactionLoose");

            entity.HasIndex(e => e.RawitemId, "RawitemID");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ActualBalMl)
                .HasDefaultValueSql("0")
                .HasColumnName("ActualBalML");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.TotalConvert).HasDefaultValueSql("0");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempTableRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempTableRoom");

            entity.Property(e => e.RoomName).HasMaxLength(255);
            entity.Property(e => e.TableId).HasColumnName("TableID");
            entity.Property(e => e.TableName).HasMaxLength(255);
        });

        modelBuilder.Entity<TempTodaysProdCost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempTodaysProdCost");

            entity.HasIndex(e => e.Itemcode, "itemcode");

            entity.Property(e => e.ItemName).HasMaxLength(255);
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
        });

        modelBuilder.Entity<TempcounCasess1MonthlyReport>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("TempcounCasess1MonthlyReport");

            entity.HasIndex(e => e.BankCode, "BankCode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Bar).HasDefaultValueSql("0");
            entity.Property(e => e.Beer).HasDefaultValueSql("0");
            entity.Property(e => e.Cigarette).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.DepositAmt).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCash).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCheque).HasDefaultValueSql("0");
            entity.Property(e => e.DepositName).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Expenses).HasDefaultValueSql("0");
            entity.Property(e => e.Food).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.OtherDeposit).HasDefaultValueSql("0");
            entity.Property(e => e.PurchasePayment).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceCharge).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceTax).HasDefaultValueSql("0");
            entity.Property(e => e.Softdrink)
                .HasDefaultValueSql("0")
                .HasColumnName("softdrink");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Vat).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TempmissingKotBot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempmissingKotBot");

            entity.Property(e => e.BotNo).HasDefaultValueSql("0");
            entity.Property(e => e.KotNo).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<Tmpclp140231>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("~TMPCLP140231");

            entity.HasIndex(e => e.BankCode, "BankCode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Bar).HasDefaultValueSql("0");
            entity.Property(e => e.Beer).HasDefaultValueSql("0");
            entity.Property(e => e.Cigarette).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.DepositAmt).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCash).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCheque).HasDefaultValueSql("0");
            entity.Property(e => e.DepositName).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Expenses).HasDefaultValueSql("0");
            entity.Property(e => e.Food).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.OtherDeposit).HasDefaultValueSql("0");
            entity.Property(e => e.PurchasePayment).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceCharge).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceTax).HasDefaultValueSql("0");
            entity.Property(e => e.Softdrink)
                .HasDefaultValueSql("0")
                .HasColumnName("softdrink");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Vat).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<Tmpclp376191>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PrimaryKey");

            entity.ToTable("~TMPCLP376191");

            entity.HasIndex(e => e.BankCode, "BankCode");

            entity.HasIndex(e => e.TransactionId, "TransactionID");

            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("0")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Advance).HasDefaultValueSql("0");
            entity.Property(e => e.BankCode).HasDefaultValueSql("0");
            entity.Property(e => e.Bar).HasDefaultValueSql("0");
            entity.Property(e => e.Beer).HasDefaultValueSql("0");
            entity.Property(e => e.Cigarette).HasDefaultValueSql("0");
            entity.Property(e => e.ClosingAmt).HasDefaultValueSql("0");
            entity.Property(e => e.Credit).HasDefaultValueSql("0");
            entity.Property(e => e.DepositAmt).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCash).HasDefaultValueSql("0");
            entity.Property(e => e.DepositCheque).HasDefaultValueSql("0");
            entity.Property(e => e.DepositName).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.Expenses).HasDefaultValueSql("0");
            entity.Property(e => e.Food).HasDefaultValueSql("0");
            entity.Property(e => e.Lodging).HasDefaultValueSql("0");
            entity.Property(e => e.Opening).HasDefaultValueSql("0");
            entity.Property(e => e.OtherDeposit).HasDefaultValueSql("0");
            entity.Property(e => e.PurchasePayment).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceCharge).HasDefaultValueSql("0");
            entity.Property(e => e.ServiceTax).HasDefaultValueSql("0");
            entity.Property(e => e.Softdrink)
                .HasDefaultValueSql("0")
                .HasColumnName("softdrink");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Vat).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TodayDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TodayDiscount");

            entity.HasIndex(e => e.CustName, "CustomerCode");

            entity.Property(e => e.BillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasDefaultValueSql("0");
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CardNo).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Discount).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountPer).HasDefaultValueSql("0");
            entity.Property(e => e.DiscountType).HasMaxLength(120);
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("tdate");
        });

        modelBuilder.Entity<TodaySDiscountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Today'sDiscountDetail");

            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.CustName).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<TodaySale>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.SalesPrice).HasDefaultValueSql("0");
            entity.Property(e => e.SalesQty).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksPrice).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TodaySalesItemWiseCaptain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TodaySalesItemWiseCaptain");

            entity.HasIndex(e => e.CaptainCode, "CaptainCode");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CaptainName).HasMaxLength(255);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.Itemcode).HasDefaultValueSql("0");
            entity.Property(e => e.SalesPrice).HasDefaultValueSql("0");
            entity.Property(e => e.SalesQty).HasDefaultValueSql("0");
            entity.Property(e => e.SnacksPrice).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TodaySalesItemWiseCaptainReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TodaySalesItemWiseCaptainReport");

            entity.Property(e => e.CaptainName).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TodaySalesReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TodaySalesReport");

            entity.Property(e => e.GroupName).HasMaxLength(120);
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.SubGroup).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(120);
        });

        modelBuilder.Entity<TodaySalesReportTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TodaySalesReportTemp");

            entity.HasIndex(e => e.ItemId, "ItemID");

            entity.HasIndex(e => e.Itemcode, "Itemcode");

            entity.HasIndex(e => e.Rawitemcode, "Rawitemcode");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(255);
            entity.Property(e => e.SubGroup).HasMaxLength(255);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<TodaysParcelDeliveryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TodaysParcelDeliveryReport");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BillType).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.ParcelTable).HasMaxLength(1);
            entity.Property(e => e.Phone).HasMaxLength(120);
            entity.Property(e => e.Tdate).HasColumnName("TDate");
        });

        modelBuilder.Entity<TotalLiquorConsumption>(entity =>
        {
            entity.HasKey(e => new { e.ItemCode, e.UnitName }).HasName("PrimaryKey");

            entity.ToTable("TotalLiquorConsumption");

            entity.HasIndex(e => e.ItemCode, "RawitemID");

            entity.Property(e => e.ItemCode).HasDefaultValueSql("0");
            entity.Property(e => e.UnitName).HasMaxLength(120);
            entity.Property(e => e.RawItem).HasMaxLength(120);
            entity.Property(e => e.TotalQty).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<TouchScreenMainGroupMaster>(entity =>
        {
            entity.HasKey(e => e.TsmainGroupcode).HasName("PrimaryKey");

            entity.ToTable("TouchScreenMainGroupMaster");

            entity.HasIndex(e => e.TsmainGroupcode, "SubGroupcode");

            entity.Property(e => e.TsmainGroupcode)
                .HasDefaultValueSql("0")
                .HasColumnName("TSMainGroupcode");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.TsmainGroup)
                .HasMaxLength(120)
                .HasColumnName("TSMainGroup");
        });

        modelBuilder.Entity<TouchScreenSubGroupMaster>(entity =>
        {
            entity.HasKey(e => e.TssubGroupcode).HasName("PrimaryKey");

            entity.ToTable("TouchScreenSubGroupMaster");

            entity.HasIndex(e => e.TssubGroupcode, "SubGroupcode");

            entity.Property(e => e.TssubGroupcode)
                .HasDefaultValueSql("0")
                .HasColumnName("TSSubGroupcode");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.SequenceTs)
                .HasDefaultValueSql("0")
                .HasColumnName("SequenceTS");
            entity.Property(e => e.TssubGroup)
                .HasMaxLength(120)
                .HasColumnName("TSSubGroup");
        });

        modelBuilder.Entity<Transactiondate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Transactiondate");
        });

        modelBuilder.Entity<UnitMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UnitMaster");

            entity.HasIndex(e => e.Unitcode, "Unitcode");

            entity.Property(e => e.CaseQty).HasDefaultValueSql("0");
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.LiquorType).HasMaxLength(120);
            entity.Property(e => e.Ml)
                .HasDefaultValueSql("0")
                .HasColumnName("ML");
            entity.Property(e => e.PackingType).HasMaxLength(120);
            entity.Property(e => e.SequenceNo).HasDefaultValueSql("0");
            entity.Property(e => e.Unit).HasMaxLength(120);
            entity.Property(e => e.UnitType).HasMaxLength(1);
            entity.Property(e => e.Unitcode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<UnitWiseSale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SaleQty).HasDefaultValueSql("0");
            entity.Property(e => e.UnitName).HasMaxLength(120);
        });

        modelBuilder.Entity<UpdationFlag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UpdationFlag");

            entity.Property(e => e.CaptainPadFlag).HasMaxLength(120);
            entity.Property(e => e.CashMemoGeneration).HasMaxLength(255);
            entity.Property(e => e.CounterCashier).HasMaxLength(120);
            entity.Property(e => e.DataSendSecondDefine).HasMaxLength(120);
            entity.Property(e => e.FoodStockSetting).HasMaxLength(120);
            entity.Property(e => e.OpeningStockFlag).HasMaxLength(120);
            entity.Property(e => e.PhysicalLiquor).HasMaxLength(120);
            entity.Property(e => e.TempDbcreateFlag)
                .HasMaxLength(255)
                .HasColumnName("TempDBCreateFlag");
            entity.Property(e => e.TotalBackupFlag).HasMaxLength(120);
        });

        modelBuilder.Entity<UserDefineAlert>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PrimaryKey");

            entity.ToTable("UserDefineAlert");

            entity.HasIndex(e => e.Tid, "Bankcode");

            entity.Property(e => e.Tid).HasDefaultValueSql("0");
            entity.Property(e => e.AlertSubject).HasMaxLength(255);
            entity.Property(e => e.Deleteflag).HasMaxLength(1);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserDetail");

            entity.HasIndex(e => e.MainId, "MainID");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.MainId)
                .HasMaxLength(120)
                .HasColumnName("MainID");
            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<UserMaster>(entity =>
        {
            entity.HasKey(e => e.Usercode).HasName("PrimaryKey");

            entity.ToTable("UserMaster");

            entity.HasIndex(e => e.Usercode, "Usercode");

            entity.Property(e => e.Usercode).HasDefaultValueSql("0");
            entity.Property(e => e.AllowCancelItem).HasDefaultValueSql("0");
            entity.Property(e => e.AllowDiscount).HasDefaultValueSql("0");
            entity.Property(e => e.AllowTaxation).HasDefaultValueSql("0");
            entity.Property(e => e.BillKot)
                .HasMaxLength(120)
                .HasColumnName("BillKOT");
            entity.Property(e => e.BillSettelmentPassword).HasMaxLength(255);
            entity.Property(e => e.CancelItemPassword).HasMaxLength(20);
            entity.Property(e => e.Fydisplay)
                .HasMaxLength(120)
                .HasColumnName("FYDisplay");
            entity.Property(e => e.KotprintingPassword)
                .HasMaxLength(50)
                .HasColumnName("KOTPrintingPassword");
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.SalesBillModifyPassword).HasMaxLength(20);
            entity.Property(e => e.ShowTotalSalesAmt).HasDefaultValueSql("0");
            entity.Property(e => e.StockDeletePassword).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(120);
        });

        modelBuilder.Entity<UserWiseBillDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserWiseBillDetail");

            entity.Property(e => e.BillAmt).HasDefaultValueSql("0");
            entity.Property(e => e.BillNo).HasDefaultValueSql("0");
            entity.Property(e => e.Tdate).HasColumnName("TDate");
            entity.Property(e => e.UserName).HasMaxLength(120);
        });

        modelBuilder.Entity<Wastage>(entity =>
        {
            entity.HasKey(e => e.WastageId).HasName("PrimaryKey");

            entity.ToTable("Wastage");

            entity.HasIndex(e => e.Idate, "IDate");

            entity.HasIndex(e => e.WastageId, "Pbillcode");

            entity.HasIndex(e => e.Empno, "Suppliercode");

            entity.Property(e => e.WastageId)
                .HasDefaultValueSql("0")
                .HasColumnName("WastageID");
            entity.Property(e => e.Empno).HasDefaultValueSql("0");
            entity.Property(e => e.Idate).HasColumnName("IDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StockType).HasMaxLength(1);
        });

        modelBuilder.Entity<Wastagedetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Wastagedetail");

            entity.HasIndex(e => e.RawitemId, "Itemcode");

            entity.HasIndex(e => e.WastageId, "Pbillcode");

            entity.HasIndex(e => e.Unitcode, "unitcode");

            entity.Property(e => e.Qty).HasDefaultValueSql("0");
            entity.Property(e => e.RawitemId)
                .HasDefaultValueSql("0")
                .HasColumnName("RawitemID");
            entity.Property(e => e.Srno)
                .HasDefaultValueSql("0")
                .HasColumnName("srno");
            entity.Property(e => e.Unitcode)
                .HasDefaultValueSql("0")
                .HasColumnName("unitcode");
            entity.Property(e => e.WastageId)
                .HasDefaultValueSql("0")
                .HasColumnName("WastageID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
