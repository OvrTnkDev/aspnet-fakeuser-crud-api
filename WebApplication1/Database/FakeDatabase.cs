public class FakeDatabase
{
    private static int GlobalId = 0;
    public List<User> Users { get; }

    public FakeDatabase()
    {
        Users = new List<User>();
        AddUserInternal(new User { Name = "jjj", Password = "1234", Surname = "Doe", Username = "Jhon" });
        AddUserInternal(new User { Name = "weer", Password = "1234", Surname = "Luiso", Username = "Serva" });
        AddUserInternal(new User { Name = "qarr", Password = "1234", Surname = "Kire", Username = "Jhon" });
        AddUserInternal(new User { Name = "zsew", Password = "1234", Surname = "Doe", Username = "Lamin" });
    }

    public void AddUser(User user) => AddUserInternal(user);

    private void AddUserInternal(User user)
    {
        GlobalId++;
        user.IdUser = GlobalId;
        Users.Add(user);
    }
}

public class User
{
    public int IdUser { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
