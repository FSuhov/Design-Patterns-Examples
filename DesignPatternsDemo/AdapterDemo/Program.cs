using System;

namespace AdapterDemo {
  /*
   Adapter используем когда:
   - в нашей программе требуется использовать класс, который не реализует нужный нам интерфейс;
   - мы создаем библиотеку, которая планируется к использования во многих, еще не написанных классах;
   Также адаптер называют оберктой (Wrapper).
  */
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
    }
  }
}
