using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCoding;

namespace TestProject
{
    [TestClass]
    public class IfStudyTest
    {
        /**
         * 1���� TV�� ����, �������� ��� ������ �ϱ� �Լ�
         */
        [TestMethod]
        public void ����_1���϶�()
        {
            IfStudy ifs = new IfStudy();
            int ��� = 1;
            string ���� = ifs.���ӹ�Ģ(���);
            Assert.AreEqual("TV����", ����);
        }

        [TestMethod]
        public void ����_2���϶�()
        {
            IfStudy ifs = new IfStudy();
            int ��� = 2;
            string ���� = ifs.���ӹ�Ģ(���);
            Assert.AreEqual("������", ����);
        }

        [TestMethod]
        public void ����_10���϶�()
        {
            IfStudy ifs = new IfStudy();
            int ��� = 10;
            string ���� = ifs.���ӹ�Ģ(���);
            Assert.AreEqual("������", ����);
        }
    }
}
