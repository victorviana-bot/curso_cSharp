using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class ConversorDeMoeda {

        public static double Iof = 0.06;


        public static double Conversor(double cotacao , double dolar) {
            return cotacao * dolar + (cotacao * dolar * Iof);
            }

        }
    }
