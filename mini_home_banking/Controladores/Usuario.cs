using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    public class Usuario
    {
        private int Id { get; set; }
        private int RoleId { get; set; }
        private string Username { get; set; }
        private string FullName { get; set; }
        private string Email { get; set; }
        private string PasswordHash { get; set; }


        public Usuario(int id, int roleId, string username, string fullName, string email, string passwordHash)
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
    }
}
