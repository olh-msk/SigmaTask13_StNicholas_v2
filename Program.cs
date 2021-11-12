using System;
using System.Collections.Generic;
using System.IO;

namespace SigmaTask13_StNicholas_v2
    {
    class Program
    {
        static void Main(string[] args)
        {
            StNicholas stNicholas = StNicholas.Instance();

            //у файлі є ім'я та стать дитини
            string fileName = @"C:\Users\Acer\OneDrive\Робочий стіл\C#\SigmaTask13_StNicholas_v2\ChildsInfo.txt";

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while((line = reader.ReadLine())!=null)
                {
                    string[] lineSplit = line.Split();
                    Child kid = new Child();
                    kid.Name = lineSplit[0];
                    bool gen;
                    Boolean.TryParse(lineSplit[1],out gen);
                    kid.Gender = gen;

                    kid.SendRequestToStNicholas();
                }
            }

            //виводимо подарунки
            Console.WriteLine(stNicholas.GiveAgeBasedPresents());
        }
    }
}
