
using Acumatica.Default_20_200_001.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_Demo.Models;

/// <summary>
///     Local Store of recently used Cases
/// </summary>
public class AP_Bill
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public decimal Amount { get; set; }
    //public List<BillApplicationDetail> Applications { get; set; }
    public bool ApprovedForPayment { get; set; }
    public decimal Balance { get; set; }
    public string BranchID { get; set; }
    public string CashAccount { get; set; }
    public string CurrencyID { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    //public List<BillDetail> Details { get; set; }
    public DateTime DueDate { get; set; }
    public bool Hold { get; set; }
    public string LocationID { get; set; }
    public string PostPeriod { get; set; }
    public string Project { get; set; }
    public string ReferenceNbr { get; set; }
    public string Status { get; set; }
    //public List<BillTaxDetail> TaxDetails { get; set; }
    public decimal TaxTotal { get; set; }
    public string Terms { get; set; }
    public string Type { get; set; }
    public string Vendor { get; set; }
    public string VendorRef { get; set; }
    public DateTime LastModifiedDateTime { get; set; }

}
