using System;
using System.Collections.Generic;

namespace LimpiezaProyect.Models
{
    public partial class PriceDiscTable
    {
        public string Agreement { get; set; } = null!;
        public int Itemcode { get; set; }
        public int Accountcode { get; set; }
        public string Itemrelation { get; set; } = null!;
        public string Accountrelation { get; set; } = null!;
        public decimal Quantityamountfrom { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = null!;
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }
        public int Deliverytime { get; set; }
        public int Searchagain { get; set; }
        public decimal Priceunit { get; set; }
        public int Relation { get; set; }
        public decimal Quantityamountto { get; set; }
        public string Unitid { get; set; } = null!;
        public decimal Markup { get; set; }
        public int Allocatemarkup { get; set; }
        public int Module { get; set; }
        public string Inventdimid { get; set; } = null!;
        public int Calendardays { get; set; }
        public int Genericcurrency { get; set; }
        public int Mcrpricediscgrouptype { get; set; }
        public decimal Mcrfixedamountcur { get; set; }
        public string Mcrmerchandisingeventid { get; set; } = null!;
        public long AgreementheaderextRu { get; set; }
        public int Disregardleadtime { get; set; }
        public int InventbaileefreedaysRu { get; set; }
        public decimal MaximumretailpriceIn { get; set; }
        public long Originalpricediscadmtransrecid { get; set; }
        public string Pdscalculationid { get; set; } = null!;
        public DateTime Modifieddatetime { get; set; }
        public string Dataareaid { get; set; } = null!;
        public int Recversion { get; set; }
        public long Partition { get; set; }
        public long Recid { get; set; }
        public string Modifiedby { get; set; } = null!;
        public DateTime Createddatetime { get; set; }
        public string Createdby { get; set; } = null!;
    }
}
