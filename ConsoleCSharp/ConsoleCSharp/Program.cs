internal class Program
{
    static void Main(string[] args)
    {
        string name = "aa";
        _ = name ?? throw new ArgumentNullException(nameof(name), "nullです");
    }
}