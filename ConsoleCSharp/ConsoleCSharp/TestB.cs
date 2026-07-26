using System.Linq;
namespace TestB;

public class TestB
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var evens = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10)
            .ToList();
        foreach (var n in evens)
        {
            Console.WriteLine(n);
        }
    }
}