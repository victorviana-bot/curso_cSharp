using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class ContaBancaria {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome) {
            NumeroConta = conta;
            TitularConta = nome;
            Saldo = 0.00;
            }
        public ContaBancaria(int conta, string nome, double depositoInicial): this(conta, nome) {
            Deposito(depositoInicial);
            }

        public void Deposito(double deposito) {
            Saldo += deposito;
            }

        public void Saque(double saque) {
            Saldo -= saque + 5.00;
            }

        public override string ToString() {
            return "Conta "
            + NumeroConta
            + ", Titular: "
            + TitularConta
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

            }

        }
    }
