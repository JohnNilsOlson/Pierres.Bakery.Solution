namespace PierresBakery.Models.Breads
{
  public class Bread
  {
    public string Type { get; set; }
    public int Price { get; set; }
    public Bread(string type, int price)
    {
      Type = type;
      Price = price;
    }
  }
}