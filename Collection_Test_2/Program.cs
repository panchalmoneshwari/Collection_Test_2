using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Test_2
{
    //1.	WAP to sort the elements of List that contains String objects. Print List.
    class Programming_Language
    {
        static void Main(string[] args)
        {

            List<Language> s = new List<Language>();
            s.Add(new Language("C Language"));
            s.Add(new Language("C++"));
            s.Add(new Language("C#"));
            s.Add(new Language("Java"));
            s.Add(new Language("Python"));
            foreach (object q in s)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            s.Sort();
            foreach (object q in s)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }
    class Language : IComparable<Language>
    {
        string lan_name;
        Language()
        { }

        public Language(string lan_name)
        {
            this.lan_name = lan_name;
        }
        public string lan_nameproperty
        { get { return lan_name; } set { lan_name = value; } }

        public int CompareTo(Language other)
        {

            return this.lan_name.CompareTo(other.lan_name);
        }

        public override string ToString()
        {
            return $"Language=>{lan_name}";
        }
    }
    //2.	WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List.
    class Debug_start
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee("S.P.Krishnamurty", "CMO", 40000));
            emp.Add(new Employee("K.P.Narayan", "CTO", 70000));
            emp.Add(new Employee("B.U.Bhat", "COO", 80000));
            emp.Add(new Employee("K.V.Yadav", "CEO", 90000));
            emp.Add(new Employee("A.M.Chaturvedy", "CFO", 50000));
            foreach (object q in emp)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("///////////////////////////////////////////////////////");
            emp.Sort(new sortbysalary());
            foreach (object q in emp)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }

    }
    class sortbysalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            dynamic val = (x.Salary > y.Salary) ? -1 : (x.Salary < y.Salary) ? 1 : 0;
            return val;
        }
    }
    class sortbydesignation : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Designation.CompareTo(y.Designation);
        }
    }
    class sortbyname : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class Employee : IComparable<Employee>
    {
        string name, designation;
        long salary;
        public Employee()
        { }

        public Employee(string name, string designation, long salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public long Salary { get => salary; set => salary = value; }

        public int CompareTo(Employee other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return $"Name={name} designation={designation} Salary={salary}";
        }
    }
    //3.	WAP to create a Queue with some colors (String) using generics.
    class Question_3
    {
        static void Main(string[] args)
        {
            Queue<string> colors = new Queue<string>();
            colors.Enqueue("Green");
            colors.Enqueue("Blue");
            colors.Enqueue("Red");
            colors.Enqueue("Yellow");
            colors.Enqueue("orange");
            foreach (object q in colors)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }

    }
    	//4.WAP to add user defined objects of type Employee in a HashSet employee object.
        //Make sure if I create 2 different objects with same data the other one should not be added as hashset stores unique objects.
    class Ques_4
    {
        static void Main(string[] args)
        {
            HashSet<School> sh = new HashSet<School>();
            sh.Add(new School(1, "Ram vidyalaya", 98));
            sh.Add(new School(2, "shaam vidyalaya", 97));
            sh.Add(new School(1, "Ram vidyalaya", 98));
            foreach (object q in sh)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();

        }
    }
    public class School 
    {
        int stud_id;
        string name;
        int percent;

        public School(int stud_id, string name, int percent)
        {
            this.Stud_id = stud_id;
            this.Name = name;
            this.Percent = percent;
        }

        public int Stud_id { get => stud_id; set => stud_id = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }

        public override bool Equals(object obj)
        {
            return Equals(obj as School);
        }
        public bool Equals(School other)
        {
            return other != null &&
                Stud_id == other.Stud_id &&
                Name == other.Name &&
                Percent == other.Percent;
        }

        public override int GetHashCode()
        {
            var hashCode = 534210186;
            hashCode = hashCode * -1521134295 + stud_id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + percent.GetHashCode();
            hashCode = hashCode * -1521134295 + Stud_id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Percent.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Students ID={stud_id} Name={name} Percent={percent}";
        }
    }
    // 5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class Sort_list
    {
        static void Main(string[] args)
        {
            SortedList<int,string> ss = new SortedList<int,string>();
            ss.Add(1, "One");
            ss.Add(5, "Five");
            ss.Add(4, "Four");
            ss.Add(3, "Three");
            ss.Add(2, "Two");
            foreach (var q in ss)
            {
                Console.WriteLine(q.Key+" "+q.Value);
            }
            Console.ReadLine();
        }
    }
    //8.	WAP to create SortedList<Employee,string> where key is of Employee type and value is 
    //departmentname(string) he works in. SortedList should maintain data in descending order 
    //of salary

    class Question_8
    {
        static void Main(string[] args)
        {
            SortedList<Employee, string> e = new SortedList<Employee, string>(new sortbysalary());
            e.Add(new Employee("S.P.Krishnamurty", "CMO", 40000),"Finance");
            e.Add(new Employee("K.P.Narayan", "CTO", 70000),"Technical");
            e.Add(new Employee("B.U.Bhat", "COO", 80000),"HR");
            e.Add(new Employee("K.V.Yadav", "CEO", 90000),"Administrative");
           
            foreach (var q in e)
            {
                Console.WriteLine(q.Key + " " + q.Value);
            }
            Console.ReadLine();
        }

    }
    //6.	WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class Dictionary_class
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> dd = new Dictionary<string, float>();
            dd.Add("KK_rating", 4.5f);
            dd.Add("SR_rating", 3.5f);
            dd.Add("DD_rating", 4.6f);
            dd.Add("JU_rating", 4.4f);
            dd.Add("CM_rating", 3.8f);
            foreach (var q in dd)
            {
                Console.WriteLine(q.Key + " " + q.Value);
            }
            Console.ReadLine();
        }
    }
    //7.	Make use of such collection that stores moviename such that last entered movie is first
    //deleted and accordingly previous one.
    class stack_class
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("Bhahubali");
            st.Push("RRR");
            st.Push("MS Dhoni");
            st.Push("Dangal");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("___________________________________________________________");
            st.Pop();
            st.Pop();
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
    public delegate void mydel(int b,int a);
    class A
    {
        public static void Even(int b,int a)
        {
            int c = a + b;
            if(c%2==0)
                Console.WriteLine("even");
            else
                Console.WriteLine("Odd");
        }
        public static void Factorial(int a,int b)
        {
            int fact = 1;
            int s = a > b ? a : b;
            for (int i = 1; i <= s; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial=" + fact);
        }
        static void Main(string[] args)
        {
            mydel f = Even;
            f += Factorial;
            f(6,2);
            Console.ReadLine();
        }
    }
    public delegate void mydel2(int b);
    class M
    {
        public static void Even(int c)
        {
            if (c % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("Odd");
        }
        public static void Factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial=" + fact);
        }
        public static void Prime(int a)
        {
            int c = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    c++;
            }
            if (c == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
        static void Main()
        {
            mydel2 f = Even;
            f += Factorial;
            f += Prime;
            f -= Even;
            f(10);
            Console.ReadLine();
        }
    }
    class duplicate
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
           
            for (int i = 0; i < ss.Length; i++)
            {
                int c = 1;
                for (int j = i+1; j < ss.Length; j++)
                {
                    if (ss[i].Equals(ss[j]) && ss[i] != "")
                        {
                        c++;
                        ss[j] = "0";
                    }
                }
                if(c>1&&ss[i]!="0")
                    Console.WriteLine(ss[i]);
                Console.ReadLine();   
            }
        }

    }
    class Ad
    {
        static void Main(string[] args)
        {
            SortedList a = new SortedList();
            a.Add(1,"k");
            a.Add(7,"b");
            a.Add(3,"c");
           
            foreach (DictionaryEntry s in a)
            {
                Console.WriteLine(s.Key+""+s.Value);
            }
            Console.ReadLine();
        }
    }
    class Testy
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int next = a % 10;
            a = a / 10;
            int prev;
            bool inc = true;
            bool dec = true;
            while (a > 0)
            {
                prev = a % 10;
                if (prev > next)
                {
                    inc = false;
                }
                else if (prev < next)
                {
                    dec = false;
                }
                a = a / 10;
                next = prev;
            }
            if(inc==true)
                Console.WriteLine("Increament");
            else if (dec==true)
                Console.WriteLine("Decreament");
            else if(inc==false||dec==false)
                Console.WriteLine("Bouncy");
            Console.ReadLine();
        }
    }
    class Max
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[0]<arr[i+1])
                arr[0] = arr[i+1];
            }
            Console.WriteLine(arr[0]);
            Console.ReadLine();
        }
    }
    class practice1
    {
        static void Main(string[] args)
        {
            string s= "priyanka";
            string d= "";
            for (int i = s.Length-1; i >=0; i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadLine();
        }
    }
}
