using System;
using System.Collections.Generic;
using System.Text;
using DemoAsserts;
using NUnit.Framework;
namespace DemoAsserts.Tests
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
         [Test]
        public void RetornaAnoNovo()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            //Assert.That(resultado, Is.EqualTo(new DateTime(2019, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);
            Assert.That(resultado, Is.EqualTo(new DateTime(2019, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
        }
        [Test]
        public void RetornarNatal()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.Natal);

            Assert.That(resultado, Is.EqualTo(new DateTime(2019, 12, 25, 0, 0, 0)));
        }
    }
}
