using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCoding;

namespace TestProject
{
    [TestClass]
    public class IfStudyTest
    {
        [TestMethod]
        public void ��������_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();
            string ���� = ifs.��������("����");
            Assert.AreEqual("�뷡", ����);

            ���� = ifs.��������("����");
            Assert.AreEqual("��", ����);
        }

        [TestMethod]
        public void ������_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();
            int ���� = 80;
            string ��� = ifs.������(����);
            Assert.AreEqual("����", ���);

            ���� = 79;
            ��� = ifs.������(����);
            Assert.AreEqual("������", ���);
        }

        [TestMethod]
        public void ���밡���ϳ�_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();

            string �� = "���ѹα� ����";
            bool ��� = ifs.���밡���ϳ�(��);
            Assert.AreEqual(true, ���);

            �� = "�߱� ����";
            ��� = ifs.���밡���ϳ�(��);
            Assert.AreEqual(false, ���);
        }

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

        [TestMethod]
        public void ���ö��ٱ�_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();

            int �г� = 3;
            string �̸� = "��ö��";
            bool ���ö� = ifs.���ö��ٱ�(�г�, �̸�);
            Assert.AreEqual(true, ���ö�);

            Assert.AreEqual(false, ifs.���ö��ٱ�(2, "��ö��"));
            Assert.AreEqual(false, ifs.���ö��ٱ�(3, "��ö��"));
            Assert.AreEqual(false, ifs.���ö��ٱ�(2, "��ö��"));
        }

        [TestMethod]
        public void ���ǰ�ٱ�_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();

            int �г� = 3;
            bool ���ǰ = ifs.���ǰ�ٱ�(�г�);
            Assert.AreEqual(true, ���ǰ);

            Assert.AreEqual(true, ifs.���ǰ�ٱ�(2));
            Assert.AreEqual(false, ifs.���ǰ�ٱ�(1));
        }

        [TestMethod]
        public void �����Ǿ߽�_�׽�Ʈ()
        {
            IfStudy ifs = new IfStudy();

            //�ܹ��Ű���_����, �����̰���_����, ������_����
            Assert.AreEqual("������", ifs.�����Ǿ߽�(false, false, false));
            Assert.AreEqual("�Ŷ��", ifs.�����Ǿ߽�(false, false, true));
            Assert.AreEqual("������", ifs.�����Ǿ߽�(false, true, false));
            Assert.AreEqual("������", ifs.�����Ǿ߽�(false, true, true));
            Assert.AreEqual("�ܹ���", ifs.�����Ǿ߽�(true, false, false));
            Assert.AreEqual("�ܹ���", ifs.�����Ǿ߽�(true, false, true));
            Assert.AreEqual("�ܹ���", ifs.�����Ǿ߽�(true, true, false));
            Assert.AreEqual("�ܹ���", ifs.�����Ǿ߽�(true, true, true));
        }
    }
}
