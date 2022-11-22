namespace PractiseFunction.Test;

public class UnitTest1
{
  Ferry test = new Ferry();
  [Fact]
  public void ItShouldBeAbleToReturnAcceptedIfItDoesNotExceedNumberOfPeopleAndCars()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("slive grey", 3, "CY 197-321"));
    test.Board(new Car("black", 2, "CF 188-568"));
    test.Board(new Car("white", 5, "CF 188-568"));
    test.Board(new Car("navy", 3, "CF 188-568"));

    Assert.Equal("Accepted", test.Board(new Car("black", 6, "CF 188-568")));

  }
  [Fact]
  public void ItShouldBeAbleToReturnRejectedIfItDoesExceedNumberOfPeopleAndCars()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("slive grey", 5, "CY 197-321"));
    test.Board(new Car("black", 7, "CF 188-568"));
    test.Board(new Car("white", 7, "CF 188-568"));
    test.Board(new Car("navy", 7, "CF 188-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("slive grey", 5, "CY 197-321"));
    test.Board(new Car("black", 7, "CF 188-568"));
    test.Board(new Car("white", 7, "CF 188-568"));
    test.Board(new Car("red", 7, "CF 188-268"));
    test.Board(new Car("pink", 1, "CA 223-564"));
    test.Board(new Car("blue", 5, "CY 444-371"));
    test.Board(new Car("white", 7, "CY 288-368"));
    test.Board(new Car("maroon", 7, "CA 138-538"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("black", 7, "CF 188-568"));
    test.Board(new Car("white", 7, "CF 188-568"));
    test.Board(new Car("maroon", 7, "CA 138-538"));
    test.Board(new Car("red", 7, "CF 188-268"));


    Assert.Equal("Rejected", test.Board(new Car("red", 7, "CA 138-538")));
  }
  [Fact]
  public void ItShouldBeAbleToReturnTheDiscountMessageIfTheSameCarHasTakenTripThreeTimes()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("black", 7, "CF 188-568"));
    test.Board(new Car("white", 7, "CF 188-568"));
    test.Board(new Car("maroon", 7, "CA 138-538"));
    test.Board(new Car("red", 7, "CF 188-268"));
    Assert.Equal("Half Price!!", test.Board((new Car("yellow", 1, "CA 123-568"))));

  }
  [Fact]
  public void ItShouldBeAbleToReturnTheFreeTripMessageIfTheSameCarHasTakenTripsSevenTimes()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("blue", 5, "CY 197-321"));
    test.Board(new Car("black", 3, "CF 188-568"));
    test.Board(new Car("black", 5, "CF 188-568"));
    test.Board(new Car("black", 4, "CF 188-568"));
    test.Board(new Car("silver grey", 4, "EC 444-468"));
    test.Board(new Car("white", 2, "CF 123-566"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 3, "CA 123-568"));
    test.Board(new Car("yellow", 4, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CF 323-868"));
    Assert.Equal("You go free!!", test.Board((new Car("yellow", 1, "CA 123-568"))));
  }
  [Fact]
  public void ItShouldBeAbleToReturnAcceptedIfCarsAreGreaterThanSeven()
  {
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 3, "CA 123-568"));
    test.Board(new Car("yellow", 4, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("yellow", 3, "CA 123-568"));
    test.Board(new Car("yellow", 4, "CA 123-568"));
    test.Board(new Car("yellow", 2, "CA 123-568"));

    Assert.Equal("Accepted", test.Board(new Car("yellow", 2, "CA 123-568")));
  }
  [Fact]
  public void ItShouldReturnTheNumberOfCarsWithTheSameColour()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("white", 3, "CY 197-321"));
    test.Board(new Car("black", 2, "CF 188-568"));
    test.Board(new Car("white", 5, "CF 188-568"));
    test.Board(new Car("navy", 3, "CF 188-568"));

    Assert.Equal("We have " + 2 + " car/s in the ferry with the " + "white" + "Colour", test.HowManyCars("white"));

  }
  [Fact]
  public void ItShouldReturnTheErrorMessageIfThereAreNoCarsWithTheColourWanted()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("white", 3, "CY 197-321"));
    test.Board(new Car("black", 2, "CF 188-568"));
    test.Board(new Car("white", 5, "CF 188-568"));
    test.Board(new Car("navy", 3, "CF 188-568"));

    Assert.Equal("There are no cars in the ferry with that colour", test.HowManyCars("silver grey"));

  }
  [Fact]
  public void ItShouldBeAbleToReturnTheNumberOfCarsAndPeopleLeftAfterTheDepatureOfACar()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("white", 3, "CY 197-321"));
    test.Board(new Car("black", 2, "CF 188-568"));
    test.Board(new Car("white", 5, "CF 188-568"));
    test.Board(new Car("navy", 3, "CF 188-568"));

    Assert.Equal("The car departed only 4 cars left and 11 people left", test.Update((new Car("white", 3, "CY 197-321"))));
  }
  [Fact]
  public void ItShouldBeAbleToReturnTheErrorMessageIfTheCarIsNotOnTheFerryBoat()
  {
    test.Board(new Car("yellow", 1, "CA 123-568"));
    test.Board(new Car("white", 3, "CY 197-321"));
    test.Board(new Car("black", 2, "CF 188-568"));
    test.Board(new Car("white", 5, "CF 188-568"));
    test.Board(new Car("navy", 3, "CF 188-568"));
    Assert.Equal("The car is not on board", test.Update(new Car("red", 7, "CF 188-268")));


  }
}