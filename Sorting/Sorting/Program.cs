Console.WriteLine("How many numbers do you want to add?");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 5)
{ Console.WriteLine("Please enter at least '5'."); }

else
{
    int[] Numbers = new int[n];
    Console.WriteLine("Add " + n + " numbers:");

    for (int i = 0; i < n; i++)
    {
        Numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < Numbers.Length; i++)
    {
        for (int j = 0; j < Numbers.Length; j++)
        {
            if (i != j && Numbers[j] > Numbers[i])
            {
                int r = Numbers[j];
                Numbers[j] = Numbers[i];
                Numbers[i] = r;
            }
        }
    }

    for (int i = 0; i < Numbers.Length; i++)
    { Console.Write(Numbers[i] + ", "); }
}