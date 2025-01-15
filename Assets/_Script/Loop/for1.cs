using NaughtyAttributes;
using UnityEngine;

// 반복문
// for
// foreach
// while
// do while

// 반복을 위한 조건
// 대량생산, 
public class for1 : MonoBehaviour
{
   // for ( 초기값; 종료조건; 증감)
   // { 
   //     반복 작업
   // }

   

   void Start()
   {
    int a;
    // for는 if의 확장
    // if를 지정한 수만큼 반복 작업한다.
    for(a = 1; a < 4; a++ )
    {
        //참일 때만 실행
        Debug.Log("실행");
    }
   }

    // 버튼 만든다
    // 멤버변수에 Count를 넣어서 , 지정한 수만큼 for문 출력
    [Header("반복작업")]
    [HorizontalLine(height:1, color:EColor.Green)]
    public int count;
    
    [Button]
    void For1()
    {
            // 초기값; 종료조건; 증감
        for(int a = 0; a<count; a+=2)
        {
            // for문 조건이 참일 경우만 실행
            // 거짓이 되면 탈출
            // 처음부터 거짓이면 패스
            Debug.Log($"실행{a}");
        }
    }

    [Button]
    void For10to1()
    {
        // 10부터 1까지 역순으로 출력하기
        for(int a = 10; a > 0; --a)
        {
            Debug.Log($"실행{a}");
        }
    }
}
