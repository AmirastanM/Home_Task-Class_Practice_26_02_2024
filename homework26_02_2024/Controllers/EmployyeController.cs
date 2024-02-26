using homework26_02_2024.Models;
using homework26_02_2024.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework26_02_2024.Controllers
{
    internal class EmployyeController
        
    {

        public readonly EmployeeService employeeService;

        public EmployyeController()
        {
            employeeService = new EmployeeService();
        }

        public void GetAll()
        {


            

            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name);
            }

        }

        public void GetAllByAge()
        {
           


            var result = employeeService.GetAllByAge(employeeService.GetAll(), 30);


            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.age);
            }

        }

        public void GetCountByAge()
        {
            

            Console.WriteLine("Add first age:");
            int firstAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Add last age:");
            int lastAge = int.Parse(Console.ReadLine());

            int count = employeeService.GetCountByAge(employeeService.GetAll(), firstAge, lastAge);
            Console.WriteLine(count);

        }

        public void GetSumOfAges()
        {
           

            int sumOfAge = employeeService.SumOfAges(employeeService.GetAll());

            Console.WriteLine(sumOfAge);
        }

        public void GetAllByCheckedEmail()
        {
           

            Console.WriteLine("Add your text:");
            string str = Console.ReadLine();

            Employye[] employye = employeeService.GetAll();

            Employye[] checkedEmployees = employeeService.GetAllByCheckedEmail(employye, str);

            foreach (var item in checkedEmployees)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.email);
            }
        }

        }
    }
