using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DemoAsserts;
namespace DemoAsserts.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void SomarInt()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarInteiros(4, 2);

            Assert.That(resultado, Is.EqualTo(6));
        }
        [Test]
        public void SomarDouble()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarReais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(3.3).Within(0.001));
        }
        public void SomaComPorcentagem()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarReais(50, 50);

            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent);
        }

    }
}
