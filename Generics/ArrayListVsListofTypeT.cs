using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class ArrayListVsListofTypeT
    {
        public ArrayList arrList = new ArrayList();
        public void DoArrayList()
        {
            
            arrList.Add(1);
            arrList.Add("You are doing something real funny man");
            arrList.Add(2);
            arrList.Add("very very funny");
            arrList.Add(3);
            arrList.Add("we are in trouble man");

        }
        

        public void InvokeExceptionMyfriend()
        {
            int t = 0;
            // This causes an InvalidCastException to be returned.
            foreach (int x in arrList)
            {
                t += x;
            }
        }


        public void ExampleOfListOfTypeT()
        {
            List<int> listOFint = new List<int>();
            listOFint.Add(1); //no boxing no casting
            //listOFint.Add("2"); error

        }
    }
}
