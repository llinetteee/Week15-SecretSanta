using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        public static object Stringsplitoptions { get; private set; }

        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;

            }

            public string Name
            {
                get { return name; }

            }

            public string Gift
            {
                get { return gift; }
            }

        }

        static void Main(string[] args)

        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] secretsantaFromFile = GetDataFromFile();

       
            foreach (string line in secretsantaFromFile)
            {

                string[] temPArray = line.Split(new char[] { '/' });
                SecretSanta newSecretSanta = new SecretSanta(temPArray[0], temPArray[1]);
                mySecretSanta.Add(newSecretSanta);

            }
            foreach (SecretSanta secretsantafromList in mySecretSanta)

            {

                Console.WriteLine($" {secretsantafromList.Name} wants { secretsantafromList.Gift} for Christmas!");
             

            }
        }


        public static void DisplayElementsFromArray(string[] someArray)

        {

            foreach (string element in someArray)

            {

                Console.WriteLine($" String from array: {element}");

            }

        }

        public static string[] GetDataFromFile()

        {
            string filePath = @"/Volumes/KÕVAKETAS/frozen.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;

        }
    }


}
