namespace AdventOfCode2023;

public class Dec06 : ISolution
{
    public string Input { get; set; }


    public int Answer1 { get; set; }
    public int Answer2 { get; set; }

    public Dec06()
    {
        Input = "60 475 94 2138 78 1015 82 1650";
    }

    public void Solve()
    {
        Solve1();
        Solve2();
    }

    public void Solve1()
    {
        var inputs = Input.Split(' ');
        Answer1 = 1;
        for (int i = 0; i < inputs.Length; i += 2)
        {
            int winCount = 0;
            int duration = Convert.ToInt32(inputs[i]);
            int distance = Convert.ToInt32(inputs[i + 1]);
            
            for (int buttonHoldSec = 0; buttonHoldSec <= duration; buttonHoldSec++)
            {
                if ((duration - buttonHoldSec) * buttonHoldSec > distance)
                    winCount++;
            }
            Answer1 *= winCount;
        }
        Console.WriteLine("First: \t" + Answer1);
    }

    public void Solve2()
    {        
        long duration = 60947882;
        long distance = 475213810151650;
        long buttonHoldInMsStart = distance / duration;
        for (int buttonHoldSec = 0; buttonHoldSec <= duration; buttonHoldSec++)
        {
            if ((duration - buttonHoldSec) * buttonHoldSec > distance)
                Answer2++;
        }
        Console.WriteLine("Second:\t" + Answer2);
    }
}
