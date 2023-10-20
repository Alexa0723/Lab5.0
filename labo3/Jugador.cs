using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo3
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string DulcesFavoritos { get; set; }
        public string RegaloIdeal { get; set; }
        public Jugador AmigoSecreto { get; set; }

        public Jugador(string nombre, string email, string dulcesFavoritos, string regaloIdeal)
        {
            Nombre = nombre;
            Email = email;
            DulcesFavoritos = dulcesFavoritos;
            RegaloIdeal = regaloIdeal;
        }
        public String getNombre()
        {
            return Nombre;
        }

        public String getCorreo()
        {
            return Email;
        }
        public String getEndulzadaIdeal()
        {
            return DulcesFavoritos;
        }

        public String getRegaloIdeal()
        {
            return RegaloIdeal;
        }

        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public void setCorreo(String correo)
        {
            this.Email = correo;
        }

        public void setEndulzadaIdeal(String endulzadaIdeal)
        {
            this.DulcesFavoritos = endulzadaIdeal;
        }

        public void setRegaloIdeal(String regaloIdeal)
        {
            this.RegaloIdeal = regaloIdeal;
        }


        public String mostrarJugador()
        {
            return "Jugador: " + this.Nombre + ", " + this.Email + ", " + this.DulcesFavoritos + ", " + this.RegaloIdeal;
        }
    }
}