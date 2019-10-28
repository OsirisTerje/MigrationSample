using NUnit.Framework;
using MigrationSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationSample.Tests
{
    [TestFixture()]
    public class MathTests
    {
        [Test()]
        public void AddTest()
        {
            var sut = new Math();
            var result = sut.Add(2, 3);
            var json = sut.AsJson();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(5));
                Assert.That(json, Is.EqualTo("{\"LastResult\":5}"));
            });
        }
    }
}