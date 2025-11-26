namespace mini_home_banking.Controladores
{
    public class currency
    {
        public decimal compra { get; set; }
        public decimal venta { get; set; }
        public string casa { get; set; }
        public string nombre { get; set; }
        public string moneda { get; set; }
        public DateTime fechaActualizacion { get; set; }

        public currency(decimal compra, decimal venta, string casa, string nombre, string moneda, DateTime fechaActualizacion)
        {
            this.compra = compra;
            this.venta = venta;
            this.casa = casa;
            this.nombre = nombre;
            this.moneda = moneda;
            this.fechaActualizacion = fechaActualizacion;
        }
    }
}