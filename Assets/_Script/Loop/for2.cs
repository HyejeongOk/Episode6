using System.Security.Cryptography;
using NaughtyAttributes;
using UnityEditor.Rendering;
using UnityEngine;

public class for2 : MonoBehaviour
{
    // 1부터 10까지 더하기 매 루프마다 출력
    // 값이 누적이 된다.
    // 버튼 만든다.
    // Add1to10()
    
    [Button]
    
    void Add1to10()
    {
        int i = 0;
        for(int a = 1; a <= 10; a++)
        {
            i = i + a;
            Debug.Log(i);
        }
    }

    // 30부터 1까지 역순 출력
    // 홀수만 출력
    // 최종 홀수의 갯수 출력

    // Odd30to1()

    // break; // 루프를 멈춰라 => 루프 탈출해라
    // continue; // 루프를 지속해라 => 현재 루프 건너뛰어라

    // 10 이하까지 가면 탈출 하게

    [Button]
    void Odd30to1()
    {
        // 이 코드가 꼭 필요합니까?
        // 필터 할 부분 다 하고, 핵심 코드 작성

        int a;
        int cnt = 0;
        for( a = 30; a > 0; a-- )
        {
            /* 2로 나머지 연산 값이 1이면 홀수
                                   0이면 짝수
            if(a % 2 == 1) // 홀수인 경우
            {
                Debug.Log($"{a}");

                아래 4가지가 같은 표현이다.
                cnt = cnt + 1;
                cnt += 1; 
                cnt++;
                ++cnt;
            } */
           
            if((a % 2) != 1)
                continue;
            
           // 10 이하면 탈출
            if(a <= 10)
            {
                Debug.Log("탈출!");
                break;
            }
                

            Debug.Log($"{a}");
            cnt++;

            
        }
            Debug.Log($"홀수 갯수 : {cnt}");
    }

    // 구구단 n단 출력
    // 멤버변수 n을 입력받는다.
    // 해당 구구단을 출력한다.

    // Gugudan()
    // for문 완료시, while문

    // 1. 한번에 해결 X

    // 4 x 1 = 4
    // 4 x 2 = 8
    // 4 x 3 = 12
    // ...
    // 4 x 8 = 32

    // 4 x 9 = 36
    public int n;
    [Button]
    void GugudanFor()
    {
        int a;
        for(a = 1; a <= 9; a++)
        {
            Debug.Log($"{n} x {a} = {n*a}");
        }
    }

    [Button]
    void GugudanWhile()
    {
        // 1. 초기값
        // 2. 종료조건
        // 3. 증감

        int num = 1;
        while(num <= 9)
        {
            // 참일 경우만, 실행한다
            // 거짓이면, 패스 혹은 탈출한다
            Debug.Log($"{n} x {num} = {n*num}");
            num++;
        }
    }
}
