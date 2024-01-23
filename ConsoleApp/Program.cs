string name, pw;

Console.WriteLine("name: ");
name = Console.ReadLine();

if (name == "easyReversing")
{
    Console.WriteLine("pasword: ");
    pw = Console.ReadLine();
    if(pw == "1111")
    {
        Console.WriteLine("Success!!");
    }
    else
    {
        Console.WriteLine("Wrong password");
    }
    
}
else
{
    Console.WriteLine("Wrong name");
}