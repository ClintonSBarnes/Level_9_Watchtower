// See https://aka.ms/new-console-template for more information
string userXValue;
string userYValue;
int xValue;
int yValue;
string direction;


Console.WriteLine("What is the X value of the attack? ");
userXValue = Console.ReadLine();
Console.WriteLine("What is the Y value of the attack? ");
userYValue = Console.ReadLine();

xValue = Convert.ToInt32(userXValue);
yValue = Convert.ToInt32(userYValue);

if (xValue < 0 && yValue < 0)
{
    direction = "Southwest";
}
else if (xValue > 0 && yValue > 0)
{
    direction = "Northeast";

}
else if (xValue < 0 && yValue > 0)
{
    direction = "Northwest";
}
else if (xValue < 0 && yValue == 0)
    {
    direction = "West";
}
else if (xValue == 0 && yValue > 0)
{
    direction = "North";
}
else if (xValue == 0 && yValue < 0)
{
    direction = "South";
}
else if (xValue  > 0 && yValue == 0)
{
    direction = "East";
}
else 
    direction = "Southeast";


Console.WriteLine("The enemy is coming from the "+direction+"!!!");


