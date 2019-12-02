using NUnit.Framework;

namespace Git.Tests
{
    public class Tests
    {
        [Test]
        public void TesteDeSoma()
        {
            int n1 = 1,
                n2 = 1,
                result = 2;
            Assert.AreEqual(result, Calculadora.Soma(n1, n2));
        }

        public void TesteDeSubtração()
        {
            int n1 = 1,
                n2 = 1,
                result = 0;
            Assert.AreEqual(result, Calculadora.Soma(n1, n2));
        }

        public void TesteDeMultiplicação()
        {
            int n1 = 1,
                n2 = 1,
                result = 1;
            Assert.AreEqual(result, Calculadora.Soma(n1, n2));
        }

        public void TesteDeDivisão()
        {
            int n1 = 1,
                n2 = 1,
                result = 1;
            Assert.AreEqual(result, Calculadora.Soma(n1, n2));
        }
    }
}