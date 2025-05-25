using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {

        static void Main(string[] args)
        {

        }
    }

public class UserRepository : IUserRepository
{
    public IEnumerable<User> FindAll()
    {
        return null;
    }
}

public interface IUserRepository
{
    IEnumerable<User> FindAll();
}

public class User
{
    public string Name
    {
        get;
        set;
    }
}