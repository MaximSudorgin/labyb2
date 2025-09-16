Console.WriteLine("Введите число");
double w = Convert.ToDouble(Console.ReadLine());
if ( w > -10 && w < 10)
{
    w += 5;

}
else
{
    w += -10;
}
Console.WriteLine("Ответ: " +  w);