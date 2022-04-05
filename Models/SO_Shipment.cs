
using Acumatica.Default_20_200_001.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_Demo.Models;

/// <summary>
///     Local Store of recently used Cases
/// </summary>
public class SO_Shipment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string BaseCurrencyID { get; set; }
    public decimal ControlQty { get; set; }
    //public DateTime CreatedDateTime { get; set; }
    public decimal CurrencyRate { get; set; }
    public string CurrencyRateTypeID { get; set; }
    public bool CurrencyViewState { get; set; }
    public string CustomerID { get; set; }
    public bool CreateNewShipmentForEveryOrder { get; set; }
    //public List<ShipmentDetail> Details { get; set; }
    public string Description { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string FOBPoint { get; set; }
    public bool OverrideFreightPrice { get; set; }
    public decimal FreightAmount { get; set; }
    public decimal FreightCost { get; set; }
    public string FreightCurrencyID { get; set; }
    public bool GroundCollect { get; set; }
    public bool Hold { get; set; }
    public bool Insurance { get; set; }
    public DateTime LastModifiedDateTime { get; set; }
    public string LocationID { get; set; }
    public string Operation { get; set; }
    //public List<ShipmentOrderDetail> Orders { get; set; }
    public string Owner { get; set; }
    public int PackageCount { get; set; }
    //public List<ShipmentPackage> Packages { get; set; }
    public decimal PackageWeight { get; set; }
    public bool Picked { get; set; }
    public decimal ReciprocalRate { get; set; }
    public bool ResidentialDelivery { get; set; }
    public bool SaturdayDelivery { get; set; }
    public DateTime ShipmentDate { get; set; }
    public string ShipmentNbr { get; set; }
    public decimal ShippedQty { get; set; }
    public decimal ShippedVolume { get; set; }
    public decimal ShippedWeight { get; set; }
    //public ShipToSettings ShippingSettings { get; set; }
    public string ShippingTerms { get; set; }
    public string ShippingZoneID { get; set; }
    public string ShipVia { get; set; }
    public string Status { get; set; }
    public string ToWarehouseID { get; set; }
    public string Type { get; set; }
    public bool UseCustomersAccount { get; set; }
    public string WarehouseID { get; set; }
    public string WorkgroupID { get; set; }

}
