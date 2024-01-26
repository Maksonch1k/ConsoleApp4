namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                {
                    MyClass obj1 = new MyClass(3.5, 4.2);
                    MyClass obj2 = new MyClass();

                    obj1.DisplayValues();
                    obj2.DisplayValues();

                    Console.WriteLine($"Total instances of MyClass: {MyClass.count}");
                }
            }
        }
    }
}