using NUnit.Framework;
using CalculoCDB.Service;
using CalculoCDB.Domain;

namespace CalculoCDB.Teste
{
    [TestFixture]
    public class CalculoTeste
    {

        [Test]
        public void Calculo_DeveRetornarOValorCorreto()
        {
            var calculoService = new CalculoService();
            var calculo = new Calculo
            {
                Prazo = 7,
                ValorInicial = 1000
            };

            var resultado = calculoService.CalculaCDB(calculo);
            Assert.AreEqual(30, resultado.Liquido);
            Assert.AreEqual(30, resultado.Bruto);
        }

        [Test]
        public void Calculo_DeveRetornarPorcentagemImpostoMenorIgual6()
        {
            var calculoService = new CalculoService();

            var resultado = calculoService.CalculaImposto(104.96, 100, 5);
            Assert.AreEqual(103.84, resultado.Liquido);
            Assert.AreEqual(104.96, resultado.Bruto);
        }

        [Test]
        public void Calculo_DeveRetornarPorcentagemImpostoMenorIgual12()
        {
            var calculoService = new CalculoService();

            var resultado = calculoService.CalculaImposto(109.1, 100, 9);
            Assert.AreEqual(107.28, resultado.Liquido);
            Assert.AreEqual(109.1, resultado.Bruto);
        }

        [Test]
        public void Calculo_DeveRetornarPorcentagemImpostoMenorIgual24()
        {
            var calculoService = new CalculoService();

            var resultado = calculoService.CalculaImposto(115.62, 100, 15);
            Assert.AreEqual(112.89, resultado.Liquido);
            Assert.AreEqual(115.62, resultado.Bruto);
        }

        [Test]
        public void Calculo_DeveRetornarPorcentagemImpostoMaior24()
        {
            var calculoService = new CalculoService();

            var resultado = calculoService.CalculaImposto(133.67, 100, 30);
            Assert.AreEqual(128.62, resultado.Liquido);
            Assert.AreEqual(133.67, resultado.Bruto);
        }
    }
}
