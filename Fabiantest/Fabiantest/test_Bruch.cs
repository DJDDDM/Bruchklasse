using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fabian
{
    [TestClass]
    public class test_Bruch
    {
        [TestMethod]
        public void test_one_half()
        {
            Bruch test = new Bruch(1, 2);
            Assert.IsTrue(test.ToString() == "1/2");
        }
        
        [TestMethod]
        public void test_full_five()
        {
            Bruch test = new Bruch(5);
            Assert.IsTrue(test.ToString() == "5/1");
        }

        [TestMethod]
        public void test_15_7()
        {
            Bruch test = new Bruch(15, 7);
            Assert.IsTrue(test.ToString() == "2 1/7");
             
        }

        [TestMethod]
        public void two_sixth_equals_one_third()
        {
            Bruch two_sixth = new Bruch(2, 6);
            Bruch one_third = new Bruch(1, 3);
            Assert.IsTrue(two_sixth == one_third);
        }
        
        [TestMethod]
        public void six_two_equals_three()
        {
            Bruch six_two = new Bruch(6, 2);
            Bruch three = new Bruch(3);
            Assert.IsTrue(six_two == three);
        }

        [TestMethod]
        public void multiply_two_third_with_one_fourth()
        {
            Bruch two_third = new Bruch(2, 3);
            Bruch one_fourth = new Bruch(1, 4);
            Bruch actual = two_third * one_fourth;
            Bruch expected = new Bruch(2, 12);
            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void divide_twelve_sixth_by_three_half()
        {
            Bruch four_sixth = new Bruch(12, 6);
            Bruch three_half = new Bruch(3, 2);
            Bruch actual = four_sixth / three_half;
            Bruch expected = new Bruch(4, 3);
            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void four_third_bigger_one_half()
        {
            Bruch four_third = new Bruch(4, 3);
            Bruch one_half = new Bruch(1, 2);
            Assert.IsTrue(four_third > one_half);
        }

        [TestMethod]
        public void three_quarter_minus_one_half()
        {
            Bruch three_quarter = new Bruch(3, 4);
            Bruch one_half = new Bruch(1, 2);
            Assert.IsTrue(three_quarter - one_half == one_half);
        }
    }
}
