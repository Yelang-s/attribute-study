#define isTest

using System;
using System.Diagnostics;

namespace 特性
{
    class Program
    {
        // obsolete特性标记一个方法为过时方法，第一个参数为说明，第二参数为是否在调用时提示错误
        [Obsolete("请使用NewMethod方法", true)]
        static void OldMethod() { }
        static void NewMethod() { }

        // conditional特性，第一个参数为定义参数，需要使用#define定义，如果不定义，则在程序中不会调用此方法
        [Conditional("isTest")]
        static void Test1() { Console.WriteLine("test1"); }
        static void Test2() { Console.WriteLine("test2"); }


        static void Main(string[] args)
        {
            //OldMethod();

            //Test1();
            //Test2();
            //Test1();

            //MyCalss myCalss = new MyCalss
            //{
            //    Id = 1,
            //    threadId = 2,
            //    Name = "t1"
            //};
            //using (FileStream fs = new FileStream(".\\mycalss.xml", FileMode.CreateNew, FileAccess.Write))
            //{
            //    //BinaryFormatter binary = new BinaryFormatter();
            //    //binary.Serialize(fs, myCalss);
            //    XmlSerializer xmlSerializer = new XmlSerializer(myCalss.GetType(),"mycalsstest");
            //    xmlSerializer.Serialize(fs, myCalss);
            //}
            Console.ReadKey();
        }
    }

    [Serializable]// 可序列化类
    public class MyCalss
    {
        public int Id { get; set; }

        [NonSerialized] // 当不需要对某些变量进行序列化时，可使用NonSerialized进行标记
        public int threadId;

        public string Name { get; set; }
    }
}
