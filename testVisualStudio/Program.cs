using System;
using static System.Console;

namespace testVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Write(myClass.MainMethod());
        }
    }
    class MyClass
    {
        public MyClass()
        {

        }
        public MyClass(string myFavoriteLanguage)
        {
            language = myFavoriteLanguage;
        }

        string language = string.Empty;
        public string MainMethod()
        {
            if (language != string.Empty)
            {
                return language + " is the best language";
            }
            return "The best language is C#";
        }
    }
}
