using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class Immis
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задания: ");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {

            case 1:
                //Задача 1.2
                Console.WriteLine("====== Сумма двух последних знаков числа ====== \n");
                while (true)
                {
                    Console.WriteLine("Введите число (не менее двух знаков):");
                    string input1_2 = Console.ReadLine();

                    if (int.TryParse(input1_2, out int n1_2))
                    {
                        
                        if (Math.Abs(n1_2) < 10)
                        {
                            Console.WriteLine("Ошибка! Число должно иметь не менее двух знаков!");
                            continue;
                        }
                        Immis task1_2 = new Immis();
                        int result1_2 = Math.Abs(task1_2.sumLastNums(n1_2));
                        Console.WriteLine("Сумма двух последних знаков числа: " + result1_2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Нужно ввести целое число!");
                    }
                }
                break;

            case 2:
                //Задача 1.4 
                Console.WriteLine("====== Возврат true, если число положительное ====== \n");
                while (true)
                {
                    Console.WriteLine("Введите число: ");
                    string input1_4 = Console.ReadLine();
                    if (int.TryParse(input1_4, out int n1_4))
                    {
                        Immis task1_4 = new Immis();
                        Console.WriteLine(task1_4.isPositive(n1_4));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Некорректный ввод.");
                    }
                }
                break;

            case 3:
                //Задача 1.6 
                Console.WriteLine("====== Проверка на то, заглавная буква или нет ====== \n");
                Console.WriteLine("Введите заглавную букву латинского алфавита: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                {
                    char letter = input[0];

                    Immis task1_6 = new Immis();
                    Console.WriteLine(task1_6.isUpperCase(letter));
                }
                else
                {
                    Console.WriteLine("Несоответствие условию задания. Введите одну латинскую букву");
                }
                break;

            case 4:
                //Задание 1.8
                Console.WriteLine("====== Проверка того, делится ли одно число нацело на другое ====== \n");
                int a, b;
                while (true)
                {
                    Console.WriteLine("Введите число a: ");
                    string inputA1_8 = Console.ReadLine();
                    if (int.TryParse(inputA1_8, out a))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите корректное целое число для a.");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Введите число b: ");
                    string inputB1_8 = Console.ReadLine();
                    if (int.TryParse(inputB1_8, out b))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите корректное целое число для b.");
                    }
                }
                Immis task1_8 = new Immis();
                Console.WriteLine(task1_8.isDivisor(a, b));
                break;

            case 5:
                //Задание 5
                Console.WriteLine("====== Сумма двух чисел из разряда единиц ====== \n");
                int A;
                while (true)
                {
                    Console.WriteLine("Введите число a: ");
                    if (int.TryParse(Console.ReadLine(), out A))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите корректное целое число a.");
                    }
                }

                Immis task1_10 = new Immis();
                for (int i = 1; i < 5; i++)
                {
                    int B;
                    while (true)
                    {
                        Console.WriteLine("Введите число b: ");
                        if (int.TryParse(Console.ReadLine(), out B))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите корректное целое число b.");
                        }
                    }

                    int otvet = task1_10.LastNumSum(A, B);
                    Console.WriteLine(A + " + " + B + " это " + otvet);
                    A = otvet;
                }

                break;

            case 6:
                //Задание 2.2 
                Console.WriteLine("====== Безопасное деление (при делении на ноль программа просто выведет ноль) ====== \n");
                Immis task2_2 = new Immis();
                Console.WriteLine("Введите число x: ");
                int numx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число y: ");
                int numy = Convert.ToInt32(Console.ReadLine());
                double result2_2 = task2_2.safeDiv(numx, numy);
                Console.WriteLine("Результат: " + result2_2);
                break;

            case 7:
                //Задание 2.4
                Console.WriteLine("====== Больше-меньше ====== \n");
                Immis task2_4 = new Immis();
                Console.WriteLine("Введите первое число: ");
                int chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int chislo2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Результат: " + task2_4.makeDecision(chislo1, chislo2));
                break;

            case 8:
                //Задание 2.6 
                Console.WriteLine("====== Возвращает true, если два любых числа можно сложить для получения третьего ====== \n");
                Immis task2_6 = new Immis();
                Console.WriteLine("Введите первое число: ");
                int chisloX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int chisloY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третье число: ");
                int ChisloZ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + task2_6.sum3(chisloX, chisloY, ChisloZ));
                break;

            case 9:
                //Задание 2.8 (более-менее дурак)
                Console.WriteLine("====== Возраст ====== \n");
                Immis task2_8 = new Immis();
                Console.WriteLine("Введите целое число x: ");
                string input2_8 = Console.ReadLine();
                if (int.TryParse(input2_8, out int age))
                {
                    if (age > 0)
                    {
                        Console.WriteLine("Результат: " + task2_8.age(age));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Возраст не может быть отрицательным значением");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                }
                break;

            case 10:
                //Задание 2.10 (без дурака)
                Console.WriteLine("====== Буквально... ввести день недели ====== \n");
                Immis task2_10 = new Immis();
                Console.WriteLine("Введите день недели: ");
                string day = Console.ReadLine();
                Console.WriteLine("Результат: ");
                task2_10.printDays(day);
                break;


            case 11:
                //Задание 3.2 (пока без дурки)
                Console.WriteLine("====== Выводит все числа от введенного до нуля ====== \n");
                Immis task3_2 = new Immis();
                Console.Write("Введите число x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                string result = task3_2.reverseListNums(x);
                Console.WriteLine("Результат: " + result);
                break;

            case 12:
                //Задание 3.4
                Console.WriteLine("====== Возведение в степень ====== \n");
                Immis task3_4 = new Immis();
                Console.Write("Введите число x: ");
                int numpow = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите степень числа x: ");
                int numpowy = Convert.ToInt32(Console.ReadLine());
                if (numpowy < 0)
                {
                    Console.Write("нужна положительная степень");
                }
                else
                {
                    Console.WriteLine("Результат: " + task3_4.pow(numpow, numpowy));
                }
                break;

            case 13:
                //Задание 3.6
                Console.WriteLine("====== Проверка на то, все ли знаки в числе одинаковы ====== \n");
                Immis task3_6 = new Immis();
                Console.Write("Введите число x: ");
                int task3_6x = Convert.ToInt32(Console.ReadLine());
                bool resultx = task3_6.equalNum(task3_6x);
                Console.WriteLine($"Результат: {resultx}");
                break;

            case 14:
                //Задание 3.8
                Console.WriteLine("====== Строит треугольник (введенное число - его высота) ====== \n");
                Immis task3_8 = new Immis();
                Console.WriteLine("Введите число x: ");
                int task3_8x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: ");
                task3_8.leftTriangle(task3_8x);

                break;

            case 15:
                //Задание 3.10
                Immis task3_10 = new Immis();
                Console.WriteLine("========= Игра-угадайка: нужно отгадать число от 0 до 9 ========= \n");
                task3_10.guessGame();
                
                break;

            case 16:
                //Задание 4.2
                Console.WriteLine("========= Вывод индекса найденного элемента ========= \n");
                Immis task4_2 = new Immis();
                Console.WriteLine("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                if (size < 0)
                {
                    Console.WriteLine("Ошибка! Размерность массива не может быть отрицательным числом!");
                }
                else
                {
                    int[] arr = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Введите {i + 1} элемент массива: ");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        arr[i] = elem;
                    }
                    Console.Write("Введите число, индекс которого нужно найти: ");
                    int goal = Convert.ToInt32(Console.ReadLine());
                    int answ = task4_2.findLast(arr, goal);

                    if (answ == -1)
                    {
                        Console.Write("Этого элемента нет в массиве");
                    }
                    else
                    {
                        Console.Write("Индекс последнего вхождения этого элемента: " + answ);
                    }
                }
                break;

            case 17:
                //Задание 4.4
                Immis task4_4 = new Immis();
                Console.WriteLine("Введите размер массива: ");
                int size1 = Convert.ToInt32(Console.ReadLine());
                if (size1 < 0)
                {
                    Console.WriteLine("Ошибка! Размерность массива не может быть отрицательным числом!");
                }
                else
                {
                    int[] arr1 = new int[size1];
                    for (int i = 0; i < size1; i++)
                    {
                        Console.Write($"Введите {i + 1} элемент массива: ");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        arr1[i] = elem;
                    }
                    Console.Write("Введите число, которое нужно добавить в массив: ");
                    int target = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите позицию для этого числа: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    if (pos > arr1.Length  || pos < 0)
                    {
                        Console.Write("Ошибка! Нельзя выходить за границы массива!");
                    }
                    else
                    {
                        int[] resultarr = task4_4.add(arr1, target, pos);
                        Console.Write("Результат: " + string.Join(", ", resultarr));
                    }
                }

                break;

            case 18:
                //Задание 4.6
                Immis task4_6 = new Immis();
                Console.WriteLine("Введите размер массива: ");
                int size2 = Convert.ToInt32(Console.ReadLine());
                if (size2 < 0)
                {
                    Console.WriteLine("Ошибка! Размерность массива не может быть отрицательным числом!");
                }
                else
                {
                    int[] arr2 = new int[size2];
                    for (int i = 0; i < size2; i++)
                    {
                        Console.Write($"Введите {i + 1} элемент массива: ");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        arr2[i] = elem;
                    }
                    task4_6.reverse(arr2);
                    Console.Write("Результат: " + string.Join(", ", arr2));
                }

                break;

            case 19:
                //Задание 4.8
                Immis task4_8 = new Immis();
                Console.WriteLine("Введите размер 1 массива: ");
                int size3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите размер 2 массива: ");
                int size3_1 = Convert.ToInt32(Console.ReadLine());
                if (size3 < 0 || size3_1 < 0)
                {
                    Console.WriteLine("Ошибка! Размерность массива не может быть отрицательным числом!");
                }
                else
                {
                    int[] arr4_8 = new int[size3];
                    for (int i = 0; i < size3; i++)
                    {
                        Console.Write($"Введите {i + 1} элемент 1 массива: ");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        arr4_8[i] = elem;
                    }
                    int[] arr4_8_2 = new int[size3_1];

                    for (int j = 0; j < size3_1; j++)
                    {
                        Console.Write($"Введите {j + 1} элемент 2 массива: ");
                        int elem3_1 = Convert.ToInt32(Console.ReadLine());
                        arr4_8_2[j] = elem3_1;

                    }
                    int[] result4_2 = task4_8.concat(arr4_8, arr4_8_2 );
                    Console.Write("Результат: " + string.Join (", ", result4_2));
                }        



               break;

            case 20:
                //Задание 4.10
                Immis task4_10 = new Immis();
                Console.WriteLine("Введите размер массива: ");
                int size4_10 = Convert.ToInt32(Console.ReadLine());
                if (size4_10 < 0)
                {
                    Console.WriteLine("Ошибка! Размерность массива не может быть отрицательным числом!");
                }
                else
                {
                    int[] arr4_10 = new int[size4_10];
                    for (int i = 0; i < size4_10; i++)
                    {
                        Console.Write($"Введите {i + 1} элемент массива: ");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        arr4_10[i] = elem;
                    }
                    int[] result4_10 = task4_10.deleteNegative(arr4_10);
                    Console.Write("Результат: " + string.Join(", ", result4_10));
                }
                    break;


            default:
                Console.WriteLine("Z t,fk hjn 'njuj cbynfrcbcf");
                break;

        }


    }
    //Задача 1.2
    public int sumLastNums(int x)
    {
        int dig = x % 100;
        int dig1 = dig % 10;
        int dig2 = dig / 10;
        int result = dig1 + dig2;
        Math.Abs(result);
        return result;

    }
    //Задача 1.4
    public bool isPositive(int x)
    {
        if (x > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Задача 1.6
    public bool isUpperCase(char x)
    {
        if (x >= 'A' && x <= 'Z')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Задача 1.8
    public bool isDivisor(int a, int b)
    {
        if ((a != 0 && b % a == 0) || (b != 0 && a % b == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Задача 1.10
    public int LastNumSum(int a, int b)
    {
        int num1 = Math.Abs(a % 10);
        int num2 = Math.Abs(b % 10);
        return num1 + num2;
    }

    //Задача 2.2
    public double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }
        else
        {
            return (double)x / y;
        }
    }


    //Задача 2.4
    public String makeDecision(int x, int y)
    {
        if (x > y)
        {
            return $"{x} > {y}";
        }
        else if (x < y)
        {
            return $"{x} < {y}";
        }
        else
        {
            return $"{x}=={y}";
        }
    }

    //Задача 2.6
    public bool sum3(int x, int y, int z)
    {
        if ((x + y == z) || (x + z == y) || (y + z == x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Задача 2.8
    public String age(int x)
    {
        if (x % 10 == 1 && x != 11)
        {
            return $"{x} год";
        }
        else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && (x != 12 || x != 13 || x !=14))
        {
            return $"{x} года";
        }
        else
        {
            return $"{x} лет";
        }
    }

    //Задача 2.10
    public void printDays(String x)
    {
        string day = x.ToLower();
        switch (day)
        {
            case "понедельник":
                Console.WriteLine("Понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("Вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("Среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("Четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("Пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("Суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;

        }
    }

    //задание 3.2
    public String reverseListNums(int x)
    {
        string result = ""; 

        if (x > 0)
        {
            for (int i = x; i >= 0; i--)
            {
                result += i + " "; 
            }
        }
        else
        {
            for (int i = x; i <= 0; i++)
            {
                result += i + " "; 
            }
        }

        return result.Trim(); 
    }

    //Задание 3.4
    public int pow(int x, int y) {
        int numpow = 1;
        for (int i = y; i > 0; i--)
        {
            numpow *= x;
        }
        return numpow;
    }

    //Задание 3.6
    public bool equalNum(int x)
    {
        //С отрицательными числами программа работает некорректно, поэтому мутим такие вот костыли
        x = Math.Abs(x);
        int lastdigit = x % 10;

        while (x > 0)
        {
            if (x % 10 != lastdigit)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }

    //Задание 3.8
    public void leftTriangle(int x)
    {
        string tri = "";
        for (int i = 1; i <= x; i++)
        {
            int count = 0;
            while (count < i)
            {
                tri += "*";
                count++;
            }
            tri += "\n";
        }
        Console.WriteLine(tri);
        
    }
    
    //Задание 3.10
    public void guessGame()
    {
        Random rnd = new Random();
        int target = rnd.Next(0, 10);

        int attempts = 1;
        Console.WriteLine("Введите число от 0 до 9");
        int value = Convert.ToInt32(Console.ReadLine());

        while(value != target) {
            Console.WriteLine("Вы не угадали, введите число от 0 до 9");
            attempts++;
            value = Convert.ToInt32(Console.ReadLine());
        }
        if(value == target && attempts % 10 == 1)
        {
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы угадали число за {attempts} попытку");
        }
        else if (value == target && attempts == 0)
        {
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы угадали число за 1 попытку");
        }
        else if (value == target && (attempts % 10 != 1 && attempts % 10 != 5 && attempts % 10 != 6 && attempts % 10 != 7 && attempts % 10 != 8 && attempts % 10 != 9 && attempts % 10 != 0))
        {
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы угадали число за {attempts} попытки");
        }
        else
        {
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы угадали число за {attempts} попыток");
        }
  
    }


    //Задание 4.2
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
            
            
        }
        return -1;
        
    }

    //Задание 4.4
    public int[] add(int[] arr, int x, int pos)
    {
        int[] newArr = new int[arr.Length + 1];
        int newIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (newIndex == pos)
            {
                newArr[newIndex++] = x;
            }
            newArr[newIndex++] = arr[i];
        }


        if (pos == arr.Length)
        {
            newArr[newIndex] = x;
        }

        return newArr;
    }

    //Задание 4.6
    public void reverse(int[] arr) {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end) 
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
        
    }

    //Задание 4.8
    public int[] concat(int[] arr1, int[] arr2)
    {
        
        int[] newArr = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            newArr[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            newArr[arr1.Length + i] = arr2[i];
        }

        return newArr;
    }

    //Задание 4.10
    public int[] deleteNegative(int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }
        int[] newArr = new int[count];

        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                newArr[index++] = arr[i];

            }
        }
            return newArr;
    }
}


    

