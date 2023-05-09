using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_ObjectApproach
{
    public abstract class Person
    {
        internal string firstName = string.Empty;
        internal string lastName = string.Empty;
        internal DateTime birthDate;
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime BirthDate { get; set; }
        public abstract string GetFullName();
        public abstract string GetAge();
    }
}
