using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoding
{
    public class IfStudy
    {


        public string 게임벌칙(int 등수)
        {
            if (등수 == 1)
            {
                return "TV보기";
            } else
            {
                return "설거지";
            }
        }

        public string 내가만약(string 나)
        {
            if (나 == "시인")
            {
                return "노래";
            } 
            else
            {
                return "춤";
            }
        }

        public string 시험결과(int 점수)
        {
            if (점수 >= 80)
            {
                return "상장";
            } 
            else
            {
                return "참가상";
            }
        }

        public bool 군대가야하나(string 그)
        {
            if (그 == "대한민국 국민")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool 도시락줄까(int 학년, string 이름)
        {
            if (학년 == 3 && 이름 == "김철수")
            {
                return true;
            }
            return false;
        }

        public bool 기념품줄까(int 학년)
        {
            if (학년 == 2 || 학년 ==3)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
