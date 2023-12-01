using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public int Solve1()
    {
        var lines = _input.Split('\n');
        int result = 0;
        string numbers = "";
        string num1 = "";
        string num2 = "";
        int count = 0;

        foreach (var l in lines)
        {
            string a = "1rdtwofjvdllht5eightsixfourbl";
            numbers = Regex.Match(a, @"\d+").Value;

            if (numbers.Length == 1)
            {
                num1 = numbers.Substring(0, 1);
                num2 = numbers.Substring(0, 1);
            }
            else
            {
                num1 = numbers.Substring(0, 1);
                num2 = numbers.Substring(numbers.Length - 1, 1);
            }

            int total = int.Parse(num1) + int.Parse(num2);
            result += total;
            Console.WriteLine(num1 + num2);
            count++;
        }

        Console.WriteLine("Count: " + count);
        return result;
    }

    public override ValueTask<string> Solve_1() => new($"{Solve1()}");

    public override ValueTask<string> Solve_2() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2");

    
}
