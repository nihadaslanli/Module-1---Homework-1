namespace Module_1___Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region task1.
            ////Pifaqor ədədlərinin yoxlanması
            //Console.WriteLine("3 ədəd daxil edin:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a * a + b * b == c * c)
            //    Console.WriteLine($"{a}^2 + {b}^2 = {c}^2");
            //else
            //    Console.WriteLine("Daxil edilən ədədlər Pifaqor üçbucağı yaratmır.");
            //#endregion
            //#region task 2.
            ////40-a, 9-a və 7-yə bölünmə yoxlanışı
            //Console.WriteLine("Bir ədəd daxil edin:");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 40 == 0)
            //{
            //    Console.WriteLine("Ədəd 40-a bölünür.");
            //    if (num % 9 == 0)
            //    {
            //        Console.WriteLine("Ədəd 9-a da bölünür.");
            //        if (num % 7 == 0)
            //            Console.WriteLine("Ədəd həmçinin 7-yə də bölünür.");
            //    }
            //}
            //#endregion
            //#region task 3.
            ////Polindrom say yoxlanışı
            //Console.WriteLine("3 rəqəmli bir ədəd daxil edin:");
            //int polNum = int.Parse(Console.ReadLine());
            //int reversed = (polNum % 10) * 100 + ((polNum / 10) % 10) * 10 + (polNum / 100);
            //if (polNum == reversed)
            //    Console.WriteLine("Ədəd polindromdur.");
            //else
            //    Console.WriteLine("Ədəd polindrom deyil.");
            //#endregion
            //#region task 4.
            ////Rəqəmin ingiliscə qarşılığını çap etmək
            //Console.WriteLine("0-9 arasında bir rəqəm daxil edin:");
            //string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //int digit = int.Parse(Console.ReadLine());
            //if (digit >= 0 && digit <= 9)
            //    Console.WriteLine(numbers[digit]);
            //else
            //    Console.WriteLine("Yanlış giriş!");
            //#endregion
            #region task 5.
            //Ay nömrəsinə görə fəsil tapmaq
            Console.WriteLine("Ay nömrəsini daxil edin (1-12):");
            int month = int.Parse(Console.ReadLine());
            string season;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Qış";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Yaz";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Yay";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Payız";
                    break;
                default:
                    season = "Yanlış giriş!";
                    break;
            }
            Console.WriteLine(season);
            Console.WriteLine("Hello, World!");
            #endregion
        }
    }
}
