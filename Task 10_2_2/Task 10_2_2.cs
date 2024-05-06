public interface IWriter
{
    void Write();
}

class Writer : IWriter
{
    void IWriter.Write()
    {
        Console.WriteLine("Пишу!");
    }
}

class Program
{
    static void Main(string[] args) 
    {
        var writer = new Writer();
        ((IWriter)writer).Write();
    }
}