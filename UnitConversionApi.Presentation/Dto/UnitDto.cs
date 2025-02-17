namespace UnitConversionApi.Presentation.Dto;

public class UnitDto
{
    public string Name { get; set; } = string.Empty;
    public double Factor { get; set; }
    public bool MainReference { get; set; }
    public string UnitCategoryName { get; set; } = string.Empty;
}