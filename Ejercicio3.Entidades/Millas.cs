using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Entidades
{
    public class Millas
    {
        public double Velocidad { get; set; }

        public double GetVelocidad()
        {
            return Velocidad;
        }
        public Millas(double velocidad)
        {
            Velocidad = velocidad;
        }

        public Millas()
        {
            Velocidad = 100;
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Millas))
            {
                return false;
            }
            return this.Velocidad == ((Millas)obj).Velocidad;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

        public static bool operator ==(Millas millas,Millas millas1)
        {
            return millas.Velocidad.Equals(millas1.Velocidad);
        }

        public static bool operator !=(Millas millas, Millas millas1)
        {
            return !(millas.Velocidad == millas1.Velocidad);
        }


        public static Millas operator +(Millas millas, Kilómetros kilometros)
        {
            return new Millas(0.621371 * kilometros.Velocidad);
        }

        public static Millas operator -(Millas millas, Kilómetros kilómetros)
        {
            return new Millas(0.621371*(kilómetros.Velocidad));
        }

    }
}
