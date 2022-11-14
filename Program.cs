Console.WriteLine("input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 2;

while(number2<=number1)
{
if(number2%2==0)
{
    Console.WriteLine(number2);
    number2=number2+1;
}
else number2=number2+1;
}
