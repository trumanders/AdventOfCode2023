namespace AdventOfCode2023;

public interface ISolution
{
    public string Input { get; set; }
    public int Answer1 { get; set; }
    public int Answer2 { get; set; }
    public void Solve();
    public void Solve1();
    public void Solve2();
}
