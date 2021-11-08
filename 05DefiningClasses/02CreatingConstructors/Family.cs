using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = this.family
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
               

                return oldestMember;
        }

       
    }
}
