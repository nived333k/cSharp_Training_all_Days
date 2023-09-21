using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionClass
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList alist = new ArrayList();
            //alist.Add(10);
            //alist.Add("name");
            //alist.Add(.23323);
            //alist.Insert(3, "i just inserted to location 3 in an array");

            //// var is implicitly typed
            //foreach(var item in alist)
            //{
            //    Console.WriteLine(item);

            //}

            //Console.WriteLine("the count {0}",alist.Count);
            //Console.WriteLine("the capacity is {0}", alist.Capacity);
            //alist.Add("jai sri ram");
            //alist.Add("jai sri ram");
            //alist.Add("jai sri ram");
            //alist.Add("jai sri ram");
            //alist.Add("jai sri ram");
            //foreach (var item in alist) {   

            //    Console.WriteLine(item);

            //}

            //Console.WriteLine("the capacity is {0}", alist.Capacity);

            ////inserting a range of values 

            //ArrayList alist2 = new ArrayList();
            //alist2.Add(23);
            //alist2.Add("arun 2.0");
            //alist2.Add("esakki 4.6");
            //Console.WriteLine( "the capacity is {0}", alist2.Capacity);



            //alist.InsertRange(6, alist2);

            //foreach(var item2 in alist)
            //{
            //    Console.WriteLine(item2);
            //}


            ////remove the elements in a praticular postion

            //alist.Remove("arun 2.0");


            //alist.RemoveAt(3);

            //alist.RemoveRange(3, 6);

            //foreach (var item2 in alist)
            //{
            //    Console.WriteLine(item2);
            //}


            ////problem with array list 
            ////sort an array lsit

            ////in sort we need the varaible inside an arrayList to be of same  data type 

            //ArrayList alist3 = new ArrayList();
            //alist3.Add("esakki");
            //alist3.Add("mesakki");
            //alist3.Add("hesakki");
            //alist3.Add("deesakki");
            //alist3.Sort();
            //foreach(var essaki in alist3)
            //{
            //    Console.WriteLine(essaki);
            //}
            // hashtableex();
            //sortedlistex();
            stack();

            Console.ReadLine();

        }
        static void hashtableex()
        {
            //hashtable is predefined 
            Hashtable ht = new Hashtable();
            ht.Add("1","nived");
            ht.Add(2,"esakki");
            ht.Add(3, "arun");

            //.keys give the location of the hash 
            //.value give the value of the hash 
            foreach(var item10 in ht.Keys)
            {
                Console.WriteLine(item10);
                
            }
            foreach (var item10 in ht.Values)
            {
                Console.WriteLine(item10);
                
            }
            //in order to iterate both keys and values we use a structure knows dictionary

            Console.WriteLine("using dictionary entry");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key);
                Console.Write(de.Value);
                
            }
            //hashtable is useful for search operation       
            Console.WriteLine("search  a key /value");
            Console.WriteLine("enter the key ");
            string empval = Console.ReadLine();
            if (ht.ContainsKey(empval))
            {
                Console.WriteLine("the value exist {0}" ,ht[empval]);
            }
            else
            {
                Console.WriteLine("the value doesnot exist");
            }

            
        }

        static void sortedlistex()
        {
            SortedList sl = new SortedList();
            sl.Add("pb", "o");
            sl.Add("mb", "or");
            sl.Add("cb", "ora");
            sl.Add("bb", "orac");

            //foreach(var values in sl.Keys)
            //{
            //    Console.WriteLine(values);
            //    Console.ReadLine();   
            //}
            //foreach(DictionaryEntry de in sl)
            //{
            //    Console.WriteLine(de.Key);
            //    Console.Write(de.Value);

            //}
        }

        static void stack()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            foreach(object item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            Console.WriteLine(st.Peek());
            foreach(object item in st)
            {
                Console.WriteLine(item);
            }


        }

        //generics are also classes 

        //non generic - arraylist ,hashtable , sortedlist , 
        


    }
   
    
    
    
    

}
