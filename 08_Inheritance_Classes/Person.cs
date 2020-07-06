using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public string Name //applies to customer class and employee class 
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return (!string.IsNullOrEmpty(fullName)) ? fullName : "Unnamed"; //if the first or last name is not set then this returns 'unnamed' these are backing fields
            }
        } 
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void SetFirstName (string name)
        {
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
