// Lesson 7 Loops
// #01 For Loop

// first part variable i starts at 1, 
// second part continue looping as long i is less than 5 0r eqauls to 5
// increment i by one i = i + 1; 

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


// for Loop with a condition

for (int i = 1; i <= 10; i++)
{
    if (i > 5) 
    {
        Console.WriteLine(i);
    }
}

// While Loop

int number = 1;

while (number <= 10) 
{
    if (number % 2 == 1) 
    {
        Console.WriteLine(number); 
    }

    number++;
}

// Lesson 7 — Arrays

string[] languages = { "C#", "JavaScript", "Typescript", "Angular" }

for (int i = 0; i < languages.Length; i++){
    Console.WriteLine(languages[i]);
}

int[] numbers = { 5, 12, 7, 20, 3, 18 };

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}

int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 25)
    {
        Console.WriteLine(numbers[i]);
    }
}

