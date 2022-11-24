// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("");
Console.WriteLine("Приветствую вас, Алексей! Введите номер задачи из домашнего задания для проверки(25, 27 или 29)");

int taskNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");

//Первая задача (25)
if (taskNumber == 25){

    Console.WriteLine("Задача 25.");
    Console.WriteLine("");

    Console.Write("Введите положительное целочисленное основание степени: ");
    int degreeBasis = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    Console.Write("Введите положительный целочисленный показатель степени: ");
    int degree = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    if (degree<0 || degreeBasis<0){
        Console.Write("Некоректный ввод!!! ");
    }
    else{
        int result = 1; 
        for(int i = 0; i<degree; i++){
            result = result * degreeBasis;
        }
    Console.Write($"Результатом возведения числа {degreeBasis} в степень {degree} является число {result}");
    }
}

//Вторая задача (27)
else if (taskNumber == 27){

    Console.WriteLine("Задача 27.");
    Console.WriteLine("");

    int DigitDef(int num, int digitsNumber){
        int result = num/(int)Math.Pow(10,digitsNumber-1);
        return result;
    }
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    
    int bufNumber = Math.Abs(number);
    int sum = 0;
    
    int digitCount =0;
    for(int i = 0; bufNumber>0; i++){
        bufNumber/=10;
        digitCount++;
    }
    
    bufNumber=Math.Abs(number);
    int digit=0;
    int firstDigit = 0;
    if (number<0){
        firstDigit = DigitDef(bufNumber,digitCount);
    }
    
    while(digitCount>0){        
        digit=DigitDef(bufNumber,digitCount);
        sum+=digit;
        bufNumber-=digit*(int)Math.Pow(10,digitCount-1);
        digitCount-=1;
    }

    Console.Write($"Сумми цифр вашего числа равна {sum}");
    if (number<0){
        Console.Write($". А с учетом знака: {sum-2*firstDigit}");
    }

}

//Третья задача (29)
else if (taskNumber == 29){

    Console.WriteLine("Задача 29.");
    Console.WriteLine("");

    int LengthInput(){
        Console.WriteLine("Введите длину массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        return len;
    }
    
    Console.WriteLine("Выберите способ заполнения массива: r - заполнение случайными числами, k - заполнение вручную с клавиатуры ");
    string? key = (Console.ReadLine());
    Console.WriteLine();

    int arrayLength = 0;
    int maxBorder = 0;
    int minBorder = 0;
    
    
    switch (key){
        case "k": {
            arrayLength = LengthInput();                 
            int[] array =new int[arrayLength];
            
            Console.WriteLine("Введите последовательно элементы массива");
            for (int i=0; i<arrayLength;i++ ){
                array[i]= Convert.ToInt32(Console.ReadLine());                
            }
            Console.Write('[' + string.Join(", ", array) + ']');
            break;
        }
        case "r":{
            arrayLength = LengthInput();
            int[] array = new int[arrayLength];
            
            Console.WriteLine("Введите нижнюю границу для значений элементов массива");
            minBorder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Введите верхнюю границу для значений элементов массива");
            maxBorder = Convert.ToInt32(Console.ReadLine()) +1;
            Console.WriteLine();
            for (int i=0; i<arrayLength;i++ ){
                array[i]= new Random().Next(minBorder,maxBorder);                
            }
            Console.Write('[' + string.Join(", ", array) + ']');
            break;
        }

        default:{
            Console.WriteLine("Такой вариант заполнеия массива не существует!");
            break;
        }
    }
    
}

else{
    Console.WriteLine("Увы, в этом блоке представлено только три задачи: 25, 27 и 29");
}

Console.WriteLine();
Console.WriteLine("Скорейшего выздоравления вам, Алексей. Всего доброго.");
Console.WriteLine();