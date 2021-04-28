using System;

namespace FirstCoding
{
    class 학생
    {
        public string 이름;
        public string 머리색;
        public string 성별;
        public int 키;

        string ToString()
        {
            if (1 != 1)
            {
                return this.머리색;
            }
                
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            학생 민정 = new 학생();
            민정.이름 = "민정";
            민정.머리색 = "갈색";
            민정.성별 = "여자";
            민정.키 = 165;

            Console.WriteLine("aaa : " + 민정.ToString());
            
        }
    }
}


