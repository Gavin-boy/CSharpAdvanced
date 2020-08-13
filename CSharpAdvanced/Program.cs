using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class Program
    {
        /*
         * 静态方法：
         *      特点：1、生命周期——一旦创建-应用结束才会结束。2、全局。3、效率高
         *      用处：用户登录信息、系统配置信息、系统设置、SQlHelper
         *      注意：静态的东西创建多了占用内存会很大，不是必要情况不要创建静态对象
         *      调用：静态方法调用非静态方法不能直接调用，把所在类初始化后再调用
         * 构造方法：
         *      用处：1、初始化对象，2、或者初始化一些数据局
         *      特点：默认是有一个无参数构造方法，可以多个并重载
         * 析构方法：
         * 
         * 
         * 虚方法-virtual
         * 重写方法-override
         * 抽象方法-abstract
         * 扩展方法
         */
        static void Main(string[] args)
        {
            TestStaticMethod testStaticMethod = new TestStaticMethod();
            testStaticMethod.Test();
            Test();

            CtorMethod ctor = new CtorMethod();
            Console.Read();
        }
        public static void Test()
        {
             Console.WriteLine("我是静态方法");
        }
    }
    /// <summary>
    /// 静态方法测试
    /// </summary>
    class TestStaticMethod
    {
        public void Test()
        {
            Console.WriteLine("我是非静态方法");
        }
    }
    /// <summary>
    /// 构造方法测试
    /// </summary>
    class CtorMethod
    {
        public CtorMethod()
        {
            testCtorMethod();
        }
        public void  testCtorMethod()
        {
            Console.WriteLine("我在测试构造方法");
        }
    }
}
