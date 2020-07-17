namespace PierresBakery.Models.Pastries
{
  public class Pastry
  {
    public string Type { get; set; }
    public int Price { get; set; }
    public Pastry(string type, int price)
    {
      Type = type;
      Price = price;
    }
  }
}