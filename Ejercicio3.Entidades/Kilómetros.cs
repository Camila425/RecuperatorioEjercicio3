using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Kilómetros
    {
        public double  Velocidad { get; set; }

        public  double GetVelocidad()
        {
            return Velocidad;
        }
        public Kilómetros(double velocidad)
        {
            Velocidad = velocidad;
        }

        public Kilómetros()
        {
            Velocidad = 100;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Kilómetros))
            {
                return false;
            }
            return this.Velocidad == ((Kilómetros)obj).Velocidad;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Kilómetros K1, Kilómetros K2)
        {
            return K1.Velocidad.Equals(K2.Velocidad);
        }

        public static bool operator !=(Kilómetros K1, Kilómetros K2)
        {
            return !(K1.Velocidad == K2.Velocidad);
        }

        public static Kilómetros operator +(Kilómetros kilómetros,Millas millas) 
        {
            return new Kilómetros(kilómetros.Velocidad + (0.621371));
        }

        public static Kilómetros operator -(Kilómetros kilómetros, Millas millas)
        {
            return new Kilómetros(kilómetros.Velocidad * (0.621371));
        }



    }
}
