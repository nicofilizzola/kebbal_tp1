using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Exercice 1

            Console.WriteLine("Choissisez une méthode : SOMME, PUISSANCE ou DIV");
            string method = Console.ReadLine();

            // initialisation commune
            Console.Write("Votre nombre : ");
            try{
                string n = Console.ReadLine();
                int intN = Convert.ToInt32(n);
                validNumber(intN);

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
            catch(NegativeNumber ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullNumber ex)
            {
                Console.WriteLine(ex.Message);
            }

        // Exercice 2

        }
        
        // Exercice 1 : vérifier si le nombre saisi est correct ou non
        static void validNumber(int Number)
        {
            if(Number == 0)
            {
                throw new NullNumber(Number);
            }

            if(Number < 0)
            {
                throw new NegativeNumber(Number);
            }
        }
    }

    // ---------------------------- Classes de l'exercice 1 -----------------------------------------------------------------------------------------
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

    class NegativeNumber : Exception
    {
        public NegativeNumber()
        {
        }

        public NegativeNumber(int number) : base(string.Format("ERREUR : {0} est un nombre négatif ! Essayez avec un entier positif gros con !", number))
        {
        }
    }

    class NullNumber : Exception
    {
        public NullNumber()
        {
        }

        public NullNumber(int number) : base(string.Format("ERREUR : {0} est invalide ! Essaye avec un entier positif sale fdp !", number))
        {
        }
    }

    // ---------------------------- Classes de l'exercice 2 -----------------------------------------------------------------------------------------

    
}
