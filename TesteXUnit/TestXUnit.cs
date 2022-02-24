using ProjetoTeste;
using Xunit;

namespace TesteXUnit
{
    public class TestXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;

            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(2, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        [InlineData(1, 2, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            var resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(tNum, resultado);
        }
    }
}