using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Votre nombre : ");
            string n = Console.ReadLine();
            int IntN = Convert.ToInt32(n);
            /*Numerique.sommePaire(IntN);*/
            Numerique.coeffDecomp(IntN);

        }
    }

     class Numerique
    {
        // q1
        public static void sommePaire(int n){
            int sum = 0;
            for (int counter = n; counter > 0; counter--){
                if(counter % 2 == 0 && counter != n){
                    sum += counter;
                }
            }
            //return sum;
            Console.WriteLine(sum);
        }

        // q2
        public static void coeffDecomp(int n){
            double digitAmount = Math.Floor(Math.Log10(n) + 1);
            string nString = n.ToString();
            char[] subs = nString.ToCharArray(); // all digits
            string[] components = new string[400];
            int counter = 0;
            Console.Write(n + " = ");
            foreach (char thisDigit in subs){ // take 
                if(counter == 0){
                    components[counter] = thisDigit + " * " + Math.Pow(10, digitAmount - 1);
                }else{
                    components[counter] = " + " + thisDigit + " * " + Math.Pow(10, digitAmount - 1);
                }
                Console.Write(components[counter]);
                digitAmount--;
                counter++; 
            }
        Console.ReadLine();
        }
    } 
}
