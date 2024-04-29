using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRegistrandoFuncionarios
{
    internal class Employe
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employe()
        {

        }

        public Employe(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }

        public void Increase (double value)
        {
            Salary= Salary*((100+value)/100);
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
