namespace LoopsHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            //Ededin sade ve ya murekkeb oldugunun tapilmasi ----- Daha suretli ama biraz uzun verssiya (eded cut olduqda zaten murekkeb olur ona gore her defe cut ededlere bolmuruk)

            //for (; true;)      // bu for sadece daha rahat yoxlamaq ucundur alqoritme daxil deyil
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int say = 0;
            //    string iscomplex = "";
            //    for (int i = 3; i <= num/3; i++)
            //    {
            //        say += 1;
            //        if (num % i == 0)
            //        {
            //            iscomplex = "murekkeb ededdir!";
            //            break;
            //        }
            //        else
            //        {
            //            iscomplex = "sade ededdir!";
            //        }
            //        i++;
            //    }
            //    say += 1;

            //    if (num % 2 == 0)
            //    {
            //        iscomplex = "murekkeb ededdir!";
            //    }
            //    say += 1;

            //    switch (num)
            //    {
            //        case 0:
            //        case 1:
            //            iscomplex = "ne sade nede murekkeb ededdir!";
            //            break;
            //        case 2:
            //        case 3:
            //        case 7:
            //            iscomplex = "sade ededdir!";
            //            break;
            //    }
            //    Console.WriteLine(iscomplex+" "+ say);
            //}





            ////en optimal variant
            ///


            //for (; true;)      // bu for sadece daha rahat yoxlamaq ucundur alqoritme daxil deyil
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int say = 0;
            //    string iscomplex = "";
            //    for (int i = 3; i <= num / 3; i+=2)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            iscomplex = "murekkeb ededdir!";
            //        }
            //        else
            //        {
            //            switch (num)
            //            {
            //                case 0:
            //                case 1:
            //                    iscomplex = "ne sade nede murekkeb ededdir!";
            //                    break;
            //                case 2:
            //                case 3:
            //                case 7:
            //                    iscomplex = "sade ededdir!";
            //                    break;
            //            }
            //        }
            //        if (num % i == 0)
            //        {
            //            iscomplex = "murekkeb ededdir!";
            //            break;
            //        }

            //    }

            //}






            for (; true;)      // bu for sadece daha rahat yoxlamaq ucundur alqoritme daxil deyil
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string iscomplex = "";
                if (num % 2 != 0 || num== 0 || num == 1 || num == 2 || num == 3 || num == 7) //bura bele deyildi
                {
                    for (int i = 3; i * i <= num; i += 2)
                    {
                        if (num % i == 0)
                        {
                            iscomplex = "murekkeb ededdir!";
                            break;
                        }
                        else
                        {
                            iscomplex = "Sade ededdir!"; ///bura yox idi
                        }
                    }
                }
                else
                    {
                        iscomplex = "Murekkeb ededdir!";
                    }
                switch (num)  ///switch yox idi
                {
                    case 0:
                    case 1:
                        iscomplex = "Ne sade nede murekkeb ededdir!";
                        break;
                    case 2:
                    case 3:
                    case 5:
                    case 7:
                        iscomplex = "Sade ededdir!";
                        break;
                }
                Console.WriteLine(iscomplex);
            }




            // Nisbeten yavas  ama biraz qisa- Ededin sade ve ya murekkeb oldugunun tapilmasi 


            //for (; true;)                 // bu for sadece daha rahat yoxlamaq ucundur alqoritme daxil deyil
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    string iscomplex = "";
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            iscomplex = "Murekkeb ededdir!";
            //            break;
            //        }
            //        else
            //        {
            //            iscomplex = "Sade ededdir!";
            //        }
            //    }
            //    switch (num)
            //    {
            //        case 0:
            //        case 1:
            //            iscomplex = "Ne sade nede Murekkeb ededdir!";
            //            break;
            //        case 2:
            //            iscomplex = "Sade ededdir!";
            //            break;
            //    }
            //    Console.WriteLine(iscomplex);
            //}




            // Task 2
            //Ededin 2 -in quvveti olub olmamagini yoxlamaq




            //int num = Convert.ToInt32(Console.ReadLine());
            //bool istrue = true;
            //for (int i = 2; i <= num; i *= 2)
            //{
            //    if (i == num)
            //    {
            //        istrue = true;
            //    }
            //    else
            //    {
            //        istrue = false;
            //    }
            //}
            //Console.WriteLine(istrue);




            // Task 3
            // Ededin mertebelerinin sayi



            //for (; true;)                 // bu for sadece daha rahat yoxlamaq ucundur alqoritme daxil deyil
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    int number = 0;
            //    for (int i = input; i > 0; i /= 10)
            //    {
            //        number++;
            //    }
            //    Console.WriteLine("Number: " + number);
            //}
        }
    }
}