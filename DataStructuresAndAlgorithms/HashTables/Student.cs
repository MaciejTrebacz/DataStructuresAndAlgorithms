using System;

namespace DataStructuresAndAlgorithms.HashTables;
using System.Collections;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    // creating empty hash object
    public Hashtable StudentTable = new Hashtable();

    public Student(int id, string name, float gpa)
    {
        Id = id;
        Name = name;
        GPA = gpa;
        PopulateHashTable();
    }

    public void PopulateHashTable()
    {
        Student stud1 = new Student(1, "Micheal",98);
        Student stud2 = new Student(1, "Jim",94);
        Student stud3 = new Student(1, "Angela",91);
        Student stud4 = new Student(1, "Pam",55);
        
        //
        StudentTable.Add(stud1.Id, stud1);
        StudentTable.Add(stud2.Id, stud2);
        StudentTable.Add(stud3.Id, stud3);
        StudentTable.Add(stud4.Id, stud4);

        //retrieving student with student id
        Student storedStudent = (Student)StudentTable[stud1.Id];


        // retrieving all items with casting
        foreach (DictionaryEntry o in StudentTable)
        {
            Student temp = (Student)o.Value;
            Console.WriteLine(temp.Name );
        }

        // go to values directly without casting
        foreach (Student student in StudentTable.Values)
        {
            Console.WriteLine(student.Id);
        }


        Console.WriteLine($"{storedStudent.Id}  {storedStudent.GPA}      {storedStudent.Name}");
    }


}