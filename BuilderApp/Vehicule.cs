public class Vehicule
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int RentalPrice { get; set; }

    public void Display()
    {
        Console.WriteLine($"Vehicule: {Brand} {Model} ({Year}), Color: {Color}, Rental Price: {RentalPrice}");
    }
}