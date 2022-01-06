//Calulator();
//myArrays();
myStrings();

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

void myStrings()
{
    string s1 = "У меня плохо с фантазией.";

    //Contains
    Console.WriteLine("Задание для метода Contains.\n");

    string sContains = "плохо";
    if (s1.Contains(sContains))
        Console.WriteLine(true);
    else Console.WriteLine(false + "\n");

    //Compare
    Console.WriteLine("Задание для метода Compare.\n");

    string sCompare1 = "Витязев";
    string sCompare2 = "Волобуев";

    int result = string.Compare(sCompare1, sCompare2);
    if (result < 0) Console.WriteLine($"Фамилия \"{sCompare1}\" перед \"{sCompare2}\".");
    else if (result > 0) Console.WriteLine($"Фамилия \"{sCompare2}\" перед \"{sCompare1}\".");
    else Console.WriteLine("Фамили одинаковые.");

    Console.WriteLine("\n");

    //Indexof
    Console.WriteLine("Задание для метода Indexof.\n");

    char sIndexof1 = 'ф';
    int IndexofChar = s1.IndexOf(sIndexof1);
    Console.WriteLine($"Индекс буквы \"ф\" в тексте: {IndexofChar}");

    string substring = "плохо";
    int indexofSubstring = s1.IndexOf(substring);
    Console.WriteLine($"Слово плохо в тексте начинается с индекса: {indexofSubstring}\n");

    //Concat
    Console.WriteLine("Задание для метода Concat.\n");

    string s3 = "Я есть\t";
    string s4 = "ГРУТ!";
    string sSample = s3 + s4;
    string sConcat = string.Concat(s3, s4);

    Console.WriteLine($"Два примера соединения строк просто через \"+\" и методом Concat:\n {sSample}\n {sConcat}\n");

    //Join
    Console.WriteLine("Задание для метода Join.\n");
    string sJoin1 = "Apple";
    string sJoin2 = "Pen";

    string[] valuse = new string[] { sJoin1, sJoin2 };
    string sJoinResult = string.Join("пшёлнахой", valuse);

    Console.WriteLine(sJoinResult + "\n");

    //EndWith, StartWith
    Console.WriteLine("Задание для методов EndWith, StartWith.\n");

    var files = new string[]
    {
        "Zahar.exe",
        "Kirill.god",
        "Zhenya.png"
    };
    
    for (int i =0; i < files.Length; i++)
    {
        if (files[i].EndsWith("exe")) Console.WriteLine(files[i]);

        if (files[i].StartsWith("Kiri")) Console.WriteLine(files[i]);

        if (files[i].StartsWith("Z")) Console.WriteLine(files[i] + "\n");
    }

    //Split
    Console.WriteLine("Задание для метода Split.\n");
    
    string[] wordsInSplit = s1.Split(new char[] { ' ' });

    foreach (string s in wordsInSplit) Console.WriteLine(s);

    Console.WriteLine("\n");

    //Trim
    Console.WriteLine("Задание для метода Trim.\n");

    string sampleTrim = "   Пример для Trim   ";
    Console.WriteLine(sampleTrim.Trim());
    sampleTrim = sampleTrim.Trim();
    sampleTrim = sampleTrim.Trim(new char[] { 'П', 'm' });

    Console.WriteLine($@"Результат после\t  sampleTrim = sampleTrim.Trim(new char[] { 'П','m' }) будет\n {sampleTrim}\n");

    //Substring
    Console.WriteLine("Задание для метода Substring.\n");

    //s1 = "У меня плохо с фантазией."
    Console.WriteLine(s1);
    s1 = s1.Substring(3);
    Console.WriteLine($"s1 после s1 = s1.Substring(3) =\t {s1}");
    s1 = s1.Substring(0, s1.Length-1);
    Console.WriteLine($"s1 после s1 = s1.Substring(0, s1.Lenght-1) =\t {s1}\n");

    //Insert
    Console.WriteLine("Задание для метода Insert.\n");

    string textInsert = "У меня хорошо с фантазией!";
    Console.WriteLine(textInsert);
    string substringInsert = " (не) ";
    Console.WriteLine(substringInsert);
    textInsert = textInsert.Insert(6, substringInsert);
    Console.WriteLine($"Пример работы метода Insert:\n {textInsert}\n");

    //Remove
    Console.WriteLine("Задание для метода Remove.\n");

    string sRemove = "Я ужасный программист:(";
    Console.WriteLine(sRemove);
    int smileIndex = sRemove.Length - 2;
    sRemove = sRemove.Remove(smileIndex);
    Console.WriteLine($"Пример текста после операции:\t sRemove = sRemove.Remove(smileIndex) =\t {sRemove}");
    sRemove = sRemove.Remove(2, 8);
    Console.WriteLine($"Пример текста после операции:\t sRemove = sRemove.Remove(2, 8); =\t {sRemove}\n");

    //Replace
    Console.WriteLine("Задание для метода Replace.\n");

    string sReplace = "Я ужасный программист.";
    Console.WriteLine(sReplace);
    sReplace = sReplace.Replace("ужасный", "хороший");
    sReplace = sReplace.Replace(".", "!");

    Console.WriteLine($"Результат работы Replace:\t {sReplace}");


}