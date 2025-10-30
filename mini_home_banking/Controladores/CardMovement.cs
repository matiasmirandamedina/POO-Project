using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_home_banking.Controladores
{
    public class CardMovement
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }



        public CardMovement(int id, int cardId, decimal amount, string type, string description, int createdBy, DateTime Createdat)
        {
            Id = id;
            CardId = cardId;
            Amount = amount;
            Type = type;
            Description = description;
            CreatedBy = createdBy;
            CreatedAt = Createdat;
        }

        // 🔹 Sobrescritura de ToString()
        public override string ToString()
        {
            return $"ID: {Id}, CardID: {CardId}, Monto: {Amount}, Tipo: {Type}, " +
                   $"Descripción: {Description}, Creado por: {CreatedBy}, Fecha: {CreatedAt}";
        }
    }
}
