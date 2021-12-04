using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8G
{
    class Son : Father, ICloneable, IComparable, IPerson
    {
        public Son(string firstname, string patronymic) : base(firstname, patronymic)
        {
            FirstName = firstname;
            Patronymic = patronymic;
        }

        public int CompareTo(object s1)
        {
            Son son = (Son)s1;
            if (Patronymic == son.Patronymic) return 1;
            if (Patronymic != son.Patronymic) return -1;
            return 0;
        }


        public Son ShallowClone()
        {
            return (Son)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Son(FirstName, Patronymic);
        }

        public string ShowNamePatronymic()
        {
            return ShowName() + $" {Patronymic}";
        }
    }
}
