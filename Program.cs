Console.WriteLine("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());

char znak;

Console.WriteLine("Введите знак операции: +, -, *, /");
znak = Convert.ToChar(Console.ReadLine());

switch (znak)
{
    case '+':
        Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
        break;
    
    case '-':
        Console.WriteLine("{0} - {1} = {2}", number1, number2, (number1 - number2));
        break;

    case '*':
        Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
        break;

    case '/':
        Console.WriteLine("{0} / {1} = {2}", number1, number2, (number1 / number2));
        break;

    default:
        Console.WriteLine("Введите правильный знак");
        break;
}
Console.WriteLine("Усё!");