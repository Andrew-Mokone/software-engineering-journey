// Lesson 05
// ComparisonOperators

//Is the age greater than 18?
//Is the age equal to 33?
//Is the age less than 40?
//Is the age not equal to 25?

int age = 36;

if (age > 18)
{
    Console.WriteLine("You are older than 18 years");
}
if (age == 33)
{
    Console.WriteLine("You are " + age + "years old");
}
if (age < 40)
{
    Console.WriteLine("You are less than 40 years");
}
if (age != 25)
{
    Console.WriteLine("You are not 25 years");
}

// Lesson 6 — Logical Operators

if (age >= 18 && age <= 35)
{
    Console.WriteLine("You are older than 18 and younger than 35");
}
else if (age <= 17 || age >= 36)
{
    Console.WriteLine("You do not qualify for this job post");
}

int age = 25;
bool hasDriverLicense = true;

if (age >= 18 && hasDriverLicense)
{
    Console.WriteLine("You can drive.");
}

if (!hasDriverLicense) 
{
    Console.WriteLine("You can not drive");
}