using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8G
{
    class Father
    {
        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        public Father(string firstname, string patronymic)
        {
            FirstName = firstname;
            Patronymic = patronymic;
        }

        public string ShowName()
        {
            return $"{FirstName}";
        }
    }
}
