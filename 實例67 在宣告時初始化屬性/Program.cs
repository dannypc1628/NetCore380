using System;

namespace 實例67_在宣告時初始化屬性
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student stu = new Student();

            Console.WriteLine("學員編號：{0}\n學員姓名：{1}\n學習課程:{2}",stu.ID,stu.Name,stu.Course);

            Console.WriteLine("學員編號：{2}\n學員姓名：{1}\n學習課程:{0}", stu.ID, stu.Name, stu.Course);

        }
    }

    class Student
    {
        public long ID { get; set; } = 0L;
        public string Name { get; set; } = "新學員";

        public string Course { get; set; } = "C#";
    }
}
