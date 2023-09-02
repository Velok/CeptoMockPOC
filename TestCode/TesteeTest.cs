using SourceCode;

namespace TestCode
{
    [TestClass]
    public class TesteeTest
    {
        [TestMethod]
        public void TestTestee()
        {
            var testeeDependency = new TesteeDependency();
            var testee = new Testee(testeeDependency);

            testee.Execute();
        }
    }
}
