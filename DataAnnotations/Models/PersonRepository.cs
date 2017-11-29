using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teknologisk
{
    public class PersonRepository
    {
        public Person GetPerson()
        {
            return new Person() { Name = "Kristoffer", Height = 180, BirthDate = new DateTime(1987, 10, 24) };
        }
    }
}