using NUnit.Framework;
using DemoAsserts;
namespace Tests
{
    [TestFixture]
    public class JuntarNomesTests
    {
        [Test]
        public void JuntarNomes()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("Porco", "Aranha");

            Assert.That(nomeCompleto, Is.EqualTo("Porco Aranha"));
        }
        [Test]
        public void JuntarNomesCaseSensitive()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("aranha", "humana");
            Assert.That(nomeCompleto, Is.EqualTo("ARANHA HUMANA").IgnoreCase);
        }
        [Test]
        public void JuntarNomesNaoIgual()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("Leonardo", "Rodrigues");
            Assert.That(nomeCompleto, Is.Not.EqualTo("Leonardo Rodrigues"));

        }
    }
}