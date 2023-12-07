using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132
{
    class Client_132
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client_132()
        {
        }

        public Client_132(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
