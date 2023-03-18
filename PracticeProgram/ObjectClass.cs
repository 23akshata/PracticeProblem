using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    public class ObjectClass
    {
        public int id;
        public string name;
        public static void Student()
        {
            ObjectClass objectClass = new ObjectClass();
            objectClass.id = 10;
            objectClass.name = "Ram";

            Console.WriteLine(objectClass.id);
            Console.WriteLine(objectClass.name);
        }
    }
}
