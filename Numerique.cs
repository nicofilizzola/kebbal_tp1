using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choissisez une méthode : SOMME, PUISSANCE ou DIV");
            string method = Console.ReadLine();

            // initialisation commune
            Console.Write("Votre nombre : ");
            string n = Console.ReadLine();
            int intN = Convert.ToInt32(n);

            switch(method){
                case "SOMME":
                    Numerique.sumPair(intN);
                    break;

                case "PUISSANCE":
                    Numerique.coeffDecomp(intN);
                    break;

                case "DIV":
                    Console.Write("Divisé par : ");
                    string x = Console.ReadLine();
                    int intX = Convert.ToInt32(x);
                    Numerique.isDivisible(intN, intX);
                    break;

                default: 
                    Console.WriteLine("La méthode que vous avez choisi n\'existe pas. Réesayez et vérifiez que vous avez bien marqué SOMME, PUISSANCE ou DIV");
                    break;
            }
            Console.ReadLine();
        }
    }

     class Numerique
    {
        // q1
        public static void sumPair(int n){
            Console.WriteLine("n = " + n);
            int sum = 0;
            for (int counter = n; counter > 0; counter--){
                if(counter % 2 == 0 && counter != n){
                    if(sum == 0){
                        Console.Write(counter);
                    }else{
                        Console.Write(" + " + counter);
                    }
                    sum += counter;
                }
            }
            //return sum;
            Console.Write(" = " + sum);
        }

        // q2
        public static void coeffDecomp(int n){
            double digitAmount = Math.Floor(Math.Log10(n) + 1);
            string nString = n.ToString();
            char[] subs = nString.ToCharArray(); // all digits
            string[] components = new string[400];
            int counter = 0;
            Console.Write(n + " = ");
            foreach (char thisDigit in subs){
                if(counter == 0){
                    components[counter] = thisDigit + " * " + Math.Pow(10, digitAmount - 1);
                }else{
                    components[counter] = " + " + thisDigit + " * " + Math.Pow(10, digitAmount - 1);
                }
                Console.Write(components[counter]);
                digitAmount--;
                counter++; 
            }
        }

        // q3
        public static void isDivisible(int x, int y){
            if(x % y == 0){
                Console.WriteLine("Oui, " + x + " est divisible par " + y);
            }else{
                Console.WriteLine("Non, " + x + " n'est pas divisible par " + y);
            }
        }
    } 
}
