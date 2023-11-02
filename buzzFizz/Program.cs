using buzzFizz;

class Program
{
    static void Main(string[] args)
    {
        int n = 200;
        BuzzFizzService service = new BuzzFizzService();

        // Call the FizzBuzz function to get the result
        List<string> result = service.ShowDividedResults(n);

        // Print the result
        foreach (string s in result)
        {
            Console.Write(s + " ");
        }
    }
}
