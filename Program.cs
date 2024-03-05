internal class Program
{
    private static void Main(string[] args)
{
    string sourcepath = @"/Users/macos/Desktop/logo/DATA/Map.txt";

        StreamReader reader = new StreamReader(sourcepath);
        string line = "";
        int sum=0;
        while ((line=reader.ReadLine()) !=null)
        {
            Console.WriteLine(line);
            sum+=Int32.Parse(line);
        }
        reader.Close();
        Console.WriteLine(sum);
}
}
