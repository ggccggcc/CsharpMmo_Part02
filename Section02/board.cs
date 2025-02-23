using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_mmoPart2.Section02
{

    //class MyList<T>
    //{
    //    const int DEFAUT_SIZE = 1;
    //    T[] _data = new T[DEFAUT_SIZE];


    //    public int Count =0; // 사용중 데이터 개수
    //    public int Capacity { get { return _data.Length; } } //예약된 데이터 개수

    //    public void Add(T item)
    //    {
    //        //1. 공간이 충분히 남아있는지 확인한다

    //        if (Count >= Capacity)
    //        {
    //            //공간을 늘려서 다시 확보한다
    //            T[] newArray = new T[Count * 2];
    //            for (int i = 0; i<Count; i++)
    //                newArray[i] = _data[i];
    //            _data = newArray;

    //        }

    //        //2. 공간에다가 데이터를 넣어준다
    //        _data[Count] = item;
    //        Count++;

    //    }

        //public T this[int index]
        //{
        //    get { return _data[index]; }
        //    set { _data[index] = value; }
        //}

        //public void RemoveAt(int index)
        //{
        //    for (int i = index; i<Count -1; i++)
        //        _data[i] = _data[i+1];
        //    _data[Count - 1] = default(T);

        //    Count--;
        //}

    //}
    internal class board<T>
    {

        public class MyLinkedListNode<T>
        {
            public T Data;
            public MyLinkedListNode<T> Next;
            public MyLinkedListNode<T> Prev;
        }

        public class MyLinkedList<T>
        {
            public MyLinkedListNode<T> Head = null; // 처음
            public MyLinkedListNode<T> Tail = null; // 마지막
            public int Count = 0;

            public MyLinkedListNode<T> AddLast(T data)
            {
                MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
                newRoom.Data = data;

                //방이 없다면, 새 방이 곧 헤드이다
                if (Head == null)
                    Head = newRoom;

                // 마지막 방과 새로 추가되는 방을 연결
                if (Tail != null)
                {
                    Tail.Next = newRoom;
                    newRoom.Prev = Tail;
                }

                // 새로 추가된 방을 마지막 방으로 지정
                Tail = newRoom;
                Count++;
                return newRoom;

            }

            public void Remove(MyLinkedListNode<T> room)
            {
                //첫방 지우면 다음순서 애를 첫방으로 인정
                if(Head == room)
                    Head = Head.Next;

                //막방 지우면 직전 방을 막방으로 인정
                if(Tail == room)
                    Tail = Tail.Prev;
            
            
                if(room.Prev != null)
                    room.Prev.Next = room.Next;

                if (room.Next != null)
                    room.Next.Prev = room.Prev;

                Count--;
            }



        }

        
        public int[] _data = new int[25]; //배열
        //public MyList<int> _data2 = new MyList<int>(); //동적배열
        public MyLinkedList<int> _data3 = new MyLinkedList<int>(); //연결리스트

        public void initialize()
        {
            //_data2.Add(101);
            //_data2.Add(102);
            //_data2.Add(103);
            //_data2.Add(104);
            //_data2.Add(105);

            //int temp = _data[2]; //배열은 0부터시작하니까 [2]는 3번쨰라는 의미

            //_data2.RemoveAt(2);

            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);


        }


    }
}
