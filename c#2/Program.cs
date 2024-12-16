
//#region //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
//using System;
//using System.Transactions;

//Console.WriteLine("please enter number");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//if (number % 3 == 0 && number % 4 == 0)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}
//#endregion




//#region //2- write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
//console.writeline("please enter a number");
//int num;
//int.tryparse(console.readline(), out num);
//if (num < 1)
//{
//    console.writeline("negative");
//}
//else
//{
//    console.writeline("positive");
//}
//#endregion

//#region //3- Write a program that takes 3 integers from the user then prints the max element and the min element.


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("enter num1: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("enter num2: ");
//        int num2 = int.Parse(Console.ReadLine());

//        Console.Write("enter num3: ");
//        int num3 = int.Parse(Console.ReadLine());


//        int maxElement = Math.Max(num1, Math.Max(num2, num3));
//        int minElement = Math.Min(num1, Math.Min(num2, num3));


//        Console.WriteLine($"Max element = {maxElement}");
//        Console.WriteLine($"Min element = {minElement}");
//    }
//}


//#endregion



//#region //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

//using System;

//Console.WriteLine("please enter number:");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//if (number % 2 == 0)

//    Console.WriteLine("EVEN");
//else
//    Console.WriteLine("ODD");
//#endregion



//#region
////5Write a program that takes character from the user then if it is a vowel chars (a, e, I, o, u) then print (vowel) otherwise print (consonant).
//using System;

//Console.Write("please enter a character:");
//char character = (Console.ReadLine()[0]);
//if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
//{
//    Console.WriteLine("vowel");
//}
//else
//{
//    Console.WriteLine("consonant");
//}


//#endregion


//#region //7- Write a program that allows the user to insert an integer then 
////print a multiplication table up to 12.

//using System;

//Console.WriteLine("enter number");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine($"{number} × {i} = {number * i}");
//}

//#endregion

//#region //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

//using System;

//Console.WriteLine("please enter a number ");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//for (int i = 2; i <= number; i += 2)
//{
//    Console.WriteLine(i);
//}

//#endregion

//#region //9- Write a program that takes two integers then prints the power.
//using System;

//class Program
//{
//    static void Main()
//    {
//        int baseNum = int.Parse(Console.ReadLine());
//        int exponent = int.Parse(Console.ReadLine());
//        double result = Math.Pow(baseNum, exponent);
//        Console.WriteLine(result);
//    }
//}

//#region //11- Write a program to input the month number and print the number of days in that month.


//using System;

//class Program
//{
//    static void Main()

//    {
//        int month = int.Parse(Console.ReadLine());

//        int days;

//        switch (month)
//        {
//            case 1:
//            case 3:
//            case 5:
//            case 7:
//            case 8:
//            case 10:
//            case 12:
//                days = 31;
//                break;
//            case 4:
//            case 6:
//            case 9:
//            case 11:
//                days = 30;
//                break;
//            case 2:
//                days = 28;
//                break;
//            default:
//                days = -1;
//                break;
//        }

//        if (days == -1)
//            Console.WriteLine("Invalid month number");
//        else
//            Console.WriteLine($"The month has {days} days.");
//    }
//}


//#endregion

//#region //18
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the time taken to complete the task (in hours): ");
//        double timeTaken = double.Parse(Console.ReadLine());

//        if (timeTaken >= 2 && timeTaken <= 3)
//        {
//            Console.WriteLine("The worker is highly efficient.");
//        }
//        else if (timeTaken > 3 && timeTaken <= 4)
//        {
//            Console.WriteLine("The worker is instructed to increase their speed.");
//        }
//        else if (timeTaken > 4 && timeTaken <= 5)
//        {
//            Console.WriteLine("The worker is provided with training to enhance their speed.");
//        }
//        else if (timeTaken > 5)
//        {
//            Console.WriteLine("The worker is required to leave the company.");
//        }
//        else
//        {
//            Console.WriteLine("Invalid time entered.");
//        }
//    }
//}





//#endregion