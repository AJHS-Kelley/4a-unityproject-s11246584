namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 32
        float myFloat = 2.43F;
        bool myBool = true;
        string myString = "Hiya.\n";

        Console.WriteLine("My Integer variable is " + myInt);
        Console.WriteLine("My Float variable is " + myFloat);
        Console.WriteLine("My Bool variable is " + myBool);
        Console.WriteLine("My String variable is " + myString);

        for (int i = 0; i<= 20; i++) {
            Console.WriteLine("I ate " + i + " slices of pizza for lunch.\n");
        }
    }
}
