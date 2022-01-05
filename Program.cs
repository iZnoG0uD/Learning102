Console.WriteLine("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
string sight;

Console.WriteLine("Введите знак операции: +, -, *, /, sqrt, ^");
sight = Console.ReadLine();

switch (sight)
{
    case "+":
        Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
        break;
    
    case "-":
        Console.WriteLine("{0} - {1} = {2}", number1, number2, (number1 - number2));
        break;

    case "*":
        Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
        break;

    case "/":
        Console.WriteLine("{0} / {1} = {2}", number1, number2, (number1 / number2));
        break;

    case "sqrt":
        Console.WriteLine(Math.Sqrt(number1));
        break;

    case "^":
        Console.WriteLine($"{number1} ^ {number2} = {Math.Pow(number1, number2)}");
        break;

    default:
        Console.WriteLine("Введите правильный знак");
        break;
}
Console.WriteLine("Усё!");