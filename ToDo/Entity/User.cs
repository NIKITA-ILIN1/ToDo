namespace ToDo.Entity
{
    internal class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(long id, string name, string login, string password)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
