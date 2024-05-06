public class User
{

}

public class Account : User
{

}

class UserService : IUpdater<User>
{
    public void Update(User entity)
    {
        Console.WriteLine("Обновили!");
    }
}

public interface IUpdater<in T>
{
    void Update(T entity);
}

class Program 
{
    static void Main(string[] args) 
    {
        IUpdater<Account> updater = new UserService();
        updater.Update(new Account());
    }
    
}