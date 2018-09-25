using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_MarceloAranda_2018.Utilidades
{
    public class Util
    {
        public Util()
        {
        }


        public String GetDigito(String rut)
        {
            String digitoVerificador = "?";
            Char[] caracteres = rut.ToCharArray();

            if (caracteres.Length == 10)
            {
                //es de 8
                int num1 = (int)Char.GetNumericValue(caracteres[0]) * 3;
                int num2 = (int)Char.GetNumericValue(caracteres[1]) * 2;
                int num3 = (int)Char.GetNumericValue(caracteres[2]) * 7;
                int num4 = (int)Char.GetNumericValue(caracteres[3]) * 6;
                int num5 = (int)Char.GetNumericValue(caracteres[4]) * 5;
                int num6 = (int)Char.GetNumericValue(caracteres[5]) * 4;
                int num7 = (int)Char.GetNumericValue(caracteres[6]) * 3;
                int num8 = (int)Char.GetNumericValue(caracteres[7]) * 2;

                int suma = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8;
                int resto = suma % 11;
                int digitoVerificadorComoInt = (11 - resto);


                digitoVerificador = digitoVerificadorComoInt.ToString();

                if (digitoVerificadorComoInt == 10)
                {
                    digitoVerificador = "K";
                }
                else if (digitoVerificadorComoInt == 11)
                {
                    digitoVerificador = "0";
                }




            }
            else if (caracteres.Length == 9)
            {
                //es de 7
                int num1 = (int)Char.GetNumericValue(caracteres[0]) * 2;
                int num2 = (int)Char.GetNumericValue(caracteres[1]) * 7;
                int num3 = (int)Char.GetNumericValue(caracteres[2]) * 6;
                int num4 = (int)Char.GetNumericValue(caracteres[3]) * 5;
                int num5 = (int)Char.GetNumericValue(caracteres[4]) * 4;
                int num6 = (int)Char.GetNumericValue(caracteres[5]) * 3;
                int num7 = (int)Char.GetNumericValue(caracteres[6]) * 2;

                int suma = num1 + num2 + num3 + num4 + num5 + num6 + num7;
                int resto = suma % 11;

                int digitoVerificadorComoInt = (11 - resto);

                digitoVerificador = digitoVerificadorComoInt.ToString();

                if (digitoVerificadorComoInt == 10)
                {
                    digitoVerificador = "K";
                }
                else if (digitoVerificadorComoInt == 11)
                {
                    digitoVerificador = "0";
                }

            }


            return digitoVerificador;
        }

        public Boolean IsRutOk(String rut, String digito)
        {
            Boolean rutOk = true;
            Char[] caracteresDelRut = rut.ToCharArray();

            Boolean valido = caracteresDelRut.Last().ToString().Equals(digito);
            if (valido == true)
            {
                rutOk = true;
            }
            else if (valido == false)
            {
                rutOk = false;
            }



            return rutOk;
        }


    }
}
