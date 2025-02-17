using System.Collections.ObjectModel;

namespace UnitConversionApi.Domain.Entities;

public class UnitCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Unit> Units { get; set; } = new Collection<Unit>();
}