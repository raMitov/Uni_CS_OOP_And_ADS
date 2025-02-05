using System.Collections.Generic;


    namespace OOP_CS_UNI
    {
        
        public abstract class Person
        {
            public string Name { get; private set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
