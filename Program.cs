//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
