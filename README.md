# Test

## Test

### Test

#### Test

##### Test

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("가위바위보");

            while (input != 4)
            {
                Console.WriteLine("1.가위, 2.바위, 3.보, 4.종료");
                Console.Write($"input:");
                input = int.Parse(Console.ReadLine());
                if (input == 4)
                {
                    Console.WriteLine("종료");
                    break;
                }
                rsp(input);
                Console.WriteLine("1.계속, 2.종료");
                input = int.Parse(Console.ReadLine());
                if(input == 2)
                {
                    break;
                }
                Console.Clear();
            }
        }
        static void rsp(int a)
        {
            Random rand = new Random();
            int pc = rand.Next(1, 4);
            if (pc == 1)
            {
                Console.WriteLine($"pc:가위");
            }
            else if (pc == 2)
            {
                Console.WriteLine($"pc:바위");
            }
            else if (pc == 3)
            {
                Console.WriteLine($"pc:보");
            }
            //Console.WriteLine($"pc:{pc}");
            if (a == 1)
            {
                if (pc == 1)
                {
                    Console.WriteLine("비김");
                }
                else if (pc == 2)
                {
                    Console.WriteLine("짐");
                }
                else if (pc == 3)
                {
                    Console.WriteLine("이김");
                }
            }
            if (a == 2)
            {
                if (pc == 1)
                {
                    Console.WriteLine("비김");
                }
                else if (pc == 2)
                {
                    Console.WriteLine("짐");
                }
                else if (pc == 3)
                {
                    Console.WriteLine("이김");
                }
            }
            if (a == 3)
            {
                if (pc == 1)
                {
                    Console.WriteLine("비김");
                }
                else if (pc == 2)
                {
                    Console.WriteLine("짐");
                }
                else if (pc == 3)
                {
                    Console.WriteLine("이김");
                }
            }
        }
    }
}
```

[readme참고](https://ffoorreeuunn.tistory.com/226)

[ ]  사이에는 표시될 내용이,

( )  사이에는 링크로 들어갈 url 이 들어간다.

* 깃
    * 깃
        * 깃
            *깃   
* 뒤에는 공백이 있어야한다.
