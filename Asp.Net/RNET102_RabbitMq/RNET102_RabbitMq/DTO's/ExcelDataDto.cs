using Ganss.Excel;

namespace RNET102_RabbitMq.DTO_s;

internal class ExcelDataDto
{
    public string Segment { get; set; }
    public string Country { get; set; }
    public string Product { get; set; }
    [Column("Discount Band", MappingDirections.ExcelToObject)]
    public string DiscountBand { get; set; }
    [Column("Units Sold", MappingDirections.ExcelToObject)]

    public decimal UnitSold { get; set; }
    [Column("Manufacturing Price", MappingDirections.ExcelToObject)]

    public decimal ManufacturingPrice { get; set; }
    [Column("Sale Price", MappingDirections.ExcelToObject)]

    public decimal SalePrice { get; set; }
    [Column("Gross Sales", MappingDirections.ExcelToObject)]
    public decimal GrossSales { get; set; }
    public decimal Discounts { get; set; }
    [Column("Sales", MappingDirections.ExcelToObject)]
    public decimal Sales { get; set; }
    public decimal COGS { get; set; }
    public decimal Profit { get; set; }
    public DateTime Date { get; set; }
}
