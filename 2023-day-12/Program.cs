namespace _2023_day_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static IList<string> GetPuzzleInput()
        {
            string file = Path.Combine(Environment.CurrentDirectory, "puzzle-input.txt");
            using StreamReader sr = new StreamReader(file);
            List<string> input = [];

            while (!sr.EndOfStream)
            {
                input.Add(sr.ReadLine()!);
            }

            return input;
        }

        static IList<string> GetTestInput()
        {
            return @"???.### 1,1,3
.??..??...?##. 1,1,3
?#?#?#?#?#?#?#? 1,3,1,6
????.#...#... 4,1,1
????.######..#####. 1,6,5
?###???????? 3,2,1".Split('\n');
        }

    }
}
