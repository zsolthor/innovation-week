using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstCS  //comment
{
    class Program
    {
        //https://www.udemy.com/course/understandingc/
        //Lecture 2: Declaring Variables
        //Lecture 3: Displaying Variables in the Console
        //Lecture 4: Using Arithmetic Operators
        //Lecture 5: Using Bools
        //Lecture 6: Using Char
        //Lecture 7: Using String
        //Lecture 8: Numeric Conversions
        //Lecture 9: Declaring Constants (enum)
        //Lecture 10: Console Input

        enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thurstday, Friday, Saturday };  // enum: group of constants
        //ha nincs szám, akkor 0-tól 6-ig van

        static void Main(string[] args)
        {
            //////////Lecture 2: Declaring Variables//////////
            ////int, double, string, bool, char
            //int myInt = 5; //initialization
            //myInt = 6;
            //int myInt2 = 10, myInt3 = 20;
            //int myInt4, myInt5;

            //string a = "Hello World";
            //In the above code, the variable a is declared as a string and is initialized to "Hello World".
            //var b = "hello world";
            //The var keyword specifies implicit typing.

            // int x; --deklaráció
            // X = 10; -- definició
            // int y = 11; --deklaráció és definició  reiter féle könyvben

            //Quiz kérdés volt: Which variable declaration compnent is NOT necessary?
            //Data Type, Identifier, Assigment Operator, Semicolon
            //--> Assigment operator   You do not have to give a variable an initial value. 
            //When You do, its called initialization.

            //int i = 100;// explicitly typed variable  //In C#, variables must be declared with the data type. These are called explicitly typed variables.
            //var j = 100; // implicitly typed local variable //C# 3.0 introduced var keyword to declare method level variables without specifying a data type explicitly.

            //int i = 10;
            //var j = i + 1; // compiles as int

            //var i; // Compile-time ERROR: Implicitly-typed variables must be initialized
            //i = 100;

            // var i = 100, j = 200, k = 300; // ERROR: cannot declare var variables in a single statement


            // 5 basic types
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello my world";
            bool myBool = true;
            char myChar = 'S';

            //////////Lecture 3: Displaying Variables in the Console//////////
            Console.WriteLine("Hello, World!");
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);  //mindig új sorba írja

            Console.Write(myString);
            Console.Write(myChar);  //egy sorba írja, nincs sortörés. --> Hello my worldS

            Console.WriteLine(" The value is myInt is {0}", myInt);  //first placeholder: {0}
            Console.WriteLine("The value of myInt is {0,-6} and the value of myDouble is {1,-5}", myInt, myDouble);
            // --> The value of myInt is 4 and the value of myDouble is 5,5
            // ha a placeholder helyére {0,5} {1,2}, akkor elsőben 5 és másodikban 2 space lesz érték előtt
            // ha negatív szám, akkor nem bal oldal, hanem jobb oldalra kerül a space
            // ha myInt 55555 és {0,-5} akkor nem lesz pluszban space jobb oldalon
            // ha myInt 55555 és {0,-1} akkor nem lesz pluszban space jobb oldalon de nem lesz hiba amiatt, hogy nagyobb a szükséges hely.
            // ha myInt 55555 és {0,-6} akkor egy plusz space lesz. 
            //myInt = 55555;
            //Console.WriteLine("The value of myInt is {0,-5} and the value of myDouble is {1,-5}", myInt, myDouble);
            //Console.WriteLine("The value of myInt is {0,-1} and the value of myDouble is {1,-5}", myInt, myDouble);
            //Console.WriteLine("The value of myInt is {0,-6} and the value of myDouble is {1,-5}", myInt, myDouble);

            Console.WriteLine("THe value of myInt is " + myInt); //concatenation
            //https://docs.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings#code-try-2
            Console.WriteLine("THe value of myInt is " + myInt + " and the value of myDouble is " + myDouble);
            //Console.WriteLine("The value of myInt is {0} and the value of myDouble is {1}", myInt, myDouble);
            // utolsó és utolsó előtti ugyanazt adja eredményül

            //////////Lecture 4: Using Arithmetic Operators//////////
            // + - * / % 
            int myInt4 = 5 + 5;  // 5 + 5    5-5   5 * 5
            Console.WriteLine(myInt4);

            double myDouble4 = 45 / 2;
            Console.WriteLine(myDouble4);  //--> 22 integer volt

            double myDouble4_1 = 45.0 / 2;
            Console.WriteLine(myDouble4_1);  //--> 22,5 

            double myDouble4_2 = 5 % 4;
            Console.WriteLine(myDouble4_2);  // --> 1 remain, ennyi maradt

            int myInt4_1 = 2 + 3 * 4;
            Console.WriteLine("The result is: {0}", myInt4_1);  // --> The result is: 14

            int myInt4_2 = myInt4 + myInt4_1;
            Console.WriteLine(myInt4_2);  // --> 24

            int myInt4_3 = 5;
            myInt4_3 = myInt4_3 + 1;  // x = x + 1;
            Console.WriteLine(myInt4_3);  // --> 6
            myInt4_3 += 1;  // x += 1;
            Console.WriteLine(myInt4_3);  // --> 7   
            //kettő megegyezik egymással:myInt4_3 = myInt4_3 + 1;    myInt4_3 += 1;
            myInt4_3++;  //postfix
            Console.WriteLine(myInt4_3);  // -->  8
            ++myInt4_3;  //prefix
            Console.WriteLine(myInt4_3);  // -->  9

            int myInt4_4 = 4;
            int myInt4_5 = myInt4_4++;
            Console.WriteLine("The value of myInt4_4 is: {0} and the value of myInt4_5 is: {1}", myInt4_4, myInt4_5);
            // -->  5   4   ez volt postfix
            // balról jobbra haladunk: myInt4_5 megkapja a négyet myInt4_4 utána növeli eggyel

            int myInt4_6 = 4;
            int myInt4_7 = ++myInt4_6;
            Console.WriteLine("The value of myInt4_6 is: {0} and the value of myInt4_7 is: {1}", myInt4_6, myInt4_7);
            // -->  5   5   ez volt prefix
            // balról jobbra haladunk: myInt4_7 megkapja a növelt értéket

            //POST and PREFIX:

            // ++ if used as postfix on a variable, the value of variable is first returned and then gets incremented by 1
            //int a, b;
            //a = 10;
            //Console.WriteLine(a++);
            //b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);  ========> 10, 11, 11

            //++ if used as prefix on a variable, the value of variable gets incremented by 1.After that the value is returned unlike Postfix operator.
            //int a, b;
            //a = 50;
            //Console.WriteLine(++a);
            //b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);  ========> 51, 51, 51

            //Other example:
            //int original = 10;
            //int result;
            //// increment then assign
            //result = ++original;
            //Console.WriteLine("After prefix: {0}, {1}", original, result);
            //// assign then increment
            //result = original++;
            //Console.WriteLine("After postfix: {0}, {1}", original, result);   ========>  After prefix: 11, 11  After postfix: 12, 11


            //////////Lecture 5: Using Bools//////////

            // > >= <= < == !=
            bool myBool5 = true;
            bool myBool5_2 = 5 > 6;
            myBool5_2 = 6 != 6;
            Console.WriteLine(myBool5);
            Console.WriteLine(myBool5_2);

            int hoursWorked = 41;
            bool doesEmployeeGetOverTime = hoursWorked > 40;
            Console.WriteLine("Does emloyee get overtime? {0}", doesEmployeeGetOverTime); // ---> True

            //////////Lecture 6: Using Char//////////
            char myChar6 = 'A';
            char myChar6_1 = '5';
            char myChar6_2 = '*';
            char myChar6_3 = '\''; //backslash kell '\"' 
            char myChar6_4 = '\n'; //new line \t-TAB
            Console.WriteLine(myChar6_4);
            Console.WriteLine(myChar6_3);

            //////////Lecture 7: Using String//////////
            string MyString7 = "Hello \"= bello";
            Console.WriteLine(MyString7);
            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = firstName + lastName;  // The + operator can be used between strings to combine them. This is called concatenation.
            //string name = string.Concat(firstName, lastName);
            // string name = $"My full name is: {firstName} {lastName}"; //Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string
            // Console.WriteLine(myString[1]);  // Outputs "e"
            // string myString = "Hello"; Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
            // string txt = "We are the so-called \"Vikings\" from the north.";  ---> We are the so-called "Vikings" from the north.
            // \n - newline, \t - tab, \b - backspace

            string name1 = "Jesse";
            string name2 = "Jesse";
            bool namesEqual = name1 == name2;  //V1 összehasonlítás
            bool namesEqual2 = string.Equals(name1, name2);  //V2 összehasonlítás
            int namesEqual3 = string.Compare(name1, name2);  //V3 összehaonlítás; itt int!!!
            //0 megegyezik; -1 nem egyezik meg Bob-Jessie; 1 nem egyezik meg: Jessi-Bob jessie is greater than bob
            int namesequel4 = name1.CompareTo(name2);  //V4 öszehasonlítás, olyan mint előző V3 int -1 0 1 
            Console.WriteLine("name1 == name BOOL  names equal: {0}", namesEqual);
            Console.WriteLine("string.Equals(name1, name2) BOOL names equal: {0}", namesEqual2);
            Console.WriteLine("string.Compare(name1, name2) INT names equal: {0}", namesEqual3);
            Console.WriteLine("name1.CompareTo(name2) INT names equal: {0}", namesequel4);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);  //--> jesse 5
            //.Length megszámolja karaktereket

            string firstCharacterOfName = name1.Substring(1, 2);
            Console.WriteLine(firstCharacterOfName);  // (0, 1)--> J   // (1, 2) --> es
            //.Substring első szám honnan kezdje(0-val kezdődik index mindig), második szám mennyi karaktert. 

            bool startsWith = name1.StartsWith("Je");
            Console.WriteLine(startsWith);
            //.StartsWith ezzel kezdődik-e

            //////////Lecture 8: Numeric Conversions//////////

            int x8 = 5;
            double y8 = x8;  //implicit cast
            Console.WriteLine(y8);
            //fordítva nem megy: cannot implicitly convert double to int.

            double myDouble8 = 5.5;
            int myInt8 = (int)myDouble8;  // explicit cast
            //itt force van, ha nem zavar, hogy eldoja .5-öt
            Console.WriteLine(myInt8);

            //////////Lecture 9: Declaring Constants//////////

            const int myConstInt = 7;
            // nem lehet értéket változtatni: myConstInt = 1;
            //Math.PI = 999;  //ezt sem lehet változtatni Pi értéke
            Console.WriteLine(Math.PI);  //kiiratjuk PI értékét  --> 3.14159265358979

            //enum fent van definiálva. // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables)
            //enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thurstday, Friday, Saturday };

            DayOfWeek today = DayOfWeek.Friday;
            Console.WriteLine(today);  // --> Friday
            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);  // --> 5

            //////////Lecture 10: Console Input//////////

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Nagyon örülök Neked {0} {1}", lastName, firstName);

            Console.WriteLine("Enter a number:");
            int numberFromUser = int.Parse(Console.ReadLine());
            numberFromUser += 10;
            numberFromUser = numberFromUser + 10;   //2 változat: növelni 10-zel
            Console.WriteLine("The new number is {0}", numberFromUser);

        }
    }
}

/*
 * multiline 
 * commnet
 * */
