using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            //// 01. Hello World
            HelloWorld myHelloWorld = new HelloWorld();
            myHelloWorld.PrintHelloWorld();


            //// 02. Basic Syntax
            Rectangle myRectangle = new Rectangle();
            myRectangle.Acceptdetails();
            myRectangle.Display();



        }
    }
}
