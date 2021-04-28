using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCoding;

namespace TestProject
{
    [TestClass]
    public class IfStudyTest
    {
        /**
         * 1등은 TV를 보고, 나머지는 모두 설거지 하기 함수
         */
        [TestMethod]
        public void 할일_1등일때()
        {
            IfStudy ifs = new IfStudy();
            int 등수 = 1;
            string 할일 = ifs.게임벌칙(등수);
            Assert.AreEqual("TV보기", 할일);
        }

        [TestMethod]
        public void 할일_2등일때()
        {
            IfStudy ifs = new IfStudy();
            int 등수 = 2;
            string 할일 = ifs.게임벌칙(등수);
            Assert.AreEqual("설거지", 할일);
        }

        [TestMethod]
        public void 할일_10등일때()
        {
            IfStudy ifs = new IfStudy();
            int 등수 = 10;
            string 할일 = ifs.게임벌칙(등수);
            Assert.AreEqual("설거지", 할일);
        }
    }
}
