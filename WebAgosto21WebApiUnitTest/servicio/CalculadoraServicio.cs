using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAgosto21WebApiUnitTest.servicio
{
    public class CalculadoraServicio
    {
        public static int Sumar(int n1,int n2)
        {
            long n1l=n1;  // int 2'000'000'000 +2 = -2
            long n2l=n2;
            long suma=n1l+n2l;
            if(suma<int.MinValue || suma>int.MaxValue)
            {
                suma=0;
            }
            return (int)suma;
        }
        public static int Restar(int n1, int n2)
        {
            long n1l = n1;  // int 2'000'000'000 +2 = -2
            long n2l = n2;
            long restar = n1l - n2l;
            if (restar < int.MinValue || restar > int.MaxValue)
            {
                restar = 0;
            }
            return (int)restar;
        }
        public static int Multiplicar(int n1, int n2)
        {
            long n1l = n1;  // int 2'000'000'000 +2 = -2
            long n2l = n2;
            long multiplicar = n1l * n2l;
            if (multiplicar < int.MinValue || multiplicar > int.MaxValue)
            {
                multiplicar = 0;
            }
            return (int)multiplicar;
        }
        public static int Dividir(int n1, int n2)
        {
            try { 
            long n1l = n1;  // int 2'000'000'000 +2 = -2
            long n2l = n2;
            long dividir = n1l / n2l;  // division de enteros, devuelve un entero
            return (int)dividir;
            } catch(Exception ex) { 
                return 0;
            }
        }
    }
}
