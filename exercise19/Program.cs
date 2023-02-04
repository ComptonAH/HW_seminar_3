int[] reverseArray(int number, int numberLength)
{
    int[] revArray = new int[numberLength];
    int divider = 10;
    int index = Convert.ToInt32(numberLength)-1;

    while (index>=0)
    {
        revArray[index] = number%divider;
        number /= divider;
        index--;
    }
    return revArray;
}

int[] directArray(int number,int numberLength)
{
    int[] dirArray = new int[numberLength];
    int divider = 10;
    int index = 0;

    while (index<numberLength)
    {
        dirArray[index] = number%divider;
        number /= divider;
        index++;
    }
    return dirArray;
}

void printPalindrome(int[] revArray,int[] dirArray)
{
    bool comparisonArrays = revArray.SequenceEqual(dirArray);

    if (comparisonArrays == true)
    {
        Console.WriteLine("Your number is a palindrome");
    }
    else Console.WriteLine("Your number is NOT a palindrome");
}

Console.Write("Enter a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLength = Convert.ToString(number).Length;

int[] revArray = reverseArray(number,numberLength);
int[] dirArray = directArray(number,numberLength);
printPalindrome(revArray,dirArray);