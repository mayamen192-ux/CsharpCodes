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
                Console.WriteLine("7.prints a multiplication table");
                Console.WriteLine("8. print non duplicate numbers");
                Console.WriteLine("9. merge two lists");
                Console.WriteLine("10.Find the Second Largest Number");
                Console.WriteLine("11.Check if a String is a Palindrome");

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
                    case 7:
                        Console.WriteLine("Enter a number");
                        int n5 = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n5; i++)
                        {
                            for (int j = 1; j <= n5; j++)
                            {
                                int M = i * j;
                                Console.WriteLine(i + " × " + j + " = " + M);
                            }
                        }




                        break;
                    case 8:
                        Console.WriteLine("Enter how many numbers you need:");
                        int n7 = int.Parse(Console.ReadLine());
                        int[] intput = new int[n7];
                        bool Check = false;
                        for (int i = 0; i < n7; i++)
                        {
                            Console.WriteLine("Enter number:");
                            intput[i] = int.Parse(Console.ReadLine());
                        }

                        for (int i = 0; i < n7; i++)
                        {
                            for (int j = (i + 1); j < n7; j++)
                            {
                                if (intput[i] == intput[j])
                                {

                                    Check = true;
                                    Console.WriteLine("has duplicate numbers");
                                    break;


                                }
                            }
                        }

                        if (!Check)
                        {
                            Console.WriteLine("no duplicate numbers");

                        }


                        break;

                    case 9:
                        Console.WriteLine("Enter how many numbers you need");
                        int n8 = int.Parse(Console.ReadLine());
                        int[] arr1 = new int[n8];

                        Console.WriteLine("Enter numbers in array one:");
                        for (int i = 0; i < n8; i++)

                            arr1[i] = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter how many numbers you need:");
                        int n88 = int.Parse(Console.ReadLine());
                        int[] arr2 = new int[n88];


                        Console.WriteLine("Enter numbers in array two:");
                        for (int i = 0; i < n88; i++)
                            arr2[i] = int.Parse(Console.ReadLine());


                        int[] arr3 = new int [arr1.Length + arr2.Length];
                        arr1.CopyTo(arr3, 0); 
                        arr2.CopyTo(arr3, arr1.Length);
                        Console.WriteLine("The merge array" + string.Join(", ", arr3));




                


       
                        break;
                    case 10:
                        Console.WriteLine("Enter how many number you need:");
                        int n9 = int.Parse(Console.ReadLine());
                        int[] input2= new int[n9];
                        int largest = int.MinValue;
                        int secondLargest = int.MinValue;
                        for(int i = 0; i < n9; i++)
                        {
                            Console.WriteLine("Enter a number");
                            input2[i]=int.Parse(Console.ReadLine());

                        }
                        for(int i = 0;i < input2.Length; i++)
                        {
                            if (input2[i]> largest)
                            {
                                secondLargest = largest;
                                largest = input2[i];
                            }


                            else if  (input2[i] > secondLargest && input2[i] != largest)
                            { 
                                     secondLargest = input2[i];
                            }
                        }
                        Console.WriteLine("Second largest number: " + secondLargest);
                        break;
                        case 11:
                        Console.WriteLine("Enter a Word:");
                        String word=Console.ReadLine();
                        
                        int leftWord = 0;
                        int rightWord = word.Length-1;
                        while (true)
                        {
                            if(leftWord < rightWord)
                            {
                                if(word[leftWord] != word[rightWord]){
                                    Console.WriteLine("The word is not plaindrome");
                                    break;
                               
                                }
                                else
                                {
                                    Console.WriteLine("The word is plaindrome");
                                    break;
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
