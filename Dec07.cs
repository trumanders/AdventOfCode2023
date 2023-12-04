namespace AdventOfCode2023;

public class Dec07 : ISolution
{
    public string Input { get; set; }


    public int Answer1 { get; set; }
    public int Answer2 { get; set; }

    public Dec07()
    {

    }

    public void Solve()
    {
        Solve1();
        Solve2();
    }

    public void Solve1()
    {
        Console.WriteLine("First: \t" + Answer1);
    }

    public void Solve2()
    {
        Console.WriteLine("Second:\t" + Answer2);
    }
}
