namespace PractiseFunction;
public class Car
{

  public string? Colour { get; }

  public int PassengersCount { get; }
  public string CarPlate { get; }

  public Car(string colour, int passengers, string number_plate)
  {
    Colour = colour;
    PassengersCount = passengers;
    CarPlate = number_plate;

  }

}
