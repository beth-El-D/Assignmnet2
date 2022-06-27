// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t\t\t\tWELCOME TO BMI CALCULATER");
double height, weight,bmi;
String name;
String result;

do
{
    Console.WriteLine("Insert Name:");
    name = Console.ReadLine();
    Console.WriteLine("Insert Weight:");
    weight= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insert Height:");
    height= Convert.ToDouble(Console.ReadLine());
    bmi = (weight) / (height * height);
    //Console.WriteLine("BMI= " + bmi);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Weight: " + weight);
    Console.WriteLine("Height: " + height);
    Console.WriteLine("BMI: " + bmi);

    if (bmi < 18.5)
    {
        Console.WriteLine("You are underweight!");
    }

    else if (bmi > 24.9)
    {
        Console.WriteLine("You are overweight!");
    }
    else
    {
        Console.WriteLine("You have normal BMI");
    }

    Console.WriteLine("Do you want to calculate again? (Enter 'N' for No or 'Y' for Yes)");
    result = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine();

}while(result=="Y");

Console.WriteLine("Thanks for using!");
Console.ReadLine();

 