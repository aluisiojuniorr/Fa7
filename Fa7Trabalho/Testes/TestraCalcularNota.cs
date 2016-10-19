using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fa7Trabalho;

namespace Testes
{
    [TestClass]
    public class TestraCalcularNota
    {
        [TestMethod]
        public void TestarSomaNota()
        {
            CalcularNota n = new CalcularNota();
            int resultado = n.Soma(1, 1);
            Assert.AreEqual(2, resultado);
        }
    }
}
