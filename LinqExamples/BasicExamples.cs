using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class BasicExamples
    {
       public List<int> LinqQueryIntro()
       {
            //A LINQ query has 3 parts
        
            //1. The first part is obtaining the data, in this case, a simple integer array
            int[] numArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //2. The second part is the query execution. The query in created but not executed at this stage because of "deferred execution".
            // "deferred execution", aslo known as "lazy loading", means the the query in not executed until the query result is actually used
            IOrderedEnumerable<int> query = from num in numArray
                                            where num % 3 == 0
                                            orderby num descending
                                            select num;

            //3. Execution. The query is executed when the data from the query is requested, for example in a foreach loop
            foreach (var x in query)
            {
                Console.Write("{0} ", x);
            }

            //Other ways to force the execution of the query are
            int size = query.Count();

           //or

           List<int> list = query.ToList();
           return list;
       }

       public List<int> LinqMethodQueryIntro()
       {
           //A LINQ query has 3 parts

           //1. The first part is obtaining the data, in this case, a simple integer array
           int[] numArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           //2. The second part is the query execution. The query in created but not executed at this stage because of "deferred execution".
           // "deferred execution", aslo known as "lazy loading", means the the query in not executed until the query result is actually used
           IOrderedEnumerable<int> query = numArray.Where(x => x % 3 == 0)
                                                   .OrderByDescending(x => x);

           //3. Execution. The query is executed when the data from the query is requested, for example in a foreach loop
           foreach (var x in query)
           {
               Console.Write("{0} ", x);
           }

           //Other ways to force the execution of the query are
           int size = query.Count();

           //or

           List<int> list = query.ToList();
           return list;
       }

        //Create a dictionary from the entries that have the Surname "Stark"
        //The key should be the Name and the Value the Age
       public Dictionary<string, int> CreateDictionary()
       {
           //Define data
           Person[] persons = new Person[6] 
           {
             new Person() {Name = "Rob", Surname = "Stark", Age = 21  },
             new Person() {Name = "Joe", Surname = "Stark", Age = 32  },
             new Person() {Name = "Mark", Surname = "Lannister", Age = 2  },
             new Person() {Name = "Duke", Surname = "Nukem", Age = 88  },
             new Person() {Name = "Boss", Surname = "Big", Age = 15  },
             new Person() {Name = "Duck", Surname = "Quack", Age = 6  },
           };

           //Create the query
           //The query creates a IEnumerable of an Anonymus type with the field Name and Age
           var query = from pers in persons
                       where pers.Surname == "Stark"
                       select new { pers.Name, pers.Age };

            //Create the dictionary from the query
            return query.ToDictionary(t => t.Name, t => t.Age);
       }

       //The key should be the Name and the Value the Age
       public Dictionary<string, int> CreateDictionaryMethods()
       {
           //Define data
           Person[] persons = new Person[6] 
           {
             new Person() {Name = "Rob", Surname = "Stark", Age = 21  },
             new Person() {Name = "Joe", Surname = "Stark", Age = 32  },
             new Person() {Name = "Mark", Surname = "Lannister", Age = 2  },
             new Person() {Name = "Duke", Surname = "Nukem", Age = 88  },
             new Person() {Name = "Boss", Surname = "Big", Age = 15  },
             new Person() {Name = "Duck", Surname = "Quack", Age = 6  },
           };

           //Create the query
           //The query creates a IEnumerable simpler, without anonymus types
           return persons.Where(pers => pers.Surname == "Stark")
                         .ToDictionary(pers => pers.Name, pers => pers.Age);
       }

       class Person
       {
           public string Name;
           public string Surname;
           public int Age;
       }

    }
}
