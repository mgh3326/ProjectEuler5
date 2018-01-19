using System;

namespace ProjectEuler5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num = 10;
            bool temp = false;
            while (temp==false)//되긴 되는데 이렇게 짜면 안될거같다.
            {
                num++;
                for (int i = 0; i < 20; i++)
                {
                    if (num % (i + 1) != 0)
                        break;
                    else
                    {
                        if (i == 19)
                        {
                            Console.Write(num);
                            temp = true;
                            break;
                        }
                        
                    }
                }
            }
        }
    }
}

//1 ~ 10 사이의 어떤 수로도 나누어 떨어지는 가장 작은 수는 2520입니다.

//그러면 1 ~ 20 사이의 어떤 수로도 나누어 떨어지는 가장 작은 수는 얼마입니까?

//역으로 생각을 해보자 10이 되면 1,2,5가 된다. 그리고 9가 되면 1,2,5 + 3,6이 된다. 그리고 8이 되면 1,2,3,5,6 + 4이 된다. 7이 되면 1,2,3,4,5,6,7,8,9,10이 다된다.
//그래서 10*9*8*7