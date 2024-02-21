namespace palindrome;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 121;
        bool result = false;
        string inputNum = Convert.ToString(userInput);
        char[] inputCharArray = inputNum.ToCharArray();
        Array.Reverse(inputCharArray);
        string outputNum = new string(inputCharArray);
        if (inputNum == outputNum)
        {
            result = true;
        }
        Console.WriteLine(result);
    }
}
