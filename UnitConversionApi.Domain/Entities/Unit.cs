namespace UnitConversionApi.Domain.Entities;

public class Unit
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Factor { get; set; }
    public int UnitCategoryId { get; set; }
    public bool MainReference { get; set; } = false;
    public UnitCategory UnitCategory { get; set; }
}