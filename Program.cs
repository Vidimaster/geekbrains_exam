void PrintArray(string[] input)
{
    System.Console.Write("[\"" + string.Join("\", \"", input) + "\"]");
}

string[] CheckForLength(string[] input)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            count++;
        }

    }

    string[] result = new string[count];

    count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            result[count] = input[i];
            count++;
        }

    }
    return result;

}

string[] input = new string[6];

input[0] = "Hi";
input[1] = "12121";
input[2] = "2";
input[3] = "Hiwewe";
input[4] = "1ee";
input[5] = "ff";

PrintArray(input);

System.Console.Write(" -> ");

PrintArray(CheckForLength(input));

System.Console.WriteLine();