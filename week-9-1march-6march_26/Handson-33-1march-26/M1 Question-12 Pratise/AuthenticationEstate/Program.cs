using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public int Id;
    public string Email;
    public string Password;
    public string Location;
    public int IncorrectAttempt = 0;

    public User(int id, string email, string password, string location)
    {
        Id = id;
        Email = email;
        Password = password;
        Location = location;
    }
}

class ApplicationAuthState
{
    List<User> registeredUsers = new List<User>();
    List<User> usersLoggedIn = new List<User>();
    List<string> allowedLocations;

    public ApplicationAuthState(List<string> locations)
    {
        allowedLocations = locations;
    }

    public string Register(User user)
    {
        if (registeredUsers.Any(u => u.Email == user.Email))
            return $"{user.Email} is already registered!";

        registeredUsers.Add(user);
        return $"{user.Email} registered successfully!";
    }

    public string Login(User user)
    {
        var existing = registeredUsers.FirstOrDefault(u => u.Email == user.Email);

        if (existing == null)
            return $"{user.Email} is not registered!";

        if (existing.IncorrectAttempt >= 3)
            return $"{user.Email} is blocked!";

        if (!allowedLocations.Contains(user.Location))
            return $"{user.Email} is not allowed to login from this location!";

        if (usersLoggedIn.Any(u => u.Email == user.Email))
            return $"{user.Email} is already logged in!";

        if (existing.Password != user.Password)
        {
            existing.IncorrectAttempt++;
            return $"{user.Email} password is incorrect!";
        }

        existing.IncorrectAttempt = 0;
        usersLoggedIn.Add(existing);
        return $"{user.Email} logged in successfully!";
    }

    public string Logout(User user)
    {
        var logged = usersLoggedIn.FirstOrDefault(u => u.Email == user.Email);

        if (logged == null)
            return $"{user.Email} is not logged in!";

        usersLoggedIn.Remove(logged);
        return $"{user.Email} logged out successfully!";
    }
}

class Program
{
    static void Main()
    {
        // Allowed Locations
        int n = int.Parse(Console.ReadLine());
        List<string> locations = new List<string>();

        for (int i = 0; i < n; i++)
            locations.Add(Console.ReadLine());

        ApplicationAuthState app = new ApplicationAuthState(locations);

        // Users
        int m = int.Parse(Console.ReadLine());
        List<User> users = new List<User>();

        for (int i = 0; i < m; i++)
        {
            var a = Console.ReadLine().Split(',');
            users.Add(new User(
                int.Parse(a[0]),
                a[1],
                a[2],
                a[3]
            ));
        }

        // Operations
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            var cmd = Console.ReadLine().Split(':');
            string action = cmd[0];
            int index = int.Parse(cmd[1]);

            if (action == "Register")
                Console.WriteLine(app.Register(users[index]));
            else if (action == "Login")
                Console.WriteLine(app.Login(users[index]));
            else if (action == "Logout")
                Console.WriteLine(app.Logout(users[index]));
        }
    }
}