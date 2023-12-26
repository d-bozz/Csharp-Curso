using NUnit.Framework;
using CalculadoraEjemplo;

namespace CalculadoraEjemploTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Setup code, if any
        }

        [Test]
        public void Test_Calcular_Suma()
        {
            // Arrange: Inicializar las variables
            int sumando1 = 2;
            int sumando2 = 3;

            // Act: llamar al metodo a testear
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Suma(sumando1, sumando2);

            // Assert: comprobar el valor con el esperado
            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void Test_Calcular_Resta()
        {
            // Arrange
            int minuendo = 5;
            int sustraendo = 3;

            // Act
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Resta(minuendo, sustraendo);

            // Assert
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void Test_Calcular_Multiplicacion()
        {
            // Arrange
            int factor1 = 4;
            int factor2 = 6;

            // Act
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Multipliacion(factor1, factor2);

            // Assert
            Assert.AreEqual(24, resultado);
        }

        [Test]
        public void Test_Calcular_Division()
        {
            // Arrange
            int dividendo = 10;
            int divisor = 2;

            // Act
            double resultado = CalculadoraEjemplo.CalculadoraEjemplo.Division(dividendo, divisor);

            // Assert
            Assert.AreEqual(5, resultado);
        }
    }
}
