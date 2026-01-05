namespace CsharpCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Welcome to our system ");
                Console.WriteLine("choose a services you need");
                Console.WriteLine("1. add two numbers");
                Console.WriteLine("2.find averge of list ");
                Console.WriteLine("3.check if input number is even or odd");
                Console.WriteLine("4.Find the smallest number  ");
                Console.WriteLine("5.conut number of positive numbers and  number of negative numbers");
                Console.WriteLine("6.output prime numbers");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter first number");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second number");
                        int number2 = int.Parse(Console.ReadLine());
                        int result = number1 + number2;
                        Console.WriteLine("The sum is " + result);
                        break;




                    case 2:
                        Console.WriteLine("Enter how many numbers you need :");
                        int n = int.Parse(Console.ReadLine());
                        int[] numbers = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter the number: ");
                            numbers[i] = int.Parse(Console.ReadLine());
                        }
                        int sum = 0;
                        for (int i = 0; i < n; i++)
                        {
                            sum += numbers[i];

                        }
                        float average = (float)sum / n;
                        Console.WriteLine("The average of numbers is : " + average);
                        break;
                    case 3:
                        Console.WriteLine("Enter a number");
                        float number = float.Parse(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.WriteLine("The number is even");
                        }
                        else
                        {
                            Console.WriteLine("The number is odd");
                        }

                        break;
                    case 4:
                        int n2 = int.Parse(Console.ReadLine());
                        int[] numberss = new int[n2];
                        int smallest = int.MaxValue; ;

                        for (int i = 0; i < n2; i++)
                        {
                            Console.WriteLine("Enter the number:");
                            numberss[i] = int.Parse(Console.ReadLine());

                        }
                        for (int i = 0; i < numberss.Length; i++)
                        {
                            if (numberss[i] < smallest)
                            {
                                smallest = numberss[i];
                            }
                        }
                        Console.WriteLine("The smallest number is" + smallest);


                        break;
                    case 5:
                        Console.WriteLine("Enter how many numbers you need:");
                        int n3 = int.Parse(Console.ReadLine());
                        int[] inputs = new int[n3];
                        int numbersofpositive = 0;
                        int numbersofNegative = 0;
                        for (int i = 0; i < n3; i++)
                        {
                            Console.WriteLine("Enter number " + (i + 1) + ":");
                            inputs[i] = int.Parse(Console.ReadLine());
                            if (inputs[i] > 0)
                            {
                                numbersofpositive++;

                            }
                            else
                            {
                                numbersofNegative++;
                            }
                        }

                        Console.WriteLine("The number of positive numbers is :" + numbersofpositive);
                        Console.WriteLine("The number of negative numbers is :" + numbersofNegative);
                        break;

                    case 6:
                        Console.WriteLine("Enter how many numbers you need: ");
                        int n4 = int.Parse(Console.ReadLine());
                        int[] values = new int[n4];

                        for (int i = 0; i < values.Length; i++)
                        {
                            Console.WriteLine("Enter number: ");
                            values[i] = int.Parse(Console.ReadLine());

                            int num = values[i];

                            if (num > 2)
                            {

                                for (int j = 2; j < n4; j++)
                                {
                                    if (num % 2 == 0)
                                    {
                                        Console.WriteLine(num + "The number is not prime");
                                    }
                                    else
                                    {
                                        Console.WriteLine(num + "The number is prime");
                                    }
                                }





                            }

                        }
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}
