using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        public bool Find(string name)
        {
            return _data.ContainsKey(name);
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            if (!position)
            {
                return null;
            }
            else
            {
                return _data[name];
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception( "Name cannot be null.");
            }

            if (Find(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
            }
        }
    }
}