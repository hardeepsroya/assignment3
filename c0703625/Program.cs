using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    public delegate void Sort_DataStructure();



    class Program

    {

        static void Main(string[] args) { }

    }



    class Student

    {

        String Student_name;

        String StudentID;

        double StudentGPA;



        // TODO: change this implementation so that the program pulls names from a Text File:

        // to do this, you must change the container for Student Names from Array to List
        List<string> names = System.IO.File.ReadLines("text.txt").ToList();



        Random r1;



        public Student()

        {

            r1 = new Random();

            Student_name = names[r1.Next(0, 4)];

            StudentID = Convert.ToString(r1.Next(1000, 9999));

            StudentGPA = Convert.ToDouble(r1.Next(1, 99));

        }



        public double AverageStudentGPA()
        {

            // TO DO: implement the algorithm to calculate the Students' average GPA

            return 0;

        }

    }



    public interface IDataStructure

    {

        void Sort();

    }



    class DataStructureQueue : IDataStructure

    {

        // the QUEUE holds the classes (that is classroom of students!)

        // TO DO: insert the contents of the Data File: Classroom Data Set 



        public Queue q1 = new Queue();




        Sort_DataStructure Sort1;





        public void Run()

        {

            for (int i = 0; i < 20; i++)
            {

                q1.Enqueue(new Student());

            }

            Sort1 = new Sort_DataStructure(Sorter);

        }

        public void Sort()
        {



        }



    }



    class DataStructureStack : IDataStructure

    {

        // the STACK holds the Students

        public Stack s1 = new Stack();



        Sort_DataStructure Sort1;



        public void Sorter()
        {

            // TO DO : sort the Stack
            Sort(Stack);

        }



        public void Run()
        {

            for (int i = 0; i < 20; i++)

            {

                s1.Push(new Student());

            }



            Sort1 = new Sort_DataStructure(Sorter);

        }



        public void Sort() { }

    }



}



