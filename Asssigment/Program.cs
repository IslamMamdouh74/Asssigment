namespace Asssigment
{
    internal class Program
    {
        #region Q1


        //static void Main(string[] args)
        //{
        //    Point3D P = new Point3D(10, 10, 10);
        //    Console.WriteLine(P.ToString());

        //    // Read two points from user
        //    Point3D P1 = ReadPointFromUser("P1");
        //    Point3D P2 = ReadPointFromUser("P2");

        //    // Test ==
        //    if (P1 == P2)
        //        Console.WriteLine("P1 and P2 are equal.");
        //    else
        //        Console.WriteLine("P1 and P2 are NOT equal.");

        //    // Array of points
        //    Point3D[] points = new Point3D[]
        //    {
        //    new Point3D(5, 2, 1),
        //    new Point3D(3, 8, 9),
        //    new Point3D(5, 1, 0),
        //    new Point3D(1, 2, 3)
        //    };

        //    // Sort by X then Y
        //    Array.Sort(points, (a, b) =>
        //    {
        //        int compareX = a.X.CompareTo(b.X);
        //        return compareX != 0 ? compareX : a.Y.CompareTo(b.Y);
        //    });

        //    Console.WriteLine("\nSorted Points:");
        //    foreach (var pt in points)
        //        Console.WriteLine(pt);

        //    // Clone example
        //    Point3D clone = (Point3D)P1.Clone();
        //    Console.WriteLine($"\nCloned point: {clone}");
        //}

        //static Point3D ReadPointFromUser(string pointName)
        //{
        //    int x = ReadInt($"{pointName}.X = ");
        //    int y = ReadInt($"{pointName}.Y = ");
        //    int z = ReadInt($"{pointName}.Z = ");
        //    return new Point3D(x, y, z);
        //}

        //static int ReadInt(string prompt)
        //{
        //    int result;
        //    while (true)
        //    {
        //        Console.Write(prompt);
        //        string input = Console.ReadLine();
        //        if (int.TryParse(input, out result))
        //            break;
        //        Console.WriteLine("Invalid input. Please enter an integer.");
        //    }
        //    return result;
        #endregion
        #region Q02
        //double x = 10;
        //double y = 5;

        //Console.WriteLine($"Add: {Maths.Add(x, y)}");         
        //Console.WriteLine($"Subtract: {Maths.Subtract(x, y)}"); 
        //Console.WriteLine($"Multiply: {Maths.Multiply(x, y)}"); 
        //Console.WriteLine($"Divide: {Maths.Divide(x, y)}"); 
        #endregion
        #region Q03
        //Console.WriteLine("Enter your user type (Regular, Premium, Guest):");
        //string userType = Console.ReadLine().Trim().ToLower();

        //Console.Write("Enter your name: ");
        //string userName = Console.ReadLine().Trim();

        //User user = userType switch
        //{
        //    "regular" => new RegularUser(userName),
        //    "premium" => new PremiumUser(userName),
        //    "guest" => new GuestUser(userName),
        //    _ => throw new Exception("Invalid user type")
        //};

        //decimal price = ReadDecimal("Enter product price: ");
        //int quantity = ReadInt("Enter product quantity: ");

        //Discount discount = user.GetDiscount();
        //decimal discountAmount = discount.CalculateDiscount(price, quantity);
        //decimal totalPrice = price * quantity;
        //decimal finalPrice = totalPrice - discountAmount;

        //Console.WriteLine($"\nUser: {user.Name} ({discount.Name})");
        //Console.WriteLine($"Original Price: ${totalPrice:F2}");
        //Console.WriteLine($"Discount Amount: ${discountAmount:F2}");
        //Console.WriteLine($"Final Price: ${finalPrice:F2}");
    
    #endregion
}
}

    

