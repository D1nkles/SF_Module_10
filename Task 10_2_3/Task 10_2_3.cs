public interface IWorker
{
    public void Build();
}

class Worker : IWorker
{
    void IWorker.Build()
    {
        Console.WriteLine("Я построил!");
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        var worker = new Worker();
        ((IWorker)worker).Build();
    } 
}