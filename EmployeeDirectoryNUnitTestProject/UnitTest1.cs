using NUnit.Framework;

namespace EmployeeDirectoryNUnitTestProject
{
    public class EmployeeDirectoryUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFullName()
        {
            Customer customer = new Customer();
            Assert.Pass();
        }
    }
}