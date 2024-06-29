using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPracticWork
{
    class Phonebook
    {
        Dictionary<string, string> users = new Dictionary<string, string>();


        public void Add(string Tkey, string TValue)
        {
            users.Add(Tkey, TValue);
        }
        public void Rename(string TKey, string TValue) { 
            if (users.ContainsKey(TKey)) users[TKey] = TValue;
        }
        public void Delete(string TKey)
        {
            if (users.ContainsKey(TKey)) { 
                users.Remove(TKey);
            }
            else
            {
                Console.WriteLine("This user is not!");
            }
        }
        public void Search(string Tkey) { 
            if (users.ContainsKey(Tkey))
            {
                Console.WriteLine(users[Tkey]); 
            }
        }
        public void Print()
        {
            foreach (var Value in users) {
                Console.WriteLine($"Phone : {Value.Key}. Name : {Value.Value}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook= new Phonebook();
            phonebook.Add("+380232332", "Ivan");
            phonebook.Add("+038433233", "Rooma");
            phonebook.Add("+343434252", "Vlad");
            phonebook.Print();
            phonebook.Search("+343434252"); 
            phonebook.Delete("+038433233");
            phonebook.Print();
            phonebook.Rename("+343434252", "Artem");
        }
    }
}
