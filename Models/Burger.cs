namespace burgershackapi.Models
{
  public class Burger
  {
    public Burger() { }
    public Burger(string name, string description, float price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int Id { get; set; }
  }
}