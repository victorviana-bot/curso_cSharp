using System;
using System.Globalization;
using System.Collections.Generic;
using CursoCSharpUdemy_Secao04_Aulas.Entities;
using CursoCSharpUdemy_Secao04_Aulas.Entities.Enums;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula129;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula129.Enums_129;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula131;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132.Enums_132;

namespace CursoCSharpUdemy_Secao04_Aulas
{
    class Program
    {
        static void Main(string[] args)
        {


            /*----------AULA 39
            Triangulo x, y;
            

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
                }
            else {
                Console.WriteLine("Maior área: Y");
                }
            ----------*/

            /*----------AULA 40 - Exercicio 01
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
                }
            else {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
                }
            ----------*/

            /*----------AULA 40 - Exercicio 02

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salario Medio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            ---------*/

            /*----------AULA 41
            Triangulo x, y;


            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
                }
            else {
                Console.WriteLine("Maior área: Y");
                }
            ----------*/

            /*----------AULA 42-44

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            ----------*/

            /*----------AULA 45 Exercicio 01

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(r);

            ----------*/

            /*----------AULA 45 Exercicio 02

            Funcionario02 fun = new Funcionario02();
            
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + fun);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + fun);
            ----------*/

            /*----------AULA 45 Exercicio 03

            Aluno al = new Aluno();

            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if (al.Aprovado()) {
                Console.WriteLine("APROVADO");
                }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
                }
            /*
            //Método que eu tinha criado
            if(al.NotaFinal() >= 60.00) {
                Console.WriteLine("APROVADO");
                }
            else {
                Console.WriteLine("REPROVADO");
                double pontosQueFaltam = 60.00 - al.NotaFinal();
                Console.WriteLine("FALTARAM {0} PONTOS", pontosQueFaltam.ToString("F2", CultureInfo.InvariantCulture));
                }
            ----------*/

            /*----------AULA 47

            //Calculadora calc = new Calculadora();

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " +circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            ----------*/

            /*----------AULA 48 Exercicio

            Console.Write("Qual é o valor do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double compraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversaoDolar = ConversorDeMoeda.Conversor(valorDolar, compraDolar);
            Console.Write("Valor a ser pago em reais = " + conversaoDolar.ToString("F2", CultureInfo.InvariantCulture));
            ----------*/

            /*----------AULA 51-52


            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nomeN = Console.ReadLine();
            Console.Write("Preço: ");
            double precoP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade: ");
            //int quantidadeQ = int.Parse(Console.ReadLine());

            Produto02 p = new Produto02(nomeN, precoP);   //, quantidadeQ);

            //Produto02 p2 = new Produto02() {Nome = "Radio", Preco = 350.0, Quantidade = 7 }; ----Sintaxe alternativa para instanciar. Funciona mesmo se a classe não possuir construtores implementados

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            ----------*/

            /*----------AULA 55

            Produto03 p = new Produto03("TV", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            ----------*/

            /*----------AULA 60 EXERCÍCIO -----Jeito que eu fiz. Só declarei depois para sair do escopo do IF

            double depI = 0.00; 


            Console.Write("Entre o número da conta: ");
            int numeroC = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularC = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char depSN = char.Parse(Console.ReadLine());
            
            if (depSN == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                depI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");

            ContaBancaria contB = new ContaBancaria(numeroC, titularC, depI); 

            Console.WriteLine(contB);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contB.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contB);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contB.Saque(saq);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contB);

            ----------*/


            /*----------AULA 60 EXERCÍCIO -----Professor. Instanciou antes a var Conta Bancaria

            ContaBancaria contB;

            Console.Write("Entre o número da conta: ");
            int numeroC = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularC = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char depSN = char.Parse(Console.ReadLine());

            if (depSN == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contB = new ContaBancaria(numeroC, titularC, depI);
                }
            else {
                contB = new ContaBancaria(numeroC, titularC);
                }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");

            Console.WriteLine(contB);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contB.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contB);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contB.Saque(saq);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contB);
            ----------*/

            /*----------AULA 69

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
                }

            double avg = sum / n;

            Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            ----------*/

            /*----------AULA 70

            int n = int.Parse(Console.ReadLine());

            Produto04[] vect = new Produto04[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto04 { Name = name, Price = price };
                }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
                }

            double avg = sum / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            ----------*/

            /*----------AULA 71 - Exercício 

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            RentRoom[] vect = new RentRoom[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Rent #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new RentRoom { Name = name, Email = email, Room = room };
                Console.WriteLine();
                }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 9; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(vect[i].Room + ": " + vect[i].Name + ", " + vect[i].Email);
                    }
                }

            ----------*/

            /*----------AULA 72

            int s1 = Calculadora02.Sum(2, 3);
            int s2 = Calculadora02.Sum(2, 5, 1);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            ----------*/

            /*----------AULA 72

            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
                }

            Console.WriteLine("----------");

            foreach (string obj in vect) {
                Console.WriteLine(obj);
                }
            ----------*/

            /*----------AULA 76 - 77

            List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Alex", "Bob"};

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
                }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);
                }

            list.Remove("Alex");
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
                }

            list.RemoveRange(1, 1);
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
                }

            list.RemoveAll (x => x[0] == 'M');
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
                }

            list.RemoveAt(0);
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
                }

            ----------*/

            /*----------AULA 78 Exercicio

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                int num = i + 1;
                Console.WriteLine("Employee #" + num + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

                Console.WriteLine();
                }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee employ = list.Find(x => x.Id == searchId);

            if (employ != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employ.SalaryIncrease(percent);
                }
            else {
                Console.WriteLine("This id does not exist!");
                }

            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in list) {
                Console.WriteLine(obj);
                }
            ----------*/


            /*----------AULA 79

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            ----------*/

            /*----------AULA 80

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                    }
                }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
                }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                        }
                    }
                }
            Console.WriteLine("Negative numbers: " + count);
            ----------*/

            /*----------AULA 81 Exercício

            string[] linhaColuna = Console.ReadLine().Split(' ');
            int l = int.Parse(linhaColuna[0]);
            int c = int.Parse(linhaColuna[1]);

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++)
                {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                    {
                    mat[i, j] = int.Parse(values[j]);
                    }
                }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
                {
                for (int j = 0; j < c; j++)
                    {
                    if (mat[i, j] == n)
                        {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j != 0)
                            {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                            }
                        if (i != 0)
                            {
                            Console.WriteLine("Up:" + mat[i - 1, j]);
                            }
                        if (j < c - 1)
                            {
                            Console.WriteLine("Right:" + mat[i, j + 1]);
                            }
                        if (i < l - 1)
                            {
                            Console.WriteLine("Down:" + mat[i + 1, j]);
                            }
                        }
                    }
                }
            ----------*/
            /*----------AULA 124

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

            ----------*/

            /*----------AULA 129

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel_129 level = Enum.Parse<WorkerLevel_129>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department_129 dept = new Department_129(deptName);
            Worker_129  worker = new Worker_129(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract_129 contract = new HourContract_129(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int mont = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, mont).ToString("F2", CultureInfo.InvariantCulture));
            ----------*/

            /*----------AULA 131

            Comment_131 c1 = new Comment_131("Have a nice trip!");
            Comment_131 c2 = new Comment_131("Wow that's awesome!");
            Post_131 p1 = new Post_131(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm goin to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment_131 c3 = new Comment_131("Good night");
            Comment_131 c4 = new Comment_131("May the Force be with you");
            Post_131 p2 = new Post_131(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComment(c1);
            p2.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            ----------*/

            /*----------Exercicio Aula 132*/

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Client_132 client = new Client_132(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus_132 status = Enum.Parse<OrderStatus_132>(Console.ReadLine());


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            Order_132 order;
            order = new Order_132();

            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem_132 orderItem = new OrderItem_132(quantity, productPrice);
                Product_132 productItem = new Product_132(productName, productPrice);
                order = new Order_132(DateTime.Now, status, productItem, client);
                order.AddOrderItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);


        }
    }
}
