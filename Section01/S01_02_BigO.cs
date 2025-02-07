using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_mmoPart2.Section01
{
    internal class S01_02_BigO
    {
        // 알고리즘의 효율을 측정하기 위한 방법으로 Big-O 표기법을 사용

        //두 알고리즘 A와 B를 비교하려면?
        // A가 B보다 조금 빨라요? => 애매모호
        // 프로그램을 짜서 실행 속도 비교 => 환경에 의존적
        // 입력이 적은 구간과 많은 구간에서 성능이 확연하게 차이가 날 경우는?

        // 1단계 : 대략적 계산
        // N+N = "1"
        // for문 한개 = "N+1"
        // 2중 for문 = "N^2 + 1"

        // 2단계 : 대장만 남긴다
        // O(1+N+4*N^2+1)
        // 0(4 * N^2)
        // O(N^2)
        // O는 Order Of 라고 읽는다



    }
}
