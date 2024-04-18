using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> familyMembers = new List<Person>();
        private Person oldestMember;

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
            if (this.oldestMember == null || member.Age > this.oldestMember.Age) 
                this.oldestMember = member;
        }

        public Person GetOldestMember() => this.oldestMember;

    }
}
