
using Assignment2;

namespace Assignment2_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestGetRadius_RadiusIs5()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(5, c.GetRadius());
        }
        [Test]
        public void TestGetRadius_RadiusIs10() {
            Circle c = new Circle(10);
            Assert.AreEqual(10, c.GetRadius());
        }
        [Test]
        public void TestGetRadius_RadiusIs15() {
            Circle c = new Circle(15);
            Assert.AreEqual(15, c.GetRadius());


        }
            [Test]
            public void TestSetRadius_RadiusIs20()
            {
                Circle c = new Circle(20);
               
                Assert.AreEqual(20, c.GetRadius());
            }
        [Test]
        public void TestSetRadius_RadiusIs10()
        {
            Circle c = new Circle(10);

            Assert.AreEqual(10, c.GetRadius());
        }
        [Test]
        public void TestSetRadius_RadiusIs5()
        {
            Circle c = new Circle(5);

            Assert.AreEqual(5, c.GetRadius());
        }




        [Test]
        public void TestGetCircumference_CircumferenceIs5()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(31.42, c.GetCircumference(), 0.01);
        }

        [Test]

        public void TestSetCircumference_CircumferenceIs10() {

            Circle c = new Circle(10);
            Assert.AreEqual(62.83, c.GetCircumference(), 0.01);
        }

        [Test]
        public void TestSetCircumference_CircumferenceIs15()
        {
            Circle c = new Circle(15);
                Assert.AreEqual(94.25, c.GetCircumference(), 0.01);
            }


        [Test]
        public void TestGetArea_AreaIs5()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(78.54, c.GetArea(), 0.01);
        }
        [Test]
        public void TestGetArea_AreaIs10()
        {
            Circle c = new Circle(10);
            Assert.AreEqual(314.16, c.GetArea(), 0.01);

        }
        [Test]
        public void TestGetArea_AreaIs15()
        {
             Circle c = new Circle(15);
                Assert.AreEqual(706.86, c.GetArea(), 0.01);
            }
        


    }
}