using CalculadoraDIo;
using System;
using Xunit;


namespace TesteNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstrutorClasse()
        {
            string data = "13/04/2024";
            Calculadora calc = new Calculadora("13/04/2024");
            return calc;
        }
        [Theory]
        [InlineData(2,2,4)]
        public void TestSomar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstrutorClasse();

            int resultadoCalculadora = calc.Somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(2, 2, 0)]
        public void TestSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstrutorClasse();

            int resultadoCalculadora = calc.Subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(2, 2, 4)]
        public void TestMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstrutorClasse();

            int resultadoCalculadora = calc.Multiplicacao(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        public void TestDividir(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstrutorClasse();

            int resultadoCalculadora = calc.Divisao(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calc = ConstrutorClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Divisao(3,0));
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = ConstrutorClasse();
            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(4, 2);

            var Lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, Lista.Count);
        }
    }
}