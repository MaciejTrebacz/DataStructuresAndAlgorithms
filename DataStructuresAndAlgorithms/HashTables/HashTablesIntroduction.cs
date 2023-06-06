using System;

namespace DataStructuresAndAlgorithms.HashTables
{
    public class HashTablesIntroduction
    {
        public string[] _hashTable { get; set; }

        public HashTablesIntroduction()
        {
            _hashTable = new string[50];
        }

        // this is a VERY WEAK HASHING ALGORITHM
        private int _hash(string key)   
        {
            return key.Length % _hashTable.Length;
        }

        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];
        }


        public void Set(string key, string value)
        {
            // Key is going to be hashed
            int hashedKey = _hash(key);

            // checking if this is already in memory
            if (_hashTable[hashedKey] is not null)
            {
                Console.WriteLine("Sorry collision");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }

        public void Keys()
        {
            for (int i = 0; i < _hashTable.Length; i++)
            {
                Console.WriteLine(_hashTable[i]);
            }
        }
    }
}