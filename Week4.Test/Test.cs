using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Week4.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IDCollection_GetGuidsTest()
        {
            IdCollection newIdCollection = CreateCollection();

            var int32Answer = newIdCollection.GetGuids(new Int32()).GetValues();
            var int64Answer = newIdCollection.GetGuids(new Int64()).GetValues();
            var doubleAnswer = newIdCollection.GetGuids(new Double()).GetValues();

            TestAll(typeof(Int32), 3, int32Answer);
            TestAll(typeof(Int64), 0, int64Answer);
            TestAll(typeof(Double), 2, doubleAnswer);
        }

        public void TestAll<T>(Type type, int size, List<T> array)
        {
            foreach (var item in array)
                Assert.AreEqual(item.GetType(), type);
            Assert.AreEqual(size, array.Count());
        }

        public IdCollection CreateCollection()
        {
            IdCollection newIdCollection = new IdCollection();

            newIdCollection.Add<Int32>();
            newIdCollection.Add<Int32>();
            newIdCollection.Add<Int32>();
            newIdCollection.Add<Double>();
            newIdCollection.Add<Double>();

            return newIdCollection;
        }
    }

    public static class DictionaryExtension
    {
        public static List<TValue> GetValues<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return dictionary
                .Select(d => d.Value)
                .ToList();
        }
    }
}
