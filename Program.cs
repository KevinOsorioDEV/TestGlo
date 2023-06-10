using System.Collections.Immutable;
using System.Numerics;
using System.Text;

namespace TestGlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EliminarDuplicados());
        }

        static string EliminarDuplicados()
        {
            Console.WriteLine("ELIMINA DUCPLICADOS");
            Console.Write("Ingrese su frase -> ");
            string frase = Console.ReadLine() ?? "";

            string resultado = "";

            foreach (char letra in frase)
            {
                if (!resultado.Contains(letra))
                {
                    resultado += letra;
                }
            }
            return resultado;
        
        }


        static string InvertirPalabra()
        {
            Console.WriteLine("INVERTIR PALABRA!");
            Console.Write("Ingrese su palabra -> ");
            string palabra = Console.ReadLine() ?? "";

            string palabraInvertida = "";

            for(int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
            }

            return $"{palabraInvertida}";
        }

        static string CalcularFactorial()
        {
            try{
                Console.WriteLine("CALCULAR FACTORIAL!");
                Console.Write("Ingrese su numero -> ");
                int numero = Convert.ToInt32(Console.ReadLine());

                BigInteger factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                return $"{factorial}";

            } catch (Exception e) {
                return $"Debes ingresar un numero.\n{e.Message}";
            }
        }

        static bool EsAnamgrama(string palabra1 = "", string palabra2 = "")
        {
            List<char> listaPalabra1 = palabra1.ToLower().ToList();
            List<char> listaPalabra2 = palabra2.ToLower().ToList();

            var listaPalabra1Ordenada = listaPalabra1.OrderBy(pal => pal);
            var listaPalabra2Ordenada = listaPalabra2.OrderBy(pal => pal);

            if (listaPalabra1Ordenada.SequenceEqual(listaPalabra2Ordenada)){
                return true;
            }

            return false;
        }

        static void NumeroMaximo()
        {
            Console.WriteLine("NUMERO MAXIMO!");
            Console.WriteLine("Ingrese su lista de numero separada por comas...");
            try
            {
                string numeros = Console.ReadLine() ?? "";
                numeros = numeros.Trim();
                int[] arrayNumeros = numeros.Split(',').Select(int.Parse).ToArray();

                Console.WriteLine(arrayNumeros.Max());
            }catch (Exception ex)
            {
                Console.WriteLine($"Debes ingresar una lista de numeros separados por comas.|\nEjemplo: 1,2,3,4,5\n{ex.Message}");
            }

        }

        static void CombinancionLista()
        {
            List<string> list = new() { "abc", "123" };


            for (int i = 0; i < list.Count; i++)
            {
                string numeros = list[i];

                List<string> combinaciones = new();

                for (int j = 0; j < numeros.Length; j++)
                {
                    for (int k = 0; k < numeros.Length; k++)
                    {
                        for (int l = 0; l < numeros.Length; l++)
                        {
                            combinaciones.Add($"{numeros[j]}{numeros[k]}{numeros[l]}");
                        }
                    }
                }

                Console.WriteLine($"{i+1} - {string.Join(",", combinaciones)}");
            }
            
        }

        static string Combinaciones()
        {
            Console.WriteLine("Combinaciones Posibles.");
            Console.WriteLine("Ingresa las letras separadas por comas...");
            string letras = Console.ReadLine() ?? "";
            letras = letras.Trim();
            string[] listaLetras = letras.Split(',');

            List<string> listasCombinaciones = new();

            for (int i = 0; i < listaLetras.Length; i++)
            {
                for (int j = i; j < listaLetras.Length; j++)
                {
                    listasCombinaciones.Add($"\"{listaLetras[i]},{listaLetras[j]}\"");

                }
            }

            return (string.Join(",", listasCombinaciones));

        }

        static string NumeroPerfecto()
        {
            Console.WriteLine("Calculadora de numeros perfectos.");
            Console.WriteLine("Ingrese su numero...");

            try
            {
                Int64 numero = Convert.ToInt64(Console.ReadLine());

                if (numero <= 1)
                {
                    return "El numero debes positivo y mayor a 1";
                }

                Int64 sumaDivisores = 0;

                for (Int64 i = 1; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                if (sumaDivisores == numero)
                {
                    return $"El numero {numero} es perfecto";
                }

                return $"El numero {numero} no es perfercto";
            }
            catch (Exception ex)
            {
                return $"Debes ingresar un numero.\n{ex.Message}";
            }


        }

        static string PalabraCortaLarga()
        {
            Console.WriteLine("Buscaremos la palabra corta y larga de tu texto");
            Console.WriteLine("Ingresa tu texto separado por espacios.");
            string texto = Console.ReadLine() ?? "";

            string[] listaTexto = texto.Split(" ");

            if (listaTexto.Length == 0)
            {
                return "No se ingresaron palabras.";
            }
            var palabraCorta = listaTexto[0];

            var palabraLarga = listaTexto[0];


            foreach (var item in listaTexto)
            {
                if (item.Length > palabraLarga.Length)
                {
                    palabraLarga = item;

                }

                if (item.Length < palabraCorta.Length)
                {
                    palabraCorta = item;
                }
            }

            return $"La palabra corta es: {palabraCorta}\nLa palabra larga es: {palabraLarga}";
        }

        static string PromedioMayor()
        {
            Console.WriteLine("Vamos a calcular el promedio de tus numeros y cuales son los mayores del promedio.");
            Console.WriteLine("Ingresa tus numeros separador por comas.");

            try
            {
                string numeros = Console.ReadLine() ?? "";
                numeros = numeros.Trim();
                string[] numerosLista = numeros.Split(',');

                int totalSuma = 0;
                int totalMayoresPromedio = 0;

                for (int i = 0; i < numerosLista.Length; i++)
                {
                    totalSuma += Convert.ToInt32(numerosLista[i]);
                }

                int promedio = totalSuma / numerosLista.Count();

                foreach (string i in numerosLista)
                {
                    if (Convert.ToInt32(i) > promedio)
                    {
                        totalMayoresPromedio++;
                    }
                }

                return ($"Promedio = {promedio}\nNumeros mayores que el promedio = {totalMayoresPromedio}");
            }
            catch (Exception ex)
            {
                return ($"Ingresa los numeros separador por comas sin espacios.\nEjemplo: 1,2,3,4,5 \n{ex.Message}");
            }

        }


        static string ContadorVocales()
        {
            Console.WriteLine("CONTADOR DE VOCALES");
            Console.WriteLine("Ingrese su texto");
            string texto = Console.ReadLine() ?? "";
            texto = texto.ToLower();

            List<char> vocales = new() { 'a', 'e', 'i', 'o', 'u' };

            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[i];

                if (letra == vocales[0])
                {
                    contadorA++;
                    continue;
                }
                if (letra == vocales[1])
                {
                    contadorE++;
                    continue;
                }
                if (letra == vocales[2])
                {
                    contadorI++;
                    continue;
                }
                if (letra == vocales[3])
                {
                    contadorO++;
                    continue;
                }
                if (letra == vocales[4])
                {
                    contadorU++;
                    continue;
                }
            }

            return $"Tu frase tiene \na - {contadorA} \ne - {contadorE}\ni - {contadorI}\no - {contadorO}\nu - {contadorU}\nEl total de vocales son: {contadorA + contadorE + contadorI + contadorO + contadorU}";
        }


        public static string Palindromo()
        {
            Console.WriteLine("Tu texto es palindromo?");
            Console.WriteLine("Ingrese su frase...");
            string frase = Console.ReadLine() ?? "";
            StringBuilder fraseReves = new();

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                fraseReves.Append(Convert.ToString(frase[i]));
            }

            if (fraseReves.ToString() == frase)
            {
                return $"La palabra {frase} es palindromo.";
            }

            return $"La palbra {frase} no es palindromo.";
        }


        static string NumeroPrimo()
        {

            Console.WriteLine("NUMERO PRIMO?");
            Console.WriteLine("Ingrese su numero...");

            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());


                if (numero <= 1)
                    return ("Debe ser un numero entero mayor a uno, el numero uno no es primo.");

                int vecesDivisibles = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        vecesDivisibles++;

                        if (vecesDivisibles > 2)
                        {
                            return ($"El numero {numero} no es primo");
                        }
                    }
                }


                return ($"El numero {numero} es primo");
            }
            catch (Exception ex)
            {
                return ($"Debes ingresar un numero, \n{ex.Message}");
            }

        }


        static void CalcularAreaCircunferenciaCirculo()
        {

            Console.WriteLine("CALCULADORA DE AREA Y CIRCUNFERENCIA DE UN CIRCULO");
            Console.WriteLine("Ingrese el radio del circulo...");

            try
            {
                double radioCirculo = Convert.ToDouble(Console.ReadLine());

                double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);

                double circunferenciaCirculo = 2 * Math.PI * radioCirculo;

                Console.WriteLine($"El area del circulo es {Math.Round(areaCirculo, 2)} \nLa circunferencia del circulo es {Math.Round(circunferenciaCirculo, 2)}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Debes ingresar un numero valido.\n{ex.Message}");
            }
        }
    }
}