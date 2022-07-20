Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
void ShifterNumber(int num)
{
    int lastNum = num % 10;
    int firstNum = num / 10000;
    if (firstNum == lastNum)
    {
        lastNum = (num % 100) / 10;
        firstNum = (num / 1000) % 10;
        if (firstNum == lastNum) 
        Console.WriteLine($"{num} -> ДА");  
        else Console.WriteLine($"{num} -> Нет!"); 
    }
     else Console.WriteLine($"{num} -> Нет!");        
    
}
ShifterNumber(number);




