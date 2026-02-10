// TASK 1 Declare and initialize the following variables:
string Name = "John Doe";
int Age = 25;
bool isAdmin = true;

Console.WriteLine($"This user is {Name}, he is {Age} years old and  his admin status is {isAdmin}");

// Task 2:
// Write a program that takes an integer input from the user and prints out whether the number is even or odd.

// Take in a number
Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());  //parse the input to convert from string to integer

if (number % 2 == 0)
{
  // %2 checks if number is divisible by 2;
  Console.WriteLine("The number is even.");
}
else
{
  Console.WriteLine("The number is odd.");
}



// Task 3:
// Write a program that prints out the numbers 1 to 10 using a for loop.
// Use a for loop to iterate from 1 to 10.
// Print each number to the console.

for (int num = 1; num <= 10; num++)
{
  Console.WriteLine(num);
}



// Task 4: 
// Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
// Print the sum of all elements in the array to the console.
// Use a foreach loop to iterate over the array and print each element to the console.

// Declare and initialize the array
int[] numbers = { 2, 4, 6, 8, 10 };

int sum = 0;

// Use foreach loop to iterate and print each element
foreach (int n in numbers)
{
  Console.WriteLine(n);
  sum += n;
}

// Print the sum of all elements
Console.WriteLine("Sum of all elements: " + sum);



// Task 5:
// Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.
// The method should print "Hello, !" to the console.
// Call the Greet method from the Main method with the argument "Alice".

static void Greet(string name)
{
  Console.WriteLine($"Hello, {name}!");
}
Greet("Alice");