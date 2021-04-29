using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCoding;

namespace TestProject
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MethodStudyTest
    {
        /**
         * 함수명 : f
         * 매개변수 : 없음
         * 반환형 : 없음
         * 함수내용 : Hello?를 출력하는 함수 구현
         */
        [TestMethod]
        public void 함수_테스트()
        {
            MethodStudy ms = new MethodStudy();
            ms.f();
        }

        /**
         * 함수명 : myabs
         * 매개변수 : 정수형(int) 1개
         * 반환형 : 정수형(int)
         * 함수내용 : 절댓값을 구하는 함수 구현
         */
        [TestMethod]
        public void 절대값함수_테스트2()
        {
            MethodStudy ms = new MethodStudy();
            int rv = ms.myabs(2);
            Assert.AreEqual(2, rv);
        }

        [TestMethod]
        public void 절대값함수_테스트_음수2()
        {
            MethodStudy ms = new MethodStudy();
            int rv = ms.myabs(-3);
            Assert.AreEqual(3, rv);
        }

        /**
         * 함수명 : mymax
         * 매개변수 : 정수형(int) 2개
         * 반환형 : 정수형(int)
         * 함수내용 : 두 정수 중 큰 값을 구하는 함수 구현
         */
        [TestMethod]
        public void 최댓값함수_테스트1()
        {
            MethodStudy ms = new MethodStudy();
            int rv = ms.mymax(2, 4);
            Assert.AreEqual(4, rv);
        }

        public void 최댓값함수_테스트2()
        {
            MethodStudy ms = new MethodStudy();
            int rv = ms.mymax(2, -4);
            Assert.AreEqual(2, rv);
        }

        /**
         * 함수명 : circle
         * 매개변수 : 반지름(r)을 나타내는 정수형 변수 1개
         * 반환형 : 실수형(float)
         * 함수내용 : 파이(3.14f) * r * r로 원의 넓이 구하는 함수 구현
         */
        [TestMethod]
        public void 원의넓이함수_테스트1()
        {
            MethodStudy ms = new MethodStudy();
            float rv = ms.circle(3);
            Assert.AreEqual(28.26f, rv);
        }
    }
}
