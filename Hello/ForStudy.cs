using System;

namespace FirstCoding
{
    public class ForStudy
    {
        public void entry()
        {
            별나무(4);
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
