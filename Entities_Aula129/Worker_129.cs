using System.Collections.Generic;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula129.Enums_129;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula129
{
    class Worker_129
    {
        public string Name { get; set; }
        public WorkerLevel_129 Level { get; set; }
        public double BaseSalary { get; set; }
        public Department_129 Department { get; set; }
        public List<HourContract_129> Contracts { get; set; } = new List<HourContract_129>();

        public Worker_129(string name, WorkerLevel_129 level, double baseSalary, Department_129 department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract_129 contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract_129 contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract_129 contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;

        }

    }
}
