using System;
using System.Collections.Generic;

namespace Unity_CSharp_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // collection - 동적 데이터 타입
            // List, Dictionary, Stack, Queue

            //-------------------------------
            //List - List<타입>
            //-------------------------------
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

             
            // 0번째 인덱스부터 탐색하고, 첫번째로 인자와 같은 요소를 발견하면 삭제한다.
            // 삭제 성공시 true반환, 실패시 false반환
           
            int length = _list.Count;

            for(int i = 0;i<length;i++)
            {
                int tempNumber = _list[i];
                Console.WriteLine(tempNumber);
            }
            Console.WriteLine();

            foreach (int num in _list)  //foreach - collection안의 원소들에 접근
            {
                Console.WriteLine(num);
            }
            int cnt = 0;
            foreach(int a in _list)
            {
                if (a == 3)
                    cnt++;
            }

            //-------------------------------
            //Diction<키 타입, 변수 타입> 리스트 2개의 조합
            //-------------------------------

            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "물딜러");
            _dic.Add("마법사", "마딜러");
            _dic.Add("수호자", "워로드");

            _dic.ContainsKey("검사");  // 검사를 찾는다.

            _dic.Remove("검사"); //검사를 제거

            bool isExist = _dic.ContainsKey("검사");
            if (isExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사: {tmpValue}");

            }
            else
                Console.WriteLine("검사를 찾을 수 없습니다.");


            _dic.Add("검사", "물딜러");

            foreach (string sub in _dic.Keys)
            {
                string tmpValue = _dic[sub];
                Console.WriteLine($"{sub} : {tmpValue}");
            }

            foreach (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }
            foreach (KeyValuePair<string,string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey} : {tmpValue}");
            }

            Console.WriteLine();


            //-------------------------------
            //Stack : 가장 늦게 추가된 아이템을 먼저 뺀다 (List와 비슷하나 LIFO 체계이다)
            //-------------------------------

            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(20);

            Console.WriteLine(_stack.Peek()); // 가장 마지막에 있는 값을 반환

            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());

            Console.WriteLine();
            //-------------------------------
            //Queue : 가장먼저 추가된 아이템을 먼저 뺀다 (List와 비슷하나 FIFO 체계이다.)
            //-------------------------------

            Queue<int> _queue = new Queue<int>();

            _queue.Enqueue(10); // 10
            _queue.Enqueue(20); // 10 20 
            _queue.Enqueue(30); // 10 20 30


            Console.WriteLine(_queue.Peek()); // 가장 첫번째에 있는 값을 반환
            Console.WriteLine(_queue.Dequeue()); // 가장 첫번째에 있는 값을 제거하고 반환
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());





        }
    }
}
