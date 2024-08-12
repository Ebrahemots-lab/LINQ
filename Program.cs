namespace IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly typed local Variable

            #endregion

            #region Var Keyword
            //What is var?
            //var is keywork tin c# can Detect dataype based on the value 
            int x = 3;
            //compiler know that x is integer based on the value that we passed [3]
            //so if the compiler can detect the datatype in the compilation time 
            //why we need to tell him that this 3 is int ?

            //we use keyword var to make the compiler detect the data type automatic
            var z = 3;
            //this this line the compiler will detect z data type based on the value 3

            //z = 3.5; //Invalied

            //we can't re assign the value after we declare it z now hold int values 
            //we can't assign another value from another datatype on it


            /*
             * var in javascript we can assign another value from datatype 
             * 
             * var x = 10;
             * x = "ebrahem" //valid
             * 
             * 
             * C#
             * var x = 10;
             * x = "ebrahem" ; //invalied
             * 
             * 
             */




            //Why we use var?
            //1 - sometimes we can't indentify the data type of the variable or object so we use var
            //2 -sometimes we need to make our code clear and more simple to read
            //Ex : Dicationary<string,list<users>> diction = new Dictionary <string,list<users>>();
            // in this case we can identify that this dictionary has key string and value list of users 
            //so we don't need to identify the datatype we can use var
            //Dicationary<string,list<users>> diction = new Dictionary <string,list<users>>()
            //var diction = new Dictionary <string,list<users>>() => this is more clear

            #endregion

            #region Dynamic
            //Dynamic is similar to Js
            dynamic v = 10;
            v = "Ebrahem6"; //Valid
            #endregion

            #region Anonymous Object
            /*
             * in some cases we need to use some attributes only or user something from a class
             * without declareing or making a new class 
             * Ex : if we need to only use or display the age of the user from database we dont need
             * to create a class for user that hold this age onyl
             * we simply create anonymous object
             */

            //new { UserId = 1, Salary = 1000 }; //This is called Anonymous obj
            //how is this happend?
            //compiler will create anonymous Class that hold attributes[UserId , Salary]
            //then compiler will make an object from this class 

            //?? user = new { UserId = 1, Salary = 1000 };
            //what is the data type we can declare for this user object?
            //we can user object
            //object user = new { UserId = 1, Salary = 1000 };
            /*
             * in this case we can't reach the attributes in the user because it's an object
             */

            var user = new { UserId = 1, Salary = 1000 };
            //we user var because we can't identify the data type
            //a => anonymous object from anonymous class

            #endregion

            #region Extention Methods
            /*
             * Extention Methods :
             * we created it to extend out datatype funcrionality 
             * 
             *Steps to create Extention Methods :
             *1 - Must be public and static
             *2 - Must be in static class
             *3 - the datatype we need to extend must be in the first parameter
             *4 - we type this keyword befor the first parameter
             */
            #endregion

            #region ExtentionMethods Examples

            #region Ex01
            //string message = "Hello World!";

            //message.Print(); //Extention method for string 
            #endregion

            #region Ex02
            //List<int> numbers = new List<int> { 1, 2, -10, 7, 8, 12, -1, 99 };

            //var result = numbers.ArrayOperation(x => x < 0);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Ex03
            // string text = "ebrahem ashraf";

            //string result =  text.ToTitleCase();
            //Console.WriteLine(result);

            #endregion

            #endregion

            #region IntroductionToLinQ

            //Linq => stands for Language Integreted Query
            //Linq help us to write a query to data regardless to data source



            //Sequence : Object must be implement interface => IEnumerable

            //Local Sequance => sequence that in our Computer.. L2O => LinqToObject ,L2XML => LinqToXml
            //Remote Sequance => stored in server [Database] => L2EF

            //var numbers = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10 };

            //var result  = Enumerable.Where(numbers,N => N > 3);

            //var result = numbers.Where(N => N > 3);

            //foreach(int item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Linq Syntax

            //Fluent syntax =>
            //Calling using the class


            //List<int> numbers = new List<int>() { 1,2,3,4,5,6,7};

            //var result = Enumerable.Where(numbers, N => N > 2);


            //var result2 = numbers.Where(N => N > 2);


            ////Query syntax => 



            //var result3 = from n in numbers
            //             where n > 2
            //             select n;


            #endregion

            #region Linq Execution Ways
            //Differed Execution : 10 Category
            //Immidiate Execution : 3 Category



            //List<int> ints = new List<int>() { 1,2,3,4,5,7};

            //var result = ints.Where(N => N > 3); // Differed


            //ints.AddRange(new int[] { 8,9,10});

            //foreach(int item in ints) 
            //{
            //    Console.WriteLine(item);
            //}





            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 7 };

            //var result = ints.Where(N => N > 3).ToList(); // Differed


            //ints.AddRange(new int[] { 8, 9, 10 });

            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Data Setup
            Console.WriteLine(ListGenerator.ProductsList[0]);
            #endregion

        }


    }
}
