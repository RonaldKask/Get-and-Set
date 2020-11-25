using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, string _idCode, int _age)
            {
                Name = _name;
                Gender = _gender;
                IdCode = _idCode;
                age = _age;
            }

            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "male" || value == "female")
                    {
                        gender = value;
                    }else
                    {
                        gender = "underfined unicorn";
                    }
                }
            }

            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }else
                    {
                        idCode = "undefined";
                    }
                }

            }

            public void ChangeName(string newName)
            {
                name = newName;
            }

            public void ChangeIdCode(string newCode)
            {
                IdCode = newCode;
            }
        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("Harry Potter", "male", "1235", 25);
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);

            newPerson.ChangeName("Harry Plotter");

            Console.WriteLine(newPerson.Name);

            Console.WriteLine(newPerson.IdCode);
            //Console.WriteLine(newPerson.age);
            /*newPerson.name = "Harlette Plotter";
            newPerson.gender = "Female";
            newPerson.age = 21;*/
            //Console.WriteLine(newPerson.name);
            //Console.WriteLine(newPerson.gender);
            //Console.WriteLine(newPerson.age);

        }



    }
}
