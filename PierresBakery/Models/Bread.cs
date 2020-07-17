namespace PierresBakery.Models.Breads
{
  public class Bread
  {
    public string Type { get; set; }
    public Bread(string type)
    {
      Type = type;
    }
  }
}