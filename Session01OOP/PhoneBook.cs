using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    //Video05
    internal struct PhoneBook
    {
        #region Video05 Indexer
        private long[] numbers;
        private string[] names;
        public PhoneBook(int size)
        {
            numbers = new long[size];
            names = new string[size];
        }


        public long this[string name]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }

                }
                return -1;
            }
        }


        public string this[long number]
        {
            set
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                    }
                }
            }
            get
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return names[i];
                    }
                }
                return "No found";
            }
        }
        public void AddPerson(string name, long number, int index)
        {
            numbers[index] = number;
            names[index] = name;
        }
        public long GetNumber(string name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }

            }
            return -1;
        }
        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = newNumber;
                }
            }
        }

        public string GetName(long number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return names[i];
                }
            }
            return "No found";
        }

        public void UpdateName(string name, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    names[i] = newName;
                }
            }
        }
        #endregion
    }
}