using System;
using System.IO;

namespace Console0908
{
    class BMI
    {
        static void Main(string[] args)
        {
            for (int times = 0; times < 999; times = times + 1)
            {
                Console.WriteLine("\tBMI");
                Console.Write(" 키를 입력해주세요 : ");

                double height = int.Parse(Console.ReadLine());
                height = height / 100;
                Console.Write(" 몸무게를 입력해주세요 : ");

                int weight = int.Parse(Console.ReadLine());

                Console.WriteLine();

                double BMI = (weight / (height * height));

                height = height * 100;
                Console.WriteLine(" 키 : " + height + " 몸무게 : " + weight);
                Console.WriteLine();

                Console.Write(" BMI 지수 :");

                if (BMI <= 18.5)
                {
                    Console.Write(" 저체중");
                }
                else if (BMI < 23)
                {
                    Console.Write(" 정상");
                }
                else if (BMI < 25)
                {
                    Console.Write(" 과체중");
                }
                else if (BMI < 30)
                {
                    Console.Write(" 비만");
                }
                else if (BMI < 35)
                {
                    Console.Write(" 고도비만");
                }
                else
                {
                    Console.Write(" 초고도비만");
                }

                string bmi = string.Format("{0:.0}", BMI);

                Console.WriteLine("(" + bmi + ")" + "입니다");

                Console.WriteLine();

                Console.WriteLine(" 계속(1)    종료(2)");

                Console.Write("\n" + " ");

                int end = int.Parse(Console.ReadLine());

                Console.WriteLine();
                if (end == 1)
                {
                    continue;
                }
                else if (end == 2)
                {
                    times = 1000;
                }
            }
        }
    }
}
// BMI 계산하여 출력하기. 몸무게 / 키(m) x 키(m)  18.5이하 저체중 18.5~22.9정상 23~24.9 과체중 25~29.9 비만 30~34.9 고도비만 35이상 초고도비만