using System;

namespace AnnonymousMethodTest
{
    public delegate void BasicOperation();
    public delegate void DoSomething();
    public delegate int annonymousOperation1(int i);
    public delegate int annonymousOperation2(int a,int b);

    class Program
    {
        static void PrintReport(){
            Console.WriteLine("Printing a report: graph, table, score card");
        }
        static void Main(string[] args)
        {
            //registering callback function 
            BasicOperation method1=new BasicOperation(PrintReport);
            method1();

            //Inline function
            //Annonymous method
            BasicOperation method2 = delegate(){
                Console.WriteLine("Priting company annual report");
            };
            method2();

            //Lambda Expression
            DoSomething method3=()=>{Console.WriteLine("Printing covid spread lockdown report");};
            method3();

            annonymousOperation1 proxy1=new annonymousOperation1(
                delegate(int x){
                    return x*2;
                }
            );
            Console.WriteLine("{0}",proxy1(5));

            annonymousOperation1 proxy2=x=>x*2;
            Console.WriteLine("{0}",proxy2(25));


            annonymousOperation2 getBigInteger= (x,y) => {if (x >y) return x; else return y;};
            Console.WriteLine("Big integer:"+getBigInteger(10,20));

        }
    } 
}
