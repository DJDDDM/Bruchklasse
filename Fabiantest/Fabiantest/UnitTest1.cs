using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Fabian
{
    [TestClass]
    public class test_primes 
    {
        private primegenerator generator;

        [TestInitialize]
        public void Setup()
        {
            generator = new primegenerator();
        }
        [TestMethod]
        public void two_returns_two()
        {
            int[] actual = generator.createupto(2);
            int[] expected = { 2 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void test3()
        {
            int[] actual = generator.createupto(3);
            int[] expected = { 2, 3 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void below2_should_throw()
        {
            generator.createupto(1);
        }

        [TestMethod]
        public void test4()
        {
            int[] actual = generator.createupto(4);
            int[] expected = { 2, 3 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void test5()
        {
            int[] actual = generator.createupto(5);
            int[] expected = { 2, 3, 5 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void test6()
        {
            int[] actual = generator.createupto(6);
            int[] expected = { 2, 3, 5 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void test_speed()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            generator.createupto(1000);
            sw.Stop();
            TimeSpan TS = sw.Elapsed;
            Assert.IsTrue(TS.Seconds <= 60);
        }
    }
}
