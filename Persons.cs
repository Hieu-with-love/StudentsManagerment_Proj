using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerment_Proj
{
    public class Persons
    {
        private string id;
        private string name;
        private string email;
        private bool sex;
        private string adaress;
        private string phone;
        private string cccd;
        private DateTime birthday;
        public Persons(string id, string name, string email, bool sex, string adaress, string phone, string cccd, DateTime birthday)
        {
            this.id=id;
            this.name=name;
            this.email=email;
            this.sex=sex;
            this.adaress=adaress;
            this.phone=phone;
            this.cccd=cccd;
            this.birthday=birthday;
        }
        public Persons() { }
        public string Id { get => id; }
        public string Name { get => name; }
        public string Email { get => email; }
        public bool Sex { get => sex; }
        public string Address { get => adaress; }
        public string Phone { get => phone; }
        public string Cccd { get => cccd; }
        public DateTime Birthday { get => birthday; }
    }
}
