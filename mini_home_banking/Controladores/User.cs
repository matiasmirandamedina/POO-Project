namespace mini_home_banking.Controladores
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public User(int id, int roleId, string username, string fullName, string email, string passwordHash)
        {
            Id = id;
            RoleId = roleId;
            Username = username;
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Usuario: {Username}, Nombre completo: {FullName}, Rol: {RoleId}, Email: {Email}";
        }

        public int Getid()
        {
            return Id;
        }

        public string GetUsername()
        {
            return Username;
        }
    }
}