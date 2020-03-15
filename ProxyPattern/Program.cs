using System;

namespace ProxyPattern {
    class Program {
        static void Main(string[] args) {

            IExample instanceOfProxy = new AProxy();
            Console.WriteLine(instanceOfProxy.Go());

            IExample instanceOfProxy2 = new AProxy();
            Console.WriteLine(instanceOfProxy2.Go());

            IExample instanceOfProxy3 = new AProxy();
            Console.WriteLine(instanceOfProxy3.Go());
            Console.ReadKey();
        }
    }
    public class AProxy : IExample {
        private static string info = null;

        public AProxy() {
            if(info == null)
                info = new A().Go();
            else
                info = "Data coming from Proxy A";
        }


        public string Go() => info;
    }

    public sealed class A : IExample {
        public string Go() => "Data coming from A";
    }

    public interface IExample {
        string Go();
    }
}
