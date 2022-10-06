// №10, вторая цифра трехзначного числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = (n/10)%10;
Console.WriteLine(result);

