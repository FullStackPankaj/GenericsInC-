using System;

namespace Generics
{
    class Program
    {

        private class ExampleClass { }
        static void Main(string[] args)
        {

            Program pro = new Program();
            //  pro.CallGenericList();
            //pro.CallGenericNodeList();
            //ArrayListVsListofTypeT arrList = new ArrayListVsListofTypeT();
            //arrList.DoArrayList();
            //arrList.InvokeExceptionMyfriend();
            //arrList.ExampleOfListOfTypeT();
            // pro.CallGenericNodelistWithConstraint();

            //TestStringEquality();
            TestStringForTrueEquality();
            Console.ReadKey();

        }


        private void CallGenericNodelistWithConstraint()
        {

            Employee pansr = new Employee("PANKAJ", 1);
            Employee Umash = new Employee("Uma", 2);
            Employee Ramsh = new Employee("Raman", 3);
            //GenericNodeListUsingBaseClassConstraint<NonEmployee> Glist = new GenericNodeListUsingBaseClassConstraint<Employee>();
            GenericNodeListUsingBaseClassConstraint<Employee> Glist = new GenericNodeListUsingBaseClassConstraint<Employee>();
            Glist.AddHead(pansr);
            Glist.AddHead(Umash);


     

            foreach (var i in Glist)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nDone");

            Glist.FindFirstOccurrence("Uma");

        }

        private void CallGenericNodeList()
        {
            GenericNodeList<int> list = new GenericNodeList<int>();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nDone");
        }

        public void CallGenericList()
        {
            GenericList<int> intlist = new GenericList<int>();
            intlist.Add(1);

            GenericList<string> stringlist = new GenericList<string>();
            stringlist.Add("string");

            GenericList<ExampleClass> exampleClass = new GenericList<ExampleClass>();

            exampleClass.Add(new ExampleClass());
        }


        private static void TestStringEquality()
        {
            string s1 = "target";
            System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
            string s2 = sb.ToString();
            OpEqualsTest.OpEqualsTestMethod<string>(s1, s2);

        }


        private static void TestStringForTrueEquality()
        {
            string s1 = "target";
            System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
            string s2 = sb.ToString();
            OpEqualsViaInterface.OpEqualsTestMethod<string>(s1, s2);

        }
    }
}
