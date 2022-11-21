/* TASK: 
 * 
 * I am going to store some numbers in two variables. After that, I will calculate their
sum into the third one.
 */

// 1. SOLUTION 
// Values to be summed
int firstNumber = 50;
int secondNumber = 100;

// Calculating 
int sum = firstNumber + secondNumber;

// Output
Console.WriteLine("Sum is: " + sum);

//2. SOLUTION
//Declaring all variables at once 

int thirdNumber, fourthNumber, newSum;

// Value to be summed 
thirdNumber = 50;
fourthNumber = 100;

//Calculating 
newSum = thirdNumber + fourthNumber;

//Output
Console.WriteLine("Calculated another way: " + newSum);

// Waiting for Enter
Console.ReadLine();

/* DISCUSSION: 
 * 
 *The two (alternative) solutions show two cases you will often meet.

    • You declare a variable and immediately store a value in it.
    • You declare a variable first and store a value in it later.
 */