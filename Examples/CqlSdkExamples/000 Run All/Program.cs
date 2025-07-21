partial class Program
{
    void RunAll()
    {
        string[] codes =
        [
            "210", "220", "221", "230", "240", "250", "251",
            "310", "320", "330", "400", "500"
        ];

        foreach (string code in codes)
        {
            Console.WriteLine($"Running example {code}");
            PickExample(code);
            Console.WriteLine($"Done running example {code}");
            Console.ReadLine();
        }
    }
}