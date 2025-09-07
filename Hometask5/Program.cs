#region Task1 Calculating the average salary

bool isLoopActive = true;
decimal salary = 0;
decimal totalSalary = 0;
byte numberOfEmployees = 0;

while (isLoopActive)
{
    Console.WriteLine($"Enter the {numberOfEmployees + 1} employee's salary (or 0 to calculate the average salary): ");

    bool isParsed = decimal.TryParse(Console.ReadLine(), out salary);

    if (isParsed && salary >= 0)
    {
        if (salary == 0 && numberOfEmployees > 0)
        {
            Console.WriteLine("Average salary is " + totalSalary / numberOfEmployees);
            break;
        }
        else if (salary == 0 && numberOfEmployees == 0)
        {
            Console.WriteLine("You should enter at least one employee's salary");
        }
        else
        {
            totalSalary += salary;
            numberOfEmployees++;
        }
    }
    else
        Console.WriteLine("Incorrect data");

}
#endregion




//#region Task2 Graph construction

//Console.WriteLine("Enter the number of lines");
//byte numberOflines;

//bool isParsed = byte.TryParse(Console.ReadLine(), out numberOflines);
//if (isParsed)
//{
//    for (int i = 0; i < numberOflines; i++)
//    {
//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}
//else
//    Console.WriteLine("Incorrect data");
//#endregion




//#region Task3 Prime numbers generation

//Console.Write("Enter the number: ");
//int number;
//bool isParsed = int.TryParse(Console.ReadLine(), out number);
//if (isParsed)
//{
//    Console.WriteLine($"Prime numbers from 1 to {number} are:");
//    for (int i = 2; i <= number; i++)
//    {
//        int j = 2;
//        while (j < i)
//        {
//            if (i % j != 0)
//                j++;
//            else
//                break;
//        }
//        if (i == j)
//            Console.WriteLine(i);
//    }
//}
//else
//    Console.WriteLine("Incorrect data");
//#endregion




//#region Task4 Password check

//Console.WriteLine("Enter the password. It must contain at least 8 characters including letters, numbers and special characters:");
//string password = Console.ReadLine();

//byte length = 0;
//bool containsDigit = false;
//bool containsLetter = false;
//bool containsSpecChar = false;

//foreach (char ch in password)
//{
//    if (Char.IsDigit(ch))
//        containsDigit = true;
//    if (Char.IsLetter(ch))
//        containsLetter = true;
//    if (!Char.IsDigit(ch) && !Char.IsLetter(ch))
//        containsSpecChar = true;
//    length++;
//}
//if (containsDigit && containsLetter && containsSpecChar && length >= 8)
//    Console.WriteLine("Password is acceptable");
//else
//    Console.WriteLine("Password isn't acceptable");
//#endregion




//#region Task5 Fibonacci sequence

//Console.Write("Enter the number of Fibonacci numbers: ");

//uint number;
//int previousValue = 0;
//int currentValue = 1;

//bool isParsed = uint.TryParse(Console.ReadLine(), out number);
//if (isParsed)
//{
//    for (int i = 0; i < number; i++)
//    {
//        Console.Write($"{currentValue}\t");
//        currentValue += previousValue;
//        previousValue = currentValue - previousValue;
//    }
//}
//else
//    Console.WriteLine("Incorrect data");
//#endregion




//#region Task6 Salary calculator

//bool isLoopActive = true;
//decimal hourlySalary = 0;
//decimal dailySalary = 0;
//byte hoursWorked = 0;

//while (isLoopActive)
//{
//    Console.WriteLine("Enter the number of hours worked (or 0 to calculate the daily salary):");

//    bool isParsed = byte.TryParse(Console.ReadLine(), out hoursWorked);

//    if (isParsed)
//    {
//        if (hoursWorked == 0 && dailySalary == 0)
//            Console.WriteLine("You should enter at least one number of hours worked and hourly salary for these hours");

//        else if (hoursWorked == 0 && dailySalary != 0)
//        {
//            Console.WriteLine($"Daily salary is {dailySalary}");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Enter the hourly salary for these hours:");

//            isParsed = decimal.TryParse(Console.ReadLine(), out hourlySalary);

//            if (isParsed && hourlySalary > 0)
//                dailySalary += hourlySalary * hoursWorked;
//            else
//                Console.WriteLine("Incorrect data");
//        }
//    }
//    else
//        Console.WriteLine("Incorrect data");
//}
//#endregion




//#region Task7 Multiplication table

//Console.Write("Enter the number: ");
//int number;
//bool isParsed = int.TryParse(Console.ReadLine(), out number);
//if (isParsed)
//{
//    for (int i = 1; i < 10; i++)
//    {
//        Console.WriteLine($"{number} * {i} = {number * i}");
//    }
//}
//else
//    Console.WriteLine("Incorrect data");
//#endregion




//#region Task8 Prime number checking

//Console.Write("Enter the number: ");
//int number;
//bool isParsed = int.TryParse(Console.ReadLine(), out number);
//if (isParsed)
//{
//    int i = 2;
//    while (i < number)
//    {
//        if (number % i != 0)
//            i++;
//        else
//            break;
//    }
//    if (i == number)
//        Console.WriteLine("The number is prime");
//    else
//        Console.WriteLine("The number isn't prime");
//}
//else
//    Console.WriteLine("Incorrect data");
//#endregion
