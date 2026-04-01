using System;

class Student
{
    int rollNo;
    string name, cls, branch;
    int sem;
    int[] marks = new int[5];

    public Student(int rollNo, string name, string cls, int sem, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.cls = cls;
        this.sem = sem;
        this.branch = branch;
    }

    public void GetMarks()
    {
        Console.WriteLine("Enter 5 subject marks:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void DisplayResult()
    {
        int total = 0;
        bool fail = false;

        foreach (int m in marks)
        {
            if (m < 35)
                fail = true;
            total += m;
        }

        double avg = total / 5.0;

        if (fail || avg < 50)
            Console.WriteLine("Result: FAIL");
        else
            Console.WriteLine("Result: PASS");

        Console.WriteLine("Average: " + avg);
    }

    public void DisplayData()
    {
        Console.WriteLine($"RollNo: {rollNo}, Name: {name}, Class: {cls}, Sem: {sem}, Branch: {branch}");
    }
}

class student
{
    static void Main()
    {
        Student s = new Student(1, "Subha", "CSE", 3, "IT");

        s.DisplayData();
        s.GetMarks();
        s.DisplayResult();
    }
}