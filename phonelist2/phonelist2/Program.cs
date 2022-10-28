using System;
using System.Numerics;
namespace phonelist2

{

    public class Phones {
        string? Name;
        string? Phone;

        public Phones() {
        }
        public Phones(string? name, string? phone) {
            Name = name;
            Phone = phone;
        }

        public string? getName() {
            return Name;
        }
        public void setName(string? name) {
            Name = name;
        }

        public string? getPhone() {
            return Phone;
        }
        public void setPhone(string? phone)
        {
            Phone = phone;
        }

        public string? inputName() {
            Console.Write("name surname = ");
            Name = Console.ReadLine();
            return Name;
        }

        public string? inputPhone()
        {
            Console.Write("phone number = ");
            Phone = Console.ReadLine();
            return Phone;
        }
    };

    class Program

    {

        static void Main(string[] args)

        {
            Phones phone = new Phones();
            List<Phones> phonebook = new List<Phones>();

            while (true)

            {

                Console.Clear();

                Console.Write(" 1- add \n 2- search \n 3- all_list \n 4- quit \n Choice -> ");

                string? choice = Console.ReadLine();

                if (choice == null)
                    choice = "";

                if (choice == "1")
                {

                    Console.Clear();

                    Console.WriteLine("\\\\\\\\ registration screen ////");

                    Console.WriteLine("----------------------");

                    phonebook.Add(new Phones(phone.inputName(), phone.inputPhone()));
                }

                if (choice == "2")
                {


                    Console.Clear();

                    Console.WriteLine("\\\\\\\\ search ////");

                    Console.WriteLine("----------------------");

                    Console.Write("name surname= ");

                    string? load = Console.ReadLine();
                    if (load == null)
                        load = "";

                    Phones? res = phonebook.Find(x => x.getName() == load);

                    if (res != null)
                        Console.WriteLine("phone of the person you are calling = " + res.getPhone());
                    else
                        Console.Write("there is no such person !\n");

                    Console.ReadKey();
                }

                if (choice == "3")
                {
                    Console.Clear();

                    Console.WriteLine("\\\\\\\\ search all person list ////");

                    Console.WriteLine("----------------------");

                    foreach(Phones p in phonebook) {
                        Console.WriteLine("name-> " + p.getName() + "\n" + p.getPhone());
                    }
                    Console.ReadLine();
                }

                if (choice == "4")
                {

                    break;

                }
            }
        }
    }
}