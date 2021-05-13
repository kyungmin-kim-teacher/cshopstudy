using System;

namespace FirstCoding
{
    public class ForStudy
    {
        public void entry()
        {
            나머지();
        }

        private void 나머지()
        {
            for(int a = 5; a <= 8; a++)
            {
                Console.Write("{0} % 3 :: ", a);
                switch (a % 3)
                {
                    case 1:
                        Console.WriteLine("나머지는 1 입니다.");
                        break;
                    case 2:
                        Console.WriteLine("나머지는 2 입니다.");
                        break;
                    default:
                        Console.WriteLine("나머지는 0 입니다.");
                        break;

                }
            }
        }

        private void 요일2()
        {
            string[] weekDays =
                { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            foreach (string day in weekDays)
            {
                switch (day)
                {
                    case "Mon":
                        Console.WriteLine("월요일");
                        break;
                    case "Tue":
                        Console.WriteLine("화요일");
                        break;
                    case "Wed":
                        Console.WriteLine("수요일");
                        break;
                    case "Thu":
                        Console.WriteLine("목요일");
                        break;
                    case "Fri":
                        Console.WriteLine("금요일");
                        break;
                    default :
                        Console.WriteLine("주말");
                        break;
                }
            }
        }

        private void 요일()
        {
            string[] weekDays =
                { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            foreach (string day in weekDays)
            {
                if (day == "Mon")
                    Console.WriteLine("월요일");
                else if (day == "Tue")
                    Console.WriteLine("화요일");
                else if (day == "Wed")
                    Console.WriteLine("수요일");
                else if (day == "Thu")
                    Console.WriteLine("목요일");
                else if (day == "Fri")
                    Console.WriteLine("금요일");
                else 
                    Console.WriteLine("주말");
            }
        }

        private void 반복중단()
        {
            for (int i = 0; i < 5; i++)
            {
                if (2 - i < 0)
                {
                    break;
                }
                Console.WriteLine("2-{0}={1}", i, (2 - i));
            }
        }

        private void 배열()
        {
            //선언 & 할당
            int[] array = new int[5];
            string[] stringArray = new string[6];

            //초기화
            int[] numArr = new int[] { 1, 3, 5, 7, 9 };
            
            int[] numArr2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = 
                { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //참조
            string[] weekDays = new string[]
                { "Sunday", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int[] nums = { 1, 2, 3, 4 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        private void 구구단()
        {
            for(int i = 2; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
            }
        }

        private void 별나무(int 줄수)
        {
            string 별나무 = "";

            for (int 줄번호 = 1; 줄번호 <= 줄수; 줄번호++)
            {
                for (int 횟수 = 1; 횟수 <= 줄번호; 횟수++)
                {
                    별나무 += "*";
                }
                if (줄번호 < 줄수)
                {
                    별나무 += "\n";
                }
            }
            Console.WriteLine(별나무);
        }

        public string 수판별(int 수)
        {
            if (수 < 10)
            {
                return "small";
            } else
            {
                return "big";
            }
        }

        private void 별나무2()
        {
            string 첫번째줄 = "*\n";
            string 두번째줄 = "**\n";
            string 세번째줄 = "***\n";
            string 네번째줄 = "****\n";
            String 별나무 = 첫번째줄 + 두번째줄 + 세번째줄 + 네번째줄;
            Console.WriteLine(별나무);
        }

        public int 빼기(int v1, int v2)
        {
            if (v1 > v2)
            {
                return v1 - v2;
            } 
            else
            {
                return v2 - v1;
            }
        }

        public bool 칠배수(int v)
        {
            if (v <= 0)
            {
                return false;
            }
            if (v % 7 == 0)
            {
                return true;
            } else
            {
                return false;
            }

        }

        private void 별(int 별개수)
        {
            String 별표시 = "";
            for (int 횟수 = 1; 횟수 <= 별개수; 횟수 = 횟수 + 1)
            {
                별표시 += "*";
            }
            Console.WriteLine(별표시);
        }

        public string 공던지기(int v)
        {
            if(v >= 50 && v <= 60)
            {
                return "win";
            } 
            else
            {
                return "lose";
            }
        }

        /*
         * 입력 : 장수 3
         * [식권] #1
         * [식권] #2
         * [식권] #3
         * 
         */
        private void 식권주세요(int 장수)
        {
            Console.WriteLine("[식권] #" + 장수);
        }
    }
}
