using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Domain.Domain
{
    public class Person
    {
        private int _age;
        public Person()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get 
            {
                CalculateAge();
                return _age;
            
            } 
            private set {
                _age = value;
            } 
        }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        private void CalculateAge() 
        {
            _age = DateTime.Now.Year - DateOfBirth.Year;
            if(DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                _age--;
            }
       
        }
    }
}
