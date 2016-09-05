using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Matters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string[] firstLine = firstInput.Split(' ');

            int nrPeople = Int32.Parse(firstLine[0]);
            int nrRelationship = Int32.Parse(firstLine[1]);

            //Console.WriteLine("Antal personer: " + nrPeople);
            //Console.WriteLine("Antal relationer: " + nrRelationship);


            int[] people = new int[nrPeople];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Int32.Parse(Console.ReadLine());
            }
            //Console.WriteLine(" ");
            //Console.WriteLine("People");

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(" ");
            //Console.WriteLine("Relationships");


            // Get the last line
            string[] strRelationship = new string[nrRelationship];
            for (int i = 0; i < strRelationship.Length; i++)
            {
                strRelationship[i] = Console.ReadLine();
            }



            //TODO: Edit nedanför: lägg till ny array för varje 
            // GÖr en multidimensionell array [,] 
            foreach (var item in strRelationship)
            {

                string[] rl = item.Split(' ');

                int people1 = Int32.Parse(rl[0]);
                int people2 = Int32.Parse(rl[1]);


                string[,] relationship = new string[people1, people2];

            }




            //foreach (var item in strRelationship)
            //{
            //    Console.WriteLine(relationship[0] + " " + relationship[1]);
            //}

            //string lastInput = Console.ReadLine();
            //string[] lastLine = lastInput.Split(' ');


            //    new int[nrRelationship];
            //for (int i = 0; i < relationship.Length; i++)
            //{
            //    relationship[i] = Int32.Parse(Console.ReadLine());
            //}


            //string lastInput = Console.ReadLine();
            //string[] lastLine = lastInput.Split(' ');




            //char[] people = Console.ReadLine().ToArray();



            //string[] answer = new string[10];
            //for (int i = 0; i < answer.Length; i++)
            //{
            //    answer[i] = Console.ReadLine();
            //}
            //Console.WriteLine(answer);
        }
    }
}
