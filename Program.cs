//Calulator();
myArrays();

void Calulator()
{
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
}

void myArrays()
{
    //for: найти среднее арифметическое всех чётных чисел
    int[] myArray = new int[10] {1, 0, 6, -8, 18, 9, 3, 12, 15, 7};
    int sum = 0;
    int k = 0;

    for (int j = 0; j <10; j++)
    {
        if (myArray[j] % 2 == 0)
        {
            sum = sum + myArray[j];
            k++;
        }
    }
    int taskFor = sum / k;
    Console.WriteLine($"Среднее арифметическое чётных чисел = {taskFor}");

    //do while: перебирать все значения с конца и при 0 выходить из массива
    int i = 9;
    int myIndex = 0;

    do
    {
        if (myArray[i] == 0)
        {
            myIndex = i;
            break;
        }
            
        --i;
    } while (i >= 0);
    Console.WriteLine($"Индекс 0 цифры в массиве - {myIndex}");

    //Задание для while
    int newI = 0;
    int newSum = 0;
    while (newI < 10)
    {
        if (myArray[newI] > 0)
            newSum += myArray[newI];
        newI++;
    }
    Console.WriteLine($"Сумма положительных чисел в массиве = {newSum}");

    //Задание для foreach
    int max = myArray[0];
    foreach (int value in myArray)
    {
        if (value > max)
            max = value;
    }
    Console.WriteLine($"Самое большое число в массиве - {max}");
}

