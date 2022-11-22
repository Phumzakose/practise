using PractiseFunction;

Ferry user = new Ferry();

user.Board(new Car("yellow", 3, "CA 123-332"));
user.Board(new Car("blue", 4, "CY 321-563"));
user.Board(new Car("purple", 4, "EC 465-786"));
user.Board(new Car("silver grey", 2, "CF 564 876"));
user.Board(new Car("purple", 4, "EC 465-786"));
user.Board(new Car("purple", 4, "EC 465-786"));
user.Board(new Car("purple", 4, "EC 465-786"));
user.Board(new Car("purple", 4, "EC 465-786"));
user.Board(new Car("purple", 4, "EC 465-786"));



Console.WriteLine(user.Board(new Car("purple", 4, "EC 465-786")));

// foreach (var item in user.numberOfCars)
// {
//   Console.WriteLine(item);

// }

Console.WriteLine(user.HowManyCars("blue"));
Console.WriteLine(user.Update(new Car("red", 2, "CA 564 876")));
