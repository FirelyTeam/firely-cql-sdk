namespace CqlSdkExamplesPreview;

partial class Program
{
    void RunAll()
    {
        string[] codes =
        [
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