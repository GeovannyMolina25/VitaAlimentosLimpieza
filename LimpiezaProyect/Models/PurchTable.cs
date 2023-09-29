using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PurchTable
    {
        public string Purchid { get; set; } = null!;
        public string Purchname { get; set; } = null!;
        public string Orderaccount { get; set; } = null!;
        public string Invoiceaccount { get; set; } = null!;
        public string Freightzone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime Deliverydate { get; set; }
        public int Deliverytype { get; set; }
        public long Addressrefrecid { get; set; }
        public int Addressreftableid { get; set; }
        public string Intercompanyoriginalsalesid { get; set; } = null!;
        public string Intercompanyoriginalcustaccount { get; set; } = null!;
        public string Currencycode { get; set; } = null!;
        public string Payment { get; set; } = null!;
        public string Cashdisc { get; set; } = null!;
        public string Countyorigdest { get; set; } = null!;
        public int Intercompanydirectdelivery { get; set; }
        public string Vendgroup { get; set; } = null!;
        public string Linedisc { get; set; } = null!;
        public decimal Discpercent { get; set; }
        public string Pricegroupid { get; set; } = null!;
        public string Multilinedisc { get; set; } = null!;
        public string Enddisc { get; set; } = null!;
        public string Intercompanycustpurchorderformnum { get; set; } = null!;
        public string Taxgroup { get; set; } = null!;
        public string Dlvterm { get; set; } = null!;
        public string Dlvmode { get; set; } = null!;
        public int Purchstatus { get; set; }
        public string Markupgroup { get; set; } = null!;
        public int Purchasetype { get; set; }
        public string Url { get; set; } = null!;
        public string Postingprofile { get; set; } = null!;
        public string Transactioncode { get; set; } = null!;
        public string Enterprisenumber { get; set; } = null!;
        public int Settlevoucher { get; set; }
        public int Intercompanyallowindirectcreation { get; set; }
        public int Intercompanyorigin { get; set; }
        public decimal Cashdiscpercent { get; set; }
        public string Deliveryname { get; set; } = null!;
        public int Covstatus { get; set; }
        public string Paymentsched { get; set; } = null!;
        public string Inventsiteid { get; set; } = null!;
        public int Onetimevendor { get; set; }
        public string Returnitemnum { get; set; } = null!;
        public int Freightsliptype { get; set; }
        public int Documentstatus { get; set; }
        public string Contactpersonid { get; set; } = null!;
        public string Inventlocationid { get; set; } = null!;
        public string Bankcentralbankpurposecode { get; set; } = null!;
        public string Itembuyergroupid { get; set; } = null!;
        public string Projid { get; set; } = null!;
        public string Purchpoolid { get; set; } = null!;
        public string Vatnum { get; set; } = null!;
        public string Port { get; set; } = null!;
        public int Incltax { get; set; }
        public string Bankcentralbankpurposetext { get; set; } = null!;
        public string Numbersequencegroup { get; set; } = null!;
        public string Languageid { get; set; } = null!;
        public int Autosummarymoduletype { get; set; }
        public string Transport { get; set; } = null!;
        public string Paymmode { get; set; } = null!;
        public string Paymspec { get; set; } = null!;
        public DateTime Fixedduedate { get; set; }
        public string Statprocid { get; set; } = null!;
        public string Vendorref { get; set; } = null!;
        public string Intercompanycompanyid { get; set; } = null!;
        public string Intercompanysalesid { get; set; } = null!;
        public int Intercompanyorder { get; set; }
        public string Returnreasoncodeid { get; set; } = null!;
        public int Returnreplacementcreated { get; set; }
        public string Reqattention { get; set; } = null!;
        public long Defaultdimension { get; set; }
        public DateTime Confirmeddlvearliest { get; set; }
        public string ContractnumSa { get; set; } = null!;
        public int Changerequestrequired { get; set; }
        public long Reasontableref { get; set; }
        public int Documentstate { get; set; }
        public int Ismodified { get; set; }
        public long Matchingagreement { get; set; }
        public int Systementrysource { get; set; }
        public long Systementrychangepolicy { get; set; }
        public long Manualentrychangepolicy { get; set; }
        public long VendinvoicedeclarationIs { get; set; }
        public long Workerpurchplacer { get; set; }
        public long Deliverypostaladdress { get; set; }
        public int Bankdocumenttype { get; set; }
        public int Listcode { get; set; }
        public int Isencumbrancerequired { get; set; }
        public long Sourcedocumentline { get; set; }
        public long Sourcedocumentheader { get; set; }
        public long Requester { get; set; }
        public long Accountingdistributiontemplate { get; set; }
        public DateTime Accountingdate { get; set; }
        public DateTime Finalizeclosingdate { get; set; }
        public int ConstargetJp { get; set; }
        public DateTime IntrastatfulfillmentdateHu { get; set; }
        public int UnitedvatinvoiceLt { get; set; }
        public decimal IntrastataddvalueLv { get; set; }
        public int InvoiceregisterLt { get; set; }
        public int PackingslipregisterLt { get; set; }
        public string Servicename { get; set; } = null!;
        public string Serviceaddress { get; set; } = null!;
        public int Onetimesupplier { get; set; }
        public DateTime Servicedate { get; set; }
        public DateTime Confirmeddlv { get; set; }
        public int Fshautocreated { get; set; }
        public DateTime Crossdockingdate { get; set; }
        public string Servicecategory { get; set; } = null!;
        public DateTime Availsalesdate { get; set; }
        public DateTime Localdeliverydate { get; set; }
        public string Replenishmentlocation { get; set; } = null!;
        public int Retailretailstatustype { get; set; }
        public string Retaildriverdetails { get; set; } = null!;
        public int Retailconcessionpurch { get; set; }
        public long Confirmingpo { get; set; }
        public int Mcrdropshipment { get; set; }
        public DateTime Exchangeratedate { get; set; }
        public decimal Fixedexchrate { get; set; }
        public string Tamvendrebategroupid { get; set; } = null!;
        public string TaxperiodpaymentcodePl { get; set; } = null!;
        public long Transportationdocument { get; set; }
        public DateTime Createddatetime { get; set; }
        public string Dataareaid { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
        public decimal CifPorc { get; set; }
        public DateTime Embarquedate { get; set; }
        public string Mntgarantia { get; set; } = null!;
        public string? Mntobservaciones { get; set; }
        public int Mntorigenfondosbe { get; set; }
        public string Numpedimport { get; set; } = null!;
        public int DelPresencetypeBr { get; set; }
        public DateTime Modifieddatetime { get; set; }
        public string Modifiedby { get; set; } = null!;
        public string Createdby { get; set; } = null!;
    }
}
