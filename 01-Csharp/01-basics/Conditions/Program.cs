// Lesson 04 
// conditions
// Learning if, else if and else statements
int monthlySalary = 15000;
int rent = 3500;
int transport = 2000;

int remainingSalary = monthlySalary - rent - transport;

Console.WriteLine("Salary: " + monthlySalary);
Console.WriteLine("Remaining: " + remainingSalary);

if (remainingSalary > 10000)
{
    Console.WriteLine("Excellent! You have a healthy amount left.");
}
else if (remainingSalary > 5000)
{
    Console.WriteLine("You have money left over.");
}
else
{
    Console.WriteLine("Watch your expenses");
}
