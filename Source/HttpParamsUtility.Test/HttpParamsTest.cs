﻿using NUnit.Framework;

namespace HttpParamsUtility
{
    [TestFixture]
    public class HttpParamsTest
    {
        [Test]
        public void TestCount()
        {
            var parameters = new HttpParams();

            Assert.AreEqual(0, parameters.Count);

            parameters.Add("key", "value");

            Assert.AreEqual(1, parameters.Count);
        }

        [Test]
        public void TestAddNameValueCollection()
        {
            var otherParams = new HttpParams().Add("key", "value");

            var parameters = new HttpParams().Add("otherKey", "otherValue").Add(otherParams.ToNameValueCollection());

            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("otherKey=otherValue&key=value", parameters.ToString());
        }

        [Test]
        public void TestRemove()
        {
            var parameters = new HttpParams().Add("key", "value")
                                             .Add("otherKey", "otherValue")
                                             .Remove("key");

            Assert.AreEqual(1, parameters.Count);
            Assert.AreEqual("otherKey=otherValue", parameters.ToString());
        }

        [Test]
        public void TestClear()
        {
            var parameters = new HttpParams().Add("key", "value")
                                             .Add("otherKey", "otherValue");

            parameters.Clear();

            Assert.AreEqual(0, parameters.Count);
        }

        [Test]
        public void TestValuesAreUrlEncoded()
        {
            var parameters = new HttpParams().Add("url", "http://domain.com/hello/world");

            Assert.AreEqual("url=http%3a%2f%2fdomain.com%2fhello%2fworld", parameters.ToString());
        }
    }
}
