using MyClassLibrary;
namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Emp e1 = new Emp(5050, "Mary", new DateTime(2005, 8, 31));
            DateTime expected = new DateTime(2005, 8, 31);

            //Act
            DateTime actual = e1.doj;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYearsOfExp()
        {
            Emp e1 = new Emp(5050, "Mary", new DateTime(2005, 8, 31));
            int experience = 17;

            int actual = e1.GetYearsofExp();
            Assert.AreEqual(experience, actual);

        }
    }
}