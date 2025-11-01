namespace mini_home_banking.Controladores
{
    public class User
    {
        private int Id { get; set; }
        private int RoleId { get; set; }
        private string Username { get; set; }
        private string FullName { get; set; }
        private string Email { get; set; }
        private string PasswordHash { get; set; }

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
    }
}