namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            Console.WriteLine("\t");
            Console.WriteLine("****************************");
            Console.WriteLine("***** CIKLIČNA MATRICA *****");
            Console.WriteLine("****************************");
            Console.WriteLine("\t");

            
            Console.WriteLine("Unesi broj redova: ");
            int red = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());
            Console.WriteLine("\t");
            Console.WriteLine("-----------------------");


            int[,] tab = new int[red, stupac];
            int broj = red * stupac;
            int r = red - 1;
            int s = stupac - 1;
            string smjer = "lijevo";

            for (int i = 1; i <= broj; i++)
            {
                if (smjer == "desno" && (s > stupac - 1 || tab[r, s] != 0))
                {
                    smjer = "dolje";
                    s--;
                    r++;
                }
                if (smjer == "dolje" && (r > red - 1 || tab[r, s] != 0))
                {
                    smjer = "lijevo";
                    r--;
                    s--;
                }
                if (smjer == "lijevo" && (s < 0 || tab[r, s] != 0))
                {
                    smjer = "gore";
                    s++;
                    r--;
                }
                if (smjer == "gore" && (r < 0 || tab[r, s] != 0))
                {
                    smjer = "desno";
                    r++;
                    s++;

                }
                tab[r, s] = i;
                switch (smjer)
                {
                    case "desno":
                        {
                            s++;
                            break;
                        }
                    case "lijevo":
                        {
                            s--;
                            break;
                        }
                    case "gore":
                        {
                            r--;
                            break;
                        }
                    case "dolje":
                        {
                            r++;
                            break;
                        }

                }

            }
            for (int j = 0; j < red; j++)
            {
                for (int k = 0; k < stupac; k++)
                {
                    Console.Write("{0,4}", tab[j, k]);
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("-----------------------");

        }
    }
}
