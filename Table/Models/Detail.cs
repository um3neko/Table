using System;

namespace Table.Models;

public class Detail
{
    public Guid Id { get; set; } = new Guid();
    public string Name { get; set; }    
    public double Weight { get; set; }
    public string Material { get; set; }
    public int Count { get; set; }
}
