using ListaRegistrandoFuncionarios;
using System;
using System.Data;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employess will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employe> list = new List<Employe>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employe #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employe(id, name, salary));

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idd = int.Parse(Console.ReadLine());



            Employe receive = list.Find(x => x.Id == idd);


           /* if (receive != null)
            {


                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == receive)
                    {


                        Console.WriteLine("Enter the porcentage: ");
                        double percentage = double.Parse(Console.ReadLine());
                        receive.Increase(percentage);


                    }


                }
            }

            else
            {
                Console.WriteLine("This id doens't exist");
            }*/

            if (receive != null)
            {

                foreach (Employe obj in list)
                {
                    if (obj == receive)
                    {
                        Console.WriteLine("Enter the porcentage: ");
                        double percentage = double.Parse(Console.ReadLine());
                        receive.Increase(percentage);
                    }

                }
            }
            else
            {
                Console.WriteLine("This id doens't exist");
            }



            foreach (Employe obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}