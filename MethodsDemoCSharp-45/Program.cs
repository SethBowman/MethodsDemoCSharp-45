namespace MethodsDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling a method (using a method)
            GreetPerson("Seth");
            GreetPerson("Mack");

            int ourAdd = Add(2, 2);
            int ourAddTwo = Add(3, 3);
            Console.WriteLine(ourAdd);
            Console.WriteLine(ourAddTwo);

            GetUserNameAndGreet();
        }

        //Method definition (creating a method)
        //Parts of a method
        //Disregard the keyword "static" for now
        //Pascal casing for methods - EveryNextWordStartsWithCapital
        //Access Modifier - Return type - Method name - Parameter list - Scope (body)
        public static void GreetPerson(string name)
        {
            Console.WriteLine($"Hey, {name}!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void GetUserNameAndGreet()
        {
            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hey, {name}!");
        }

        //Adding operator 2 + 2
        //Subtract 2 - 2
        //Dividing 2 / 2
        //Multiply 2 * 2
    }
}
