using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
            }

        public double Perimetro() {
            return (Largura * 2) + (Altura * 2);
            }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
            }

        public override string ToString() {
            return "AREA = " 
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " PERÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " DIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
            }


        }
    }
