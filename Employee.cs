using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
            }

        public void SalaryIncrease(double percent) {
            Salary = Salary * (1 + (percent / 100));
            }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
            }



        }
    }
