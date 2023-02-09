using System;
using System.Collections;

namespace Generic_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Geetha");
            arrayList1.Add(false);
            arrayList1.Add(4.5);

            Console.WriteLine(arrayList1[3]);
            Console.WriteLine(arrayList1.Contains("Geetha"));
            Console.WriteLine(arrayList1.Count);

            arrayList1.Insert(2, "samynathan");

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("india");
            arrayList2.Add("germany");
            arrayList2.Add("france");
            arrayList2.Add(230);
            arrayList2.Add("australia");
            arrayList2.Add("uae");
            arrayList1.InsertRange(3, arrayList2);
            Console.WriteLine("\n\nAfter insertrange arrayList1 values are:");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.Remove("germany");

            Console.WriteLine("\n\nAfter removing germany arraylist1 values are:");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.RemoveAt(0);
            Console.WriteLine("\n\n after remove(0) arraylist1 values are:");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.RemoveRange(3, 2);
            Console.WriteLine("\n\nAfter removerange(3,2) arraylist1 values are");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList1.Clear();
            Console.WriteLine("\n\n After clear allelements " + arrayList1.Count);

            ArrayList clonedArrayList = (ArrayList)arrayList2.Clone();

            Console.WriteLine("cloned arraylist values are");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            int[] myarray = new int[3];
            object[] arrayListcopy = new object[arrayList2.Count];
            arrayList2.CopyTo(arrayListcopy);
            Console.WriteLine("ArrayList copy");
            foreach (var item in arrayListcopy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sort arraylist values");
            arrayList2.Sort();
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
