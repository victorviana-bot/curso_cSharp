using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class Funcionario02 {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
            }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto * (1 + (porcentagem / 100));
            }

        public override string ToString() {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            }



        }
    }
