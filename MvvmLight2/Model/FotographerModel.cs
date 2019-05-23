using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight2.Model
{
    public class FotographerModel
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Notes { get; private set; }
               
        public FotographerModel(string name, string surname, DateTime birthday, string notes)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Notes = notes;
        }
    }

}
