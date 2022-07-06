//3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
class Unique
{
    public static void Main()
    {
        var array = new List<int>();

        
        while(array.Count < 5)
        {
            Console.WriteLine("Enter a numbers: ");
            var input = Convert.ToInt32(Console.ReadLine());
            if (array.Contains(input))
            {
                Console.WriteLine("You've previously Entered this number: " + input);
                continue;
            }
            array.Add(input);

        }
        array.Sort();

        foreach(var item in array) { Console.WriteLine(item); }
    }
}