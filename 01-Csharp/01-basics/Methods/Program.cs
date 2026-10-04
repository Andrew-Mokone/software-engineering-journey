// Lesson 09
// Methods

static void sayHello()
{
    Console.WriteLine("Hello Andrew");
}

// this is how we call the Method
sayHello();

// Methods with parameters
static void addnumbers(int a, int b)
{

    Console.WriteLine(a + b);
}

// when calling a method with with parameteres we need to pass the arguments
addnumbers(10, 50);

// Methods that returns values
static int calculateRemaining(int salary, int expenses)
{
    return salary - expenses;
}

int result = calculateRemaining(15000, 11500);

if (result >= 5000) 
{
    Console.WriteLine("You have enough money left.");
}
else
{
    Console.WriteLine("Avoid spending too much money.");
}

Console.WriteLine(result);

static bool isAdult(int age)
{
    return age >= 18;
}

bool checkingAge = isAdult(30);

Console.WriteLine(checkingAge);

// 

static void printLanguages(List<string> languages)
{
    for (int i = 0; i < languages.Count; i++)
    {
        Console.WriteLine(languages[i]);
    }
}

List<string> languages = new List<string>();

languages.Add("C#");
languages.Add("JavaScript");
languages.Add("TypeScript");

printLanguages(languages);

// Let's create a method that finds the even numbers in a list.

static void findEvenNumbers(List<int> numbers) 
{
    for (int i = 0; i < numbers.Count; i++) 
    {
        if (numbers[i] % 2 == 0) 
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);

findEvenNumbers(numbers);

// Suppose we want a method that tells us how many even numbers are in the list.
static int CountEvenNumbers(List<int> num)
{
    int count = 0;
    for (int i = 0; i < num.Count; i++) 
    {
        if (num[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

List<int> num = new List<int>();

num.Add(10);
num.Add(15);
num.Add(20);
num.Add(25);
num.Add(30);

int total = CountEvenNumbers(num);
Console.WriteLine(total);

static int CountNumbersGreaterThan10(List<int> nums)
{
    int counter = 0;
    for (int i = 0;i < nums.Count;i++)
    {
        if (nums[i] > 10)
        {
            counter++;
        }
    }
    return counter;
}

List<int> nums = new List<int>();

nums.Add(5);
nums.Add(12);
nums.Add(8);
nums.Add(20);
nums.Add(15);

int relts = CountNumbersGreaterThan10(nums);
Console.WriteLine(relts);

// Method overloading, same method name and differnt parameters
static int Add(int a, int b)
{
    return a + b;
}

static int Add(int a, int b, int c)
{
    return a + b + c;
}