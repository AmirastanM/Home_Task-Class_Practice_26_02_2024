using homework26_02_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework26_02_2024.Services
{
    internal class EmployeeService : Employye
    {
     public Employye[] GetAll()
        {
            Employye employe1 = new()
            {
                id = 1,
                name = "Employe1",
                surname = "Employev1",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 18
            };
            Employye employe2 = new()
            {
                id = 2,
                name = "Employe2",
                surname = "Employev2",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 20
            };
            Employye employe3 = new()
            {
                id = 3,
                name = "Employe3",
                surname = "Employev3",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 24
            };
            Employye employe4 = new()
            {
                id = 4,
                name = "Employe4",
                surname = "Employev4",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 28
            };
            Employye employe5 = new()
            {
                id = 5,
                name = "Employe5",
                surname = "Employev5",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 32
            };
            Employye employe6 = new()
            {
                id = 6,
                name = "Employe6",
                surname = "Employev6",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 36
            };
            Employye employe7 = new()
            {
                id = 7,
                name = "Employe7",
                surname = "Employev7",
                adress = "Baki1",
                email = "employe1@gmailcom",
                age = 40
            };

            Employye[] employers = { employe1, employe2, employe3, employe4, employe5, employe6, employe7 };
            return employers;


        }

     public Employye[] GetAllByAge(Employye[] employees, int age)
     {

           return employees.Where(m => m.age > age).ToArray();          

     }

        public int GetCountByAge(Employye[] employees, int firstAge, int lastAge)
        {
            return employees.Where(m => m.age > firstAge && m.age < lastAge).Count();
        }

        public int SumOfAges(Employye[] employyes)
        {
            return employyes.Sum(m => m.age);
        }
     
    }
}
