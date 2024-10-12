


//برنامه ای بنویسید که اطلاعاتی مانند نام, سن و قد کاربر را از ورودی دریافت کند و روی صفحه نمایش دهد.

// برای اینکه مقادیر را از ورودی بکیریم ابتدا برای هر کدام یک پیغام مناسب به کاربر نمایش میدهیم و در مرحله بعد یک متغیر ایجاد میکنیم و آن را از کاربر دریافت میکنیم

Console.Write("Please enter your name: ");
string Name = Console.ReadLine();

Console.Write("Please enter your lastname: ");
string Lastname = Console.ReadLine();

Console.Write("Please enter your age: ");
int Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter height : ");
int Height = Convert.ToInt32(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Your name is: {Name}");
Console.WriteLine($"Your Lastname is: {Lastname}");
Console.WriteLine($"Your Age is: {Age}");
Console.WriteLine($"Your Height is: {Height}");

