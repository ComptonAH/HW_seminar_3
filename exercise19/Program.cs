Console.Write("Enter a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int numberLength = Convert.ToString(number).Length;

int[] array1 = new int[numberLength];
int[] array2 = new int[numberLength];
int divider = 10;
int index = Convert.ToInt32(numberLength)-1;

while (index>=0)
{
    array1[index] = number%divider;
    number /= divider;
    index--;
}

index = 0;

while (index<numberLength)
{
    array2[index] = number2%divider;
    number2 /= divider;
    index++;
}

bool comparisonArrays = array1.SequenceEqual(array2);

if (comparisonArrays == true)
{
    Console.WriteLine("Your number is a palindrome");
}
else Console.WriteLine("Your number is NOT a palindrome");