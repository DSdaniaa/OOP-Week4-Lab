using lab5.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            UAMS();
        }
        static void Task1()
        {
            float merit;
            bool flag;
            students stu = new students("ali", 3.75F, 2, 345, 980, 789, "Lahore", true, true);
            merit =stu.calculateMerit();
            Console.WriteLine("Merit is: {0}", merit);
            flag = stu.isEligibleforScholarship(merit);
            Console.WriteLine("Eligible: {0}", flag);
            Console.ReadKey();




        }
        static void Task2()
        {
            book books = new book("Ali", 500, 10, 900);
            books.addChapters("flowers");
            books.addChapters("plants");
            Console.WriteLine("BookMark: {0}",books.getBookMark());
            Console.WriteLine("Price: {0}", books.getBookPrice());
            Console.WriteLine("Chapter 1: {0}", books.getChapter(1));
            books.setBookMark(20);
            books.setBookPrice(1000);
            Console.WriteLine("new BookMark: {0}", books.getBookMark());
            Console.WriteLine("new Price: {0}", books.getBookPrice());
            Console.ReadKey();
        }
        static void Task3()
        {
            float tax;
            Customer person = new Customer("Ali", "UET Lahore", "03205678439");
            product pro = new product("eggs", "grocery", 100);
            product pro1 = new product("candy", "grocery", 50);
            tax = pro.CalculateTax();
            Console.WriteLine(tax);
            person.AddProduct(pro);
            person.AddProduct(pro1);
            List<product> list = new List<product>();
            list= person.getAllProducts();
            
            Console.ReadKey();

        }
        static void UAMS()
        {
            List<Student> studentList = new List<Student>();
            List<Student> FinalStudentList = new List<Student>();
            List<DegreeProgram> programList = new List<DegreeProgram>();
            char choice;
            
            do
            {
                choice = mainMenu();
                if (choice == '1')
                {
                    studentList.Add(AddStudent(studentList,programList));
                }
                else if (choice == '2')
                {
                    programList.Add(degreeProgram());
                }
                else if (choice == '3')
                {
                    FinalStudentList = studentList;
                    GenerateMerit(FinalStudentList);
                }
                else if (choice == '4')
                {
                    RegStudents(FinalStudentList);
                }
                else if (choice == '5')
                {
                    SpecificDegree(FinalStudentList);
                }
                else if (choice == '6')
                {
                    RegisterSubject(FinalStudentList);

                }
                else if (choice == '7')
                {
                    GenerateFee(FinalStudentList);
                }

            } while (choice != '8');
            Console.WriteLine("Pres Any Key To Exit.....");
            Console.ReadKey();
        }
        static char mainMenu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("********************************************");
            Console.WriteLine("                     UAMS");
            Console.WriteLine("********************************************");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Your Choice: ");
            option = char.Parse(Console.ReadLine());
            return option;
            
        }
        static Student AddStudent(List<Student> s, List<DegreeProgram> d)
        {
            Console.Clear();
            string name, prefName;
            int age;
            float fsc, ecat;
            int pref;
            List<string> temp = new List<string>();
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSC Marks: ");
            fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Student ECAT Marks: ");
            ecat = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs: ");
            for (int x = 0; x < d.Count(); x++)
            {
                Console.WriteLine(d[x].degreeName);
            }

                Console.Write("Enter How Many Preferencees to Enter: ");
            pref = int.Parse(Console.ReadLine());
            for(int i=0; i < pref; i++)
            {
                Console.Write("Enter Program Name: ");
                prefName = Console.ReadLine();
                for(int x = 0; x < d.Count(); x++)
                {
                    if (d[x].degreeName == prefName)
                    {
                        temp.Add(prefName);
                    }
                }
                
            }
            Console.Write("Press any key to continue....");
            Console.ReadKey();
            Student stu = new Student(name,age,fsc,ecat,temp);
            return stu;
            
        }
        static DegreeProgram degreeProgram()
        {
            Console.Clear();
            List<Subject> sub = new List<Subject>();
            string name, type,code;
            int duration, seats, hours,count;
            float fees;
            Console.Write("Enter Degree Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            Console.Write("How Many Subjects to Enter: ");
            count = int.Parse(Console.ReadLine());
            DegreeProgram degree = new DegreeProgram(name, duration, seats);

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Subject Code: ");
                code = Console.ReadLine();
                Console.Write("Enter Subject Type: ");
                type = Console.ReadLine();
                Console.Write("Enter Subject Credit Hours:");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Fees: ");
                fees = float.Parse(Console.ReadLine());
                Subject temp = new Subject(code, type, hours, fees);
                degree.AddSubject(temp);
            }
            Console.Write("Press any key to continue....");
            Console.ReadKey();
            return degree;
           
        }
        static void GenerateMerit(List<Student> s)
        {
            Student temp;
            Console.Clear();
            float merit;
            for (int i=1; i < s.Count(); i++)
            {
                if(s[i-1].Merit < s[i].Merit)
                {
                    temp = s[i-1];
                    s[i - 1] = s[i];
                    s[i] = temp;
                }

            }
        }
        static void RegStudents(List<Student> s)
        {
            for (int i = 0; i < s.Count(); i++)
            {
                Console.WriteLine("Name: {0}  FSC: {1}  Ecat: {2}  Age: {3}", s[i].Name, s[i].FscMarks, s[i].EcatMarks, s[i].Age);
            }
            Console.Write("Press any key to continue....");
            Console.ReadKey();
        }
        static void SpecificDegree(List<Student> s)
        {
            Console.Clear();
            string name;
            Console.Write("Enter Degree Name: ");
            name = Console.ReadLine();
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i].regDegree.degreeName == name)
                {
                    Console.WriteLine("{0}   {1}   {2}   {3}", s[i].Name, s[i].FscMarks, s[i].EcatMarks, s[i].Age);
                }
            }
            Console.Write("Press any key to continue....");
            Console.ReadKey();
        }
        static void RegisterSubject(List<Student> s)
        { 
            Console.Clear();

            string name, code;
            Console.Write("Enter the student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter the Subject Code: ");
            code = Console.ReadLine();
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i].Name == name)
                {
                    for(int t = 0; t < s[i].regDegree.subjects.Count(); t++)
                    {
                        if (s[i].regDegree.subjects[t].code== code)
                        {
                            s[i].regStudentSubject(s[i].regDegree.subjects[t]);
                        }
                    }

                }
            }

        }
        static void GenerateFee(List<Student> s)
        {
            Console.Clear();
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine("Name: {0}  Fees: {1}", s[i].Name, s[i].calculateFee());
            }

        }
    }
    

}
