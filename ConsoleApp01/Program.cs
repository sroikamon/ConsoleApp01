// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//Console.Write("Hello, World!");

//int num1 = 0;
//long num2 = 10;
//Console.WriteLine(num1);
//Console.WriteLine(num2);

//int num1 = 2000000000;
//long num2 = 3000000000;
/*
char mychar = '1';
double mydouble = mychar;
Console.WriteLine(mydouble);

double d1 = 700;
int d2 = Convert.ToInt32(d1);
string num1 = "1000";
string num2 = "500";
int num3 = int.Parse(num1);
int num4 = int.Parse(num2);
Console.WriteLine(d2);*/

/*Console.Write("Name1: ");
string Name = Console.ReadLine();
Console.WriteLine($"{Name}");

Console.Write("Num1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Num2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1+num2}");*/

/*----------1-------------
using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

Console.Write("Name : ");
string Name1 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight1 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height1 = double.Parse(Console.ReadLine());

Console.Write("--------2--------");
Console.Write("\n Name : ");
string Name2 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight2 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height2 = double.Parse(Console.ReadLine());

double BMI1 = Math.Round(Weight1 / Math.Pow(Height1 / 100, 2), 2);
double BMI2 = Math.Round(Weight2 / Math.Pow(Height2 / 100, 2), 2);

Console.WriteLine($"\n {Name1} BMI = {BMI1}");
Console.WriteLine($"\n {Name2} BMI = {BMI2}");
//Console.WriteLine($"\nMax BMI =  {Math.Max(BMI1,BMI2)}"); */

/*------2-----------
using System;

class Program
{
    static void Main(string[] args)
    {
        string position;
        float salary;

        Console.Write("Enter your position : ");
        position = Console.ReadLine();

        Console.Write("Enter your salary: ");
        salary = float.Parse(Console.ReadLine());

        float SalaryIncrease = 0;
        switch (position)
        {
            case "Assistant Developer":
                SalaryIncrease = 1.05f;
                break;
            case "IT Support":
                SalaryIncrease = 1.07f;
                break;
            case "Senior Developer":
                SalaryIncrease = 1.1f;
                break;
            case "Administrator":
                SalaryIncrease = 1.08f;
                break;
            default:
                SalaryIncrease = 1.03f;
                break;
        }

        float bonus = salary * SalaryIncrease;
        float newSalary = salary + bonus;
        Console.WriteLine("Salary increase: {0}", bonus);
        Console.WriteLine("New salary: {0}", newSalary);
    }
}*/


/*int num = 0;
while (num <= 5)
    ++num;
Console.WriteLine(num);
Console.WriteLine("Exit Loop");*/

/*
int num = 0;
for (int i = 0; i <= 5; i++)
{ Console.WriteLine(i); }
*/

/*
string[] cars = new string[] {"ford", "toyota","lambogini" };
Array.Resize(ref cars, 4);
cars[3] = "BMW";

foreach (string car in cars)
{
    Console.WriteLine(car);
}

Console.Write("----------------");
Array.Sort(cars);

foreach (string car in cars)
{
    Console.WriteLine(car);
}
Console.Write("----------------");
Array.Sort(cars);

foreach (string car in cars)
{
    Console.WriteLine(car);
}


Console.WriteLine(cars.Length); 
---------------------------------*/
/*------3-----------
using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        int numStudents;
        do
        {
            Console.Write("Enter number of students: ");
        } while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0);

        string[] studentIDs = new string[numStudents];
        double[] studentScores = new double[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter student ID for student {i + 1}: ");
            string id = Console.ReadLine();
            studentIDs[i] = id;

            double score;
            do
            {
                Console.Write($"Enter score for student {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100);
            studentScores[i] = score;
        }

        char input;
        do
        {
            Console.Write("Exit? (Y/N): ");
            input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (input != 'Y' && input != 'N');

        if (input == 'Y')
        {
            Console.WriteLine("Student Data:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student ID: {studentIDs[i]}, Score: {studentScores[i]}");
            }
        }
        else
        {
            Main(args);
        }
    }
}*/

/*------------4-----------
// Parent Class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
    }
}

// Child Class
class Student : Person
{
    public string School { get; set; }

    public Student(string name, int age, string school) : base(name, age)
    {
        School = school;
    }

    public void Study()
    {
        Console.WriteLine($"I'm studying at {School}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object from child class
        Student student = new Student("John", 20, "ABC University");
        student.Introduce(); // Output: Hi, my name is John and I'm 20 years old.
        student.Study(); // Output: I'm studying at ABC University.
    }
}

*/
