//Запрос на ввод чисел
Console.WriteLine("Введите число А");
int NumA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int NumB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C");
int NumC = int.Parse(Console.ReadLine());
//Сортировка чисел
int Mem = NumA;
if (NumA > NumB){
    Mem = NumB;
    NumB = NumA;
    NumA = Mem;
}
if (NumB > NumC){
    Mem = NumC;
    NumC = NumB;
    NumB = Mem;
}
if (NumB < NumA){
    Mem = NumA;
    NumA = NumB;
    NumB = Mem;
}
//Вывод решения
Console.WriteLine("Наибольшее число ");
Console.WriteLine(NumC);
