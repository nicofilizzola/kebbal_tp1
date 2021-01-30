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
            string stringN = Convert.ToString(n);
            int length = stringN.Length();
        }
    } 
}
