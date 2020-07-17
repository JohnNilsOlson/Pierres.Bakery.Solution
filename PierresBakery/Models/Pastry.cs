namespace PierresBakery.Models.Pastries
{
  public class Pastry
  {
    public string Type { get; set; }
    public Pastry(string type)
    {
      Type = type;
    }
  }
}