namespace PractiseFunction;

public class Ferry
{
  public int NumberOfCars;
  public int NumberOfPeople;

  public int PeopleCount { get; set; }
  public int CarCount { get; set; }

  List<Car> cars = new List<Car>();
  public List<KeyValuePair<string, int>> numberOfCars = new List<KeyValuePair<string, int>>();

  public Ferry()
  {
    NumberOfCars = 20;
    NumberOfPeople = 50;
  }

  public string Board(Car car)
  {
    string message = "";
    if (NumberOfCars >= CarCount && NumberOfPeople >= PeopleCount)
    {
      int counter = 0;
      PeopleCount += car.PassengersCount;
      CarCount++;
      cars.Add(new Car(car.Colour!, car.PassengersCount, car.CarPlate));
      numberOfCars.Add(new KeyValuePair<string, int>(car.Colour!, car.PassengersCount));

      foreach (var item in cars)
      {
        if (item.CarPlate == car.CarPlate && item.Colour == car.Colour) counter++;

        if (counter >= 3 && counter < 7)
        {
          message = "Half Price!!";
        }
        else if (counter == 7 && counter < 8)
        {
          message = "You go free!!";
        }
        else
        {
          message = "Accepted";

        }
      }
    }
    else
    {
      message = "Rejected";
    }
    return message;
  }
  public string HowManyCars(string colour)
  {
    int count = 0;
    string message = "";
    foreach (var item in numberOfCars)
    {
      if (item.Key == colour) count++;

      if (count >= 1)
      {

        message = "We have " + count + " car/s in the ferry with the " + colour + "Colour";
      }
      else
      {
        message = "There are no cars in the ferry with that colour";
      }


    }
    return message;
  }

  public string Update(Car car)
  {
    if (numberOfCars.Contains(new KeyValuePair<string, int>(car.Colour!, car.PassengersCount)))
    {
      numberOfCars.Remove(new KeyValuePair<string, int>(car.Colour!, car.PassengersCount));
      CarCount--;
      PeopleCount -= car.PassengersCount;
      return "The car departed only " + CarCount + " cars left and " + PeopleCount + " people left";
    }
    else
    {
      return "The car is not on board";
    }

  }



}