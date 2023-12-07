namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISolution> allSolutions = new List<ISolution>();
            allSolutions.Add(new Dec01());
            allSolutions.Add(new Dec02());
            allSolutions.Add(new Dec03());
            //allSolutions.Add(new Dec04());
            //allSolutions.Add(new Dec05());
            //allSolutions.Add(new Dec06());
            //allSolutions.Add(new Dec07());
            //allSolutions.Add(new Dec08());
            //allSolutions.Add(new Dec09());
            //allSolutions.Add(new Dec10());
            //allSolutions.Add(new Dec11());
            //allSolutions.Add(new Dec12());
            //allSolutions.Add(new Dec13());
            //allSolutions.Add(new Dec14());
            //allSolutions.Add(new Dec15());
            //allSolutions.Add(new Dec16());
            //allSolutions.Add(new Dec17());
            //allSolutions.Add(new Dec18());
            //allSolutions.Add(new Dec19());
            //allSolutions.Add(new Dec20());
            //allSolutions.Add(new Dec21());
            //allSolutions.Add(new Dec22());
            //allSolutions.Add(new Dec23());
            //allSolutions.Add(new Dec24());

            foreach (ISolution solution in allSolutions)
            {
                Console.WriteLine(solution.GetType().Name + ": ");
                solution.Solve();
                Console.WriteLine("\n");
            }
        }
    }
}
