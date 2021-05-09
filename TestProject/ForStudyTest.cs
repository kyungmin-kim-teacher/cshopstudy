using FirstCoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class ForStudyTest
    {
        /**
         * 10보다 작은 정수가 입력되면 "small"을 출력하고,
         * 10보다 크거나 같은 수가 입력되면 "big"을 출력하세요.
         */
        [TestMethod]
        public void 수판별_테스트()
        {
            ForStudy fs = new ForStudy();

            Assert.AreEqual("small", fs.수판별(3));
            Assert.AreEqual("big", fs.수판별(10));
            Assert.AreEqual("big", fs.수판별(13));
        }

        /**
         * 정수 두 개가 입력으로 들어오면
         * '큰수 - 작은수'를 뺀 값을 출력하세요.
         */
        [TestMethod]
        public void 빼기_테스트()
        {
            ForStudy fs = new ForStudy();

            Assert.AreEqual(2, fs.빼기(5, 3));
            Assert.AreEqual(7, fs.빼기(10, 3));
            Assert.AreEqual(7, fs.빼기(3, 10));
        }

        /**
         * 어떤 양의 정수가 입력되면 그 수가 7의 배수면 true 아니면 false를 출력하세요
         */
        [TestMethod]
        public void 칠배수_테스트()
        {
            ForStudy fs = new ForStudy();

            Assert.AreEqual(true, fs.칠배수(7));
            Assert.AreEqual(false, fs.칠배수(0));
            Assert.AreEqual(false, fs.칠배수(1));
            Assert.AreEqual(true, fs.칠배수(56));
            Assert.AreEqual(false, fs.칠배수(-7));
        }

        /**
         * 던진 공의 위치기 50이상 60이하일때 win, 그 외에는 lose를 출력
         */
        [TestMethod]
        public void 공던지기_테스트()
        {
            ForStudy fs = new ForStudy();

            Assert.AreEqual("lose", fs.공던지기(49));
            Assert.AreEqual("win", fs.공던지기(50));
            Assert.AreEqual("win", fs.공던지기(55));
            Assert.AreEqual("win", fs.공던지기(60));
            Assert.AreEqual("lose", fs.공던지기(61));
        }
    }
}
