using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqExamples;

namespace Tests
{
    [TestClass]
    public class BasicExamplesTest
    {
        [TestMethod]
        public void LinqQueryIntro()
        {
            int[] correctResult = {9, 6, 3, 0 };
            BasicExamples examplesClass = new BasicExamples();

            int[] result = examplesClass.LinqQueryIntro().ToArray();
            Assert.AreEqual(correctResult.Length, result.Length);
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.IsTrue(correctResult[i] == result[i]);
            }
        }

        [TestMethod]
        public void LinqQueryMethodIntroTest()
        {
            int[] correctResult = { 9, 6, 3, 0 };
            BasicExamples examplesClass = new BasicExamples();

            int[] result = examplesClass.LinqMethodQueryIntro().ToArray();
            Assert.AreEqual(correctResult.Length, result.Length);
            for (int i = 0; i < result.Length; ++i)
            {
                Assert.IsTrue(correctResult[i] == result[i]);
            }
        }

        [TestMethod]
        public void CreateDictionaryTest()
        {
            BasicExamples examplesClass = new BasicExamples();

            var result = examplesClass.CreateDictionary();

            Assert.IsTrue(result["Rob"] == 21);
            Assert.IsTrue(result["Joe"] == 32);
        }

        [TestMethod]
        public void CreateDictionaryMethodsTest()
        {
            BasicExamples examplesClass = new BasicExamples();

            var result = examplesClass.CreateDictionaryMethods();

            Assert.IsTrue(result["Rob"] == 21);
            Assert.IsTrue(result["Joe"] == 32);
        }
    }
}
