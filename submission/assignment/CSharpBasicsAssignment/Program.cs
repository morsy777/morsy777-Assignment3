// ============ Part A ====================//
#region Part A 
// .csproj is the file that contain project configs like .net version, packages and dependencies.
// Program.cs is the entry point of our application.
// obj/ is the dir that conain the compiled output and cached the last build.
// bin/ when we build our project, the IL code is stored in that dir specifically in .dll file or in other word called assembly file.

// File-scoped namespace removes the need for a namespace block,
// so the code inside the namespace doesn't need an extra indentation level.

// My project use .sln but .slnx is better in solving git conflicts, also readable and simpler than .sln .
#endregion

namespace CSharpBasicsAssignment;

class Program
{
  private string _socialNumber = "303030303030";
  static void Main()
  {
    // ======== Part C ==========//
    #region Part C
    Order o1 = new Order
    {
      OrderId = 1,
      CustomerName = "Mohamed Morsi",
      Quantity = 3,
      UnitPrice = 25.50m,
      IsPaid = false,
      DiscountPercent = 10.0,
      ShippingCity = "Mansoura",
      Priority = 'H',
      ItemCode = 33333
    };

    o1.CalculateTotal();
    
    Order o2 = o1;
    o2.IsPaid = false;

    // When we assign o1 to o2, the both variable
    // refer to the same Order (object) in the heap
    o1.PrintSummary();
    o2.PrintSummary();

    object BoxOrder = o1;
    Order o3 = (Order)BoxOrder;
    Console.WriteLine($"Is O1 & O3 refer to the smae object: {object.ReferenceEquals(o1, o3)}");

    o2.PrintSummary();

    /* The main different between Value & Ref type is how they are store and hold data.
    * 1- Value Type is Store in The Stack While ref type in Heap.
    * 2- When we assing value type to another variable, a copy of the value is created,
    * while when we assign reference type to another variable, the both variable holds the same address
    * of the object so the both refer to the same object in the memory, that what is occur when we assign o1 to o2.
    * 3- When we assingn o1 to BoxOrder (object), the BoxOrder will refer to the same object beacuse there is no new
    * copy created and BoxOrder already have the same reference after assingment.
    */
    #endregion

  TryBitwiseOperators();

  }

  // ======== Part B ==========//
  #region Part B
    static void RunTypesDemo()
  {
    // 1.
    int num = 10;
    long bigNum = 100L;
    double price = 10.5;
    decimal salary = 5000.50m;
    bool isActive = true;
    char grade = 'A';
    string name = "Mohamed";
    var age = 23;

    Console.WriteLine($"{num} - {num.GetType()}");
    Console.WriteLine($"{bigNum} - {bigNum.GetType()}");
    Console.WriteLine($"{price} - {price.GetType()}");
    Console.WriteLine($"{salary} - {salary.GetType()}");
    Console.WriteLine($"{isActive} - {isActive.GetType()}");
    Console.WriteLine($"{grade} - {grade.GetType()}");
    Console.WriteLine($"{name} - {name.GetType()}");
    Console.WriteLine($"{age} - {age.GetType()}");

    // 2.
      // Implicit:
    int x = 10;
    long y = x;

    char c = 'A';
    int asciiCode = c;

      // No Cast is needed because we convert from smaller to larger and C# consider this conversion doesn't cause conflict
    Console.WriteLine(y);
    Console.WriteLine(asciiCode);

      // Explicit:
    double value = 9.7;

    int result1 = (int)value;
    int result2 = Convert.ToInt32(value);

      // int removes the fraction part, while Convert.ToInt32 rounds the value.
    Console.WriteLine(result1);
    Console.WriteLine(result2);

      // Integer division
    int a = 5 / 2;
    double b = 5.0 / 2;

    // a = 2 because we divide int/int, while double = 2.5 because we divide double/int

    Console.WriteLine(a);
    Console.WriteLine(b);

     // Boxing / Unboxing
    int numBox = 42;

    object obj = numBox;
    Console.WriteLine(obj);

    int unboxed = (int)obj;
    Console.WriteLine(unboxed);

      // Parsing
    string input = "42";
    int parsed = int.Parse(input);
    Console.WriteLine(parsed);

    string badInput = "abc";

    if (int.TryParse(badInput, out int parsedBad))
      Console.WriteLine(parsedBad);
    else
      Console.WriteLine("TryParse failed.");

      // float to decimal
    float f = 10.5f;

    // decimal d = f; xxxxx
    // float to decimal is not an implicit conversion, 
    // because decimal is more precise than float and use base-10
    // while float less precise and use base-2

    decimal d = (decimal)f;
    Console.WriteLine(d);
  }

  static void RunValueVsReferenceDemo()
  {
    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;
    p2.X = 99;

    // Struct is value type so when we assign value type
    //  to another variable, a copy of the value is created
    //  and the both variable are completely independent.
    Console.WriteLine($"P1.X = {p1.X} || P2.X = {p2.X}");
  }

  #endregion

  // ======== Part D ==========//
  #region Part D
  // D1
  void TryReadPrivatVarAndLocal()
  {
    // _socialNumber is accessible inside this class at any function
    // but invisible outside this class.
    Console.WriteLine(_socialNumber);

    string me = "Morsi";
  }

  // Compile Error at (me) because there is no variable called me outside the scope of
  // its function, because the me varibale is already poped from the stack.
  // Console.WriteLine(me);

  void TestLoopScope()
  {
    for (int i = 0; i < 2; i++)
    {
      string name = $"User {i}";
      Console.WriteLine(name);
    }

    // Compile Error because the i and name is block scope and already poped from the stack after loop implementation.
    // Console.WriteLine(i);
    // Console.WriteLine(name);
  }

  // D2
  void TryOperators()
  {
    int total = 100;

    // total += 10; is equivalent to, total = total + 10
    total += 10;
    Console.WriteLine(total);

    total -= 20;
    Console.WriteLine(total);

    total *= 2;
    Console.WriteLine(total);

    total /= 5;
    Console.WriteLine(total);

    total %= 7;
    Console.WriteLine(total);
  }

  // D3
  static void TryBitwiseOperators()
  {
    int a = 10; // 1010
    int b = 7; // 0111

    // if both are 1 the result is 1 else is 0
    Console.WriteLine(a & b);
    // if at least one is 1 the both is 1 else is 0
    Console.WriteLine(a | b);
    // if the both are different(0^1) the result is 1
    Console.WriteLine(a ^ b);
  }
  #endregion

  // ======== Part E ==========//
  #region Part 
  

  #endregion



}




