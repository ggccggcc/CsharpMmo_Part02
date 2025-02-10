using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_mmoPart2.Section02
{
    internal class S02_01_Array
    {

        #region 배열
        // 사용할 방 갯수를 고정해서 계약하고(절대 변경 불가)
        // 연속된 방으로 배정받아 사용
        // 장점 : 연속된 방
        // 단점 : 방을 추가, 축소 불가


        #region 동적배열
        // 사용할 방 갯수를 유동적으로 계약
        // 연속된 방으로 배정받아 사용
        // 장점 : 유동적인 계약(방 추가 예약으로 이사 횟수 최소화)
        // 단점 : 중간 삽입/삭제
        // 동적 배열 할당 정책
            // 실제 사용할 방보다 많이 여유분을 두고 예약(1.5~2배)
            // 이사 횟수를 최소화

        #endregion


        #region 연결리스트
        //연결리스트
        //연결되지 않은 방을 사용
        //장점 : 중간추가, 삭제 이점
        //단점 : N번째 방을 찾을 수 없음(Random Access 불가)
        #endregion

        public int[] _data = new int[25];
        public List<int> _data2 = new List<int>();
        public LinkedList<int> _data3 = new LinkedList<int>();


        public void Initialize()
        {

        }
    }
}
