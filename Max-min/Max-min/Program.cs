Console.WriteLine("How many numbers do you want to add?");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 2)
        { Console.WriteLine("Please enter at least '2'."); }

else
{
    int[] Numbers = new int [n];
    Console.WriteLine("Add " + n + " numbers:");

    for (int i = 0; i < n; i++)
    {
        Numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    int max = Numbers[0];
    int min = Numbers[0];

    for (int i = 0; i < Numbers.Length; i++)
    {
        if (max < Numbers[i])
        { max = Numbers[i]; }

        else if (min > Numbers[i])
        { min = Numbers[i]; }
    }

    Console.WriteLine("max = " + max + "; min = " + min);
}