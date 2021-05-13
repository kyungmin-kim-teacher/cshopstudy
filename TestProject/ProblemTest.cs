using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class ProblemTest
    {
        /**
         * 문제 : 입력받은 3개의 수 중 가장 큰 수를 찾으시오!
         */
        [TestMethod]
        public void findMax_Test()
        {
            Problem pm = new Problem();
            Assert.AreEqual(90, pm.findMax(90, 70, 80));
            Assert.AreEqual(90, pm.findMax(80, 90, 70));
            Assert.AreEqual(90, pm.findMax(70, 80, 90));
        }

        /**
         * 알파벳을 입력받으면 a, i, u, e, o 모음만 true를 출력하세요.
         */
        [TestMethod]
        public void isVowel_Test()
        {
            Problem pm = new Problem();

            Assert.AreEqual(true, pm.isVowel('a'));
            Assert.AreEqual(false, pm.isVowel('b'));
            Assert.AreEqual(false, pm.isVowel('c'));
            Assert.AreEqual(false, pm.isVowel('d'));
            Assert.AreEqual(true, pm.isVowel('e'));
            Assert.AreEqual(false, pm.isVowel('f'));
            Assert.AreEqual(false, pm.isVowel('g'));
            Assert.AreEqual(false, pm.isVowel('h'));
            Assert.AreEqual(true, pm.isVowel('i'));
            Assert.AreEqual(false, pm.isVowel('j'));
            Assert.AreEqual(false, pm.isVowel('k'));
            Assert.AreEqual(false, pm.isVowel('l'));
            Assert.AreEqual(false, pm.isVowel('m'));
            Assert.AreEqual(false, pm.isVowel('n'));
            Assert.AreEqual(true, pm.isVowel('o'));
            Assert.AreEqual(false, pm.isVowel('p'));
            Assert.AreEqual(false, pm.isVowel('q'));
            Assert.AreEqual(false, pm.isVowel('r'));
            Assert.AreEqual(false, pm.isVowel('s'));
            Assert.AreEqual(false, pm.isVowel('t'));
            Assert.AreEqual(true, pm.isVowel('u'));
            Assert.AreEqual(false, pm.isVowel('v'));
            Assert.AreEqual(false, pm.isVowel('w'));
            Assert.AreEqual(false, pm.isVowel('x'));
            Assert.AreEqual(false, pm.isVowel('y'));
            Assert.AreEqual(false, pm.isVowel('z'));
        }

        /**
         * 1부터 10까지의 자연수를 입력받아서
         * 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 8th, 9th, 10th를 반환하시오.
         */
        [TestMethod]
        public void ordinalNum_Test()
        {
            Problem pm = new Problem();

            Assert.AreEqual("1st", pm.ordinalNum(1));
            Assert.AreEqual("2nd", pm.ordinalNum(2));
            Assert.AreEqual("3rd", pm.ordinalNum(3));
            Assert.AreEqual("4th", pm.ordinalNum(4));
            Assert.AreEqual("5th", pm.ordinalNum(5));
            Assert.AreEqual("6th", pm.ordinalNum(6));
            Assert.AreEqual("7th", pm.ordinalNum(7));
            Assert.AreEqual("8th", pm.ordinalNum(8));
            Assert.AreEqual("9th", pm.ordinalNum(9));
            Assert.AreEqual("10th", pm.ordinalNum(10));
        }

        /**
         * 1부터 주어진 수까지의 합을 구하시오.
         */
        [TestMethod]
        public void sum_Test()
        {
            Problem pm = new Problem();

            Assert.AreEqual(55, pm.sum(10));
            Assert.AreEqual(5050, pm.sum(100));
            Assert.AreEqual(500500, pm.sum(1000));
        }

        [TestMethod]
        public void evenSum_Test()
        {
            Problem pm = new Problem();

            Assert.AreEqual(30, pm.evenSum(10));
            Assert.AreEqual(2550, pm.evenSum(100));
            Assert.AreEqual(250500, pm.evenSum(1000));
        }
    }
}
