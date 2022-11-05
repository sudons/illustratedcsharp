using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqTuning
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<Student, bool> func = new Func<Student, bool>(Test);


            List<Student> stuList = new List<Student>()
            {
                new Student(){ID=001,Age=17,Name="朱思学",Major="电子商务"},
                new Student(){ID=002,Age=25,Name="李立天",Major="高等数学"},
                new Student(){ID=003,Age=23,Name="陈志明",Major="电子商务"},
                new Student(){ID=004,Age=20,Name="胡家凡",Major="经济管理"},
                new Student(){ID=005,Age=20,Name="汪南峰",Major="经济管理"},
                new Student(){ID=006,Age=16,Name="陈夏菁",Major="应用物理"},
                new Student(){ID=007,Age=21,Name="程丹平",Major="电子商务"},
                new Student(){ID=008,Age=17,Name="黄泽锦",Major="工程造价"},
                new Student(){ID=009,Age=18,Name="车艳琴",Major="信息工程"},
                new Student(){ID=010,Age=21,Name="胡明珠",Major="软件工程"},
                new Student(){ID=011,Age=20,Name="刘行行",Major="软件工程"},
                new Student(){ID=012,Age=22,Name="刘锦飞",Major="应用物理"},
                new Student(){ID=013,Age=28,Name="郭杜成",Major="电子商务"},
                new Student(){ID=014,Age=25,Name="韩海东",Major="电子商务"},
                new Student(){ID=015,Age=22,Name="曹虎明",Major="土木工程"},
            };
            #region
            List<Student> list = new List<Student>();
            foreach (var stu in stuList)
            {
                if (stu.Age == 20)
                {
                    list.Add(stu);
                }
            }

            List<Student> list2 = new List<Student>();
            foreach (var stu in stuList)
            {
                if (stu.Major=="电子商务")
                {
                    list2.Add(stu);
                }
            }
            #endregion

            //自定义Linq
            List<Student> list3 = LinqExtendHelpers.AnWhere(stuList,func);
            List<Student> list4 = LinqExtendHelpers.AnWhere(stuList, func);
            List<Student> list5 = stuList.AnWhere(func);
            IEnumerable <Student> list6 = stuList.AnWhere(func);
            foreach (var item in list6)
            {
                Console.WriteLine(item.Name);
            }
            //官方的Linq
            List<Student> list7 = stuList.Where(x => x.Age < 20).ToList();
        }

        public static bool Test(Student stu)
        {
            return stu.Age < 20;
        }



 
        
    }
}
