public interface IWorker
{
    public void Build();
}

class Worker : IWorker
{
    public void Build() 
    {
        Console.WriteLine("Я построил!");
    }
}