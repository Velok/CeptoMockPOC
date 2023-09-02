using CeptoMock;
using SourceCode;

namespace TestCode
{
    [TestClass]
    public class TesteeTest
    {
        [TestMethod]
        public void TestTestee()
        {
            Cepto.Mock<TesteeDependency>(d => d.ExecuteVoidMethodWithoutArguments(), 1);
            var testeeDependency = new TesteeDependency();
            var testee = new Testee(testeeDependency);

            testee.Execute();
        }
    }
}
