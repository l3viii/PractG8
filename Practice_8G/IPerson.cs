using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8G
{
    interface IPerson
    {
        string FirstName { get; set; }
        string ShowNamePatronymic();
    }
}
