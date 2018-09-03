using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_P2_FunWithGenericCollections
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if (firstPerson.Age > secondPerson.Age)
            {
                return 1;
            }
            else if (firstPerson.Age < secondPerson.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
