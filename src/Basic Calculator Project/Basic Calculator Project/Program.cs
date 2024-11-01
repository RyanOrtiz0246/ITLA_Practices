using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<decimal> typedNumbers;
        decimal result;
        int typedOption = 1;

        while (typedOption != 5)
        {
            typedNumbers = new List<decimal>();
            result = 0;
            int wantToContinue = 0;

            DisplayHeader();

            try
            {
                typedOption = Convert.ToInt32(Console.ReadLine());

                if (typedOption == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.WriteLine("Please Type the first number");
                typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

                Console.WriteLine("Please Type the second number");
                typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

                while (wantToContinue != 2)
                {
                    Console.WriteLine("Do you want to continue inserting numbers? 1. Yes, 2. No");
                    wantToContinue = Convert.ToInt32(Console.ReadLine());
                    if (wantToContinue == 1)
                    {
                        Console.WriteLine("Please Type another number");
                        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
                    }
                }

                switch (typedOption)
                {
                    case 1:
                        {
                            // Sum all numbers in the list
                            result = AddList(typedNumbers);
                        }
                        break;
                    case 2:
                        {
                            // Subtract all numbers in the list
                            result = SubtractList(typedNumbers);
                        }
                        break;
                    case 3:
                        {
                            // Multiply all numbers in the list
                            result = MultiplyList(typedNumbers);
                        }
                        break;
                    case 4:
                        {
                            // Divide all numbers in the list
                            result = DivideList(typedNumbers);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        continue;
                }

                Console.WriteLine($"The Result of the operation is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"You cannot divide by zero: {ex.Message}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Arithmetic error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You need to choose a correct option: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Closing Db Connection");
            }
        }
    }

    // Sum function
    static decimal Add(decimal valueToModify, decimal value)
    {
        valueToModify += value;
        return valueToModify;
    }

    // Sum all numbers in a list
    static decimal AddList(List<decimal> typedNumbers)
    {
        decimal result = 0;
        foreach (decimal typedNumber in typedNumbers)
        {
            result = Add(result, typedNumber);
        }
        return result;
    }

    // Subtract all numbers in a list
    static decimal SubtractList(List<decimal> typedNumbers)
    {
        decimal result = typedNumbers[0];
        for (int i = 1; i < typedNumbers.Count; i++)
        {
            result -= typedNumbers[i];
        }
        return result;
    }

    // Multiply all numbers in a list
    static decimal MultiplyList(List<decimal> typedNumbers)
    {
        decimal result = 1;
        foreach (decimal number in typedNumbers)
        {
            result *= number;
        }
        return result;
    }

    // Divide all numbers in a list
    static decimal DivideList(List<decimal> typedNumbers)
    {
        decimal result = typedNumbers[0];
        for (int i = 1; i < typedNumbers.Count; i++)
        {
            if (typedNumbers[i] == 0)
                throw new DivideByZeroException("Division by zero encountered.");
            result /= typedNumbers[i];
        }
        return result;
    }

    // Display calculator header
    static void DisplayHeader()
    {
        Console.WriteLine("This is the best calculator");
        Console.WriteLine("Please type the option number you want");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1. Sum, \n2. Subtract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");
    }
}