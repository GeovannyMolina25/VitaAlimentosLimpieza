using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class VendTable
    {
        public string Accountnum { get; set; } = null!;
        public string Invoiceaccount { get; set; } = null!;
        public string Vendgroup { get; set; } = null!;
        public string Paymtermid { get; set; } = null!;
        public string Cashdisc { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public string Linedisc { get; set; } = null!;
        public string Enterprisenumber { get; set; } = null!;
        public int Blocked { get; set; }
        public int Onetimevendor { get; set; }
        public string Pricegroup { get; set; } = null!;
        public string Multilinedisc { get; set; } = null!;
        public string Enddisc { get; set; } = null!;
        public string Paymid { get; set; } = null!;
        public string Vatnum { get; set; } = null!;
        public string Inventlocation { get; set; } = null!;
        public string Youraccountnum { get; set; } = null!;
        public string Dlvterm { get; set; } = null!;
        public string Dlvmode { get; set; } = null!;
        public string Bankaccount { get; set; } = null!;
        public string Paymmode { get; set; } = null!;
        public string Paymspec { get; set; } = null!;
        public string Markupgroup { get; set; } = null!;
        public string Clearingperiod { get; set; } = null!;
        public string Companyidsiret { get; set; } = null!;
        public string Taxgroup { get; set; } = null!;
        public string Freightzone { get; set; } = null!;
        public int Minorityowned { get; set; }
        public int Femaleowned { get; set; }
        public string Creditrating { get; set; } = null!;
        public decimal Creditmax { get; set; }
        public int Tax1099reports { get; set; }
        public string Tax1099regnum { get; set; } = null!;
        public string Paymsched { get; set; } = null!;
        public string Itembuyergroupid { get; set; } = null!;
        public string Contactpersonid { get; set; } = null!;
        public string Purchpoolid { get; set; } = null!;
        public int Purchamountpurchaseorder { get; set; }
        public int Incltax { get; set; }
        public string Venditemgroupid { get; set; } = null!;
        public string Numbersequencegroup { get; set; } = null!;
        public string Paymdayid { get; set; } = null!;
        public string Destinationcodeid { get; set; } = null!;
        public string Lineofbusinessid { get; set; } = null!;
        public string Suppitemgroupid { get; set; } = null!;
        public string Bankcentralbankpurposetext { get; set; } = null!;
        public string Bankcentralbankpurposecode { get; set; } = null!;
        public int Offsetaccounttype { get; set; }
        public string Purchcalendarid { get; set; } = null!;
        public string Organizationnumber { get; set; } = null!;
        public string Fiscalcode { get; set; } = null!;
        public int Taxwithholdcalculate { get; set; }
        public string Taxwithholdgroup { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public string Birthplace { get; set; } = null!;
        public string Residenceforeigncountryregionid { get; set; } = null!;
        public string Namecontrol { get; set; } = null!;
        public int Foreignentityindicator { get; set; }
        public int Taxidtype { get; set; }
        public string Dba { get; set; } = null!;
        public int Tax1099namechoice { get; set; }
        public int Secondtin { get; set; }
        public string Inventsiteid { get; set; } = null!;
        public string Segmentid { get; set; } = null!;
        public string Subsegmentid { get; set; } = null!;
        public string Companychainid { get; set; } = null!;
        public string Vendpricetolerancegroupid { get; set; } = null!;
        public string? Memo { get; set; }
        public int Smallbusiness { get; set; }
        public int Locallyowned { get; set; }
        public int Bidonly { get; set; }
        public int W9 { get; set; }
        public string Orgid { get; set; } = null!;
        public string Factoringaccount { get; set; } = null!;
        public int Matchingpolicy { get; set; }
        public DateTime Blockedreleasedate { get; set; }
        public int Blockedreleasedatetzid { get; set; }
        public int W9included { get; set; }
        public long Vendexceptiongroup { get; set; }
        public long Party { get; set; }
        public long Defaultdimension { get; set; }
        public long Offsetledgerdimension { get; set; }
        public string BirthcountycodeIt { get; set; } = null!;
        public int HeirIt { get; set; }
        public int Changerequestenabled { get; set; }
        public int Changerequestallowoverride { get; set; }
        public int Changerequestoverride { get; set; }
        public long Companynafcode { get; set; }
        public long VendinvoicedeclarationIs { get; set; }
        public long Tax1099fields { get; set; }
        public int VendortypeMx { get; set; }
        public string ForeigntaxregistrationMx { get; set; } = null!;
        public string NationalityMx { get; set; } = null!;
        public string DiotcountrycodeMx { get; set; } = null!;
        public int OperationtypeMx { get; set; }
        public long Maincontactworker { get; set; }
        public int CompanytypeMx { get; set; }
        public string RfcMx { get; set; } = null!;
        public string CurpMx { get; set; } = null!;
        public string StateinscriptionMx { get; set; } = null!;
        public string CcmnumBr { get; set; } = null!;
        public string IenumBr { get; set; } = null!;
        public string CnpjcpfnumBr { get; set; } = null!;
        public string VendincomecodeBr { get; set; } = null!;
        public int NontaxableBr { get; set; }
        public int VendconsumptionBr { get; set; }
        public string NitBr { get; set; } = null!;
        public string InssceiBr { get; set; } = null!;
        public string CnaeBr { get; set; } = null!;
        public int IcmscontributorBr { get; set; }
        public int ServicecodeondlvaddressBr { get; set; }
        public string InterestcodeBr { get; set; } = null!;
        public string FinecodeBr { get; set; } = null!;
        public int VattaxagentRu { get; set; }
        public int TaxwithholdvendortypeTh { get; set; }
        public string VatoperationcodeRu { get; set; } = null!;
        public int VatpartnerkindRu { get; set; }
        public int InventprofiletypeRu { get; set; }
        public string InventprofileidRu { get; set; } = null!;
        public int UnitedvatinvoiceLt { get; set; }
        public int ConsdayJp { get; set; }
        public string StructdepartmentRu { get; set; } = null!;
        public string BankcentralbanktranstypecurRu { get; set; } = null!;
        public string BankorderofpaymentRu { get; set; } = null!;
        public string Enterprisecode { get; set; } = null!;
        public string RegnumW { get; set; } = null!;
        public string Commercialregistersection { get; set; } = null!;
        public string Commercialregisterinsetnumber { get; set; } = null!;
        public string Commercialregister { get; set; } = null!;
        public int IsresidentLv { get; set; }
        public string IntbankLv { get; set; } = null!;
        public int CashaccountingregimeEs { get; set; }
        public string Ciscompanyregnum { get; set; } = null!;
        public string Cisnationalinsurancenum { get; set; } = null!;
        public int Cisstatus { get; set; }
        public string Cisuniquetaxpayerref { get; set; } = null!;
        public DateTime Cisverificationdate { get; set; }
        public string Cisverificationnum { get; set; } = null!;
        public string Defaultinventstatusid { get; set; } = null!;
        public int Disabledowned { get; set; }
        public string Ethnicoriginid { get; set; } = null!;
        public int ForeignresidentRu { get; set; }
        public int Hubzone { get; set; }
        public int IspaymfeecoveredJp { get; set; }
        public long Lvpaymtranscodes { get; set; }
        public int MandatoryvatdatePl { get; set; }
        public string SeparatedivisionidRu { get; set; } = null!;
        public string Tamrebategroupid { get; set; } = null!;
        public string TaxperiodpaymentcodePl { get; set; } = null!;
        public int Usecashdisc { get; set; }
        public int Veteranowned { get; set; }
        public DateTime Modifieddatetime { get; set; }
        public int DelModifiedtime { get; set; }
        public string Modifiedby { get; set; } = null!;
        public DateTime Createddatetime { get; set; }
        public int DelCreatedtime { get; set; }
        public string Createdby { get; set; } = null!;
        public string Dataareaid { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
        public string MntCodigopais { get; set; } = null!;
        public int MntDobtrib { get; set; }
        public int MntExtsujret { get; set; }
        public int MntPagolocext { get; set; }
        public int MntAccionista { get; set; }
        public int MntPagoregfis { get; set; }
        public string VendpaymfeegroupJp { get; set; } = null!;
        public string ForeigneridBr { get; set; } = null!;
        public int PresencetypeBr { get; set; }
        public long Vendorportaladministratorrecid { get; set; }
        public string MntCustaccount { get; set; } = null!;
        public string Mntdenoregimenfiscal { get; set; } = null!;
        public string Mntpaispagoregimengeneral { get; set; } = null!;
        public string Mntparaisofiscal { get; set; } = null!;
        public string Mntregimenfiscalext { get; set; } = null!;
        public string MntFpago { get; set; } = null!;
    }
}
