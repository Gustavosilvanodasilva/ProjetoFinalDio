using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDIo
{
    public class Calculadora
    {

        private List<string> listhistorico;
        private string data;
        public Calculadora(string data)
        {
            listhistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int valor1, int valor2)
        {
            int valorfinal = valor1 + valor2;
            listhistorico.Insert(0, $"Res: {valorfinal} - Data {data}");
            return valorfinal;
        }
        public int Subtrair(int valor1, int valor2)
        {
            int valorfinal = valor1 - valor2;
            listhistorico.Insert(0, $"Res: {valorfinal} - Data {data}");
            return valorfinal;
        }
        public int Multiplicacao(int valor1, int valor2)
        {
            int valorfinal = valor1 * valor2;
            listhistorico.Insert(0, $"Res: {valorfinal} - Data {data}");
            return valorfinal;

        }
        public int Divisao(int valor1, int valor2)
        {
            int valorfinal = valor1 / valor2;
            listhistorico.Insert(0, $"Res: {valorfinal} - Data {data}");
            return valorfinal;
        }
        public List<string> Historico()
        {
            listhistorico.RemoveRange(3, listhistorico.Count - 3);
            return listhistorico;
        }
    }
}
