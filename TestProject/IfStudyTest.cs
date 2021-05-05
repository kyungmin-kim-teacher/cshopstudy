using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCoding;

namespace TestProject
{
    [TestClass]
    public class IfStudyTest
    {
        [TestMethod]
        public void 내가만약_테스트()
        {
            IfStudy ifs = new IfStudy();
            string 할일 = ifs.내가만약("시인");
            Assert.AreEqual("노래", 할일);

            할일 = ifs.내가만약("가수");
            Assert.AreEqual("춤", 할일);
        }

        [TestMethod]
        public void 시험결과_테스트()
        {
            IfStudy ifs = new IfStudy();
            int 점수 = 80;
            string 결과 = ifs.시험결과(점수);
            Assert.AreEqual("상장", 결과);

            점수 = 79;
            결과 = ifs.시험결과(점수);
            Assert.AreEqual("참가상", 결과);
        }

        [TestMethod]
        public void 군대가야하나_테스트()
        {
            IfStudy ifs = new IfStudy();

            string 그 = "대한민국 국민";
            bool 결과 = ifs.군대가야하나(그);
            Assert.AreEqual(true, 결과);

            그 = "중국 국민";
            결과 = ifs.군대가야하나(그);
            Assert.AreEqual(false, 결과);
        }

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

        [TestMethod]
        public void 도시락줄까_테스트()
        {
            IfStudy ifs = new IfStudy();

            int 학년 = 3;
            string 이름 = "김철수";
            bool 도시락 = ifs.도시락줄까(학년, 이름);
            Assert.AreEqual(true, 도시락);

            Assert.AreEqual(false, ifs.도시락줄까(2, "김철수"));
            Assert.AreEqual(false, ifs.도시락줄까(3, "박철수"));
            Assert.AreEqual(false, ifs.도시락줄까(2, "박철수"));
        }

        [TestMethod]
        public void 기념품줄까_테스트()
        {
            IfStudy ifs = new IfStudy();

            int 학년 = 3;
            bool 기념품 = ifs.기념품줄까(학년);
            Assert.AreEqual(true, 기념품);

            Assert.AreEqual(true, ifs.기념품줄까(2));
            Assert.AreEqual(false, ifs.기념품줄까(1));
        }

        [TestMethod]
        public void 오늘의야식_테스트()
        {
            IfStudy ifs = new IfStudy();

            //햄버거가게_오픈, 떡볶이가게_오픈, 편의점_오픈
            Assert.AreEqual("집으로", ifs.오늘의야식(false, false, false));
            Assert.AreEqual("컵라면", ifs.오늘의야식(false, false, true));
            Assert.AreEqual("떡볶이", ifs.오늘의야식(false, true, false));
            Assert.AreEqual("떡볶이", ifs.오늘의야식(false, true, true));
            Assert.AreEqual("햄버거", ifs.오늘의야식(true, false, false));
            Assert.AreEqual("햄버거", ifs.오늘의야식(true, false, true));
            Assert.AreEqual("햄버거", ifs.오늘의야식(true, true, false));
            Assert.AreEqual("햄버거", ifs.오늘의야식(true, true, true));
        }
    }
}
