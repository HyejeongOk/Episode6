using NaughtyAttributes;
using UnityEngine;

public class IFattribute : MonoBehaviour
{
    [Header("타이틀")]
    [HorizontalLine(height:1, color:EColor.Red)]
    [Space(5)]

    [BoxGroup("")]
    public int A;
    [BoxGroup("")]
    public int B;
    [BoxGroup("")]
    public int C;

    // D를 부울 타입으로
   
   [Header("타이틀2")]
   [HorizontalLine(height:1, color:EColor.Blue)]
   [Space(5)]
   [BoxGroup("")]
    public bool D; // True, False

    [Button]
    void OperatorEx()
    {
        // A = B; A에 B의 값을 대입 

        // A == B; 같으면 true나 false
        // A != B; 다르면 true 같으면 false
        // A += B; 풀어쓰면 A = A + B;
        // A -= B;
        // A *= B;
        // A /= B;
        // A %= B; 풀어쓰면 A = A % B; A를 B로 나눈 나머지 값

        // A++;  풀어쓰면 A = A + 1;  후행 연산
        // A--;  A = A - 1;

        // ++B;  풀어쓰면 B = 1 + B;  선행 연산
    }

    [Button]
    void DayofWeek()
    {
        // A 1 이면, 월요일
        // A 2 이면, 수요일
        // A 3 이면, 금요일
        // A 그 밖에 값, 일요일

        // if문 활용해서 로그 출력하기

        if (A == 1)
        {
            Debug.Log("월요일");
        }

        else if (A == 2)
        {
            Debug.Log("수요일");
        }

        else if (A == 3)
        {
            Debug.Log("금요일");
        }

        else{
            Debug.Log("일요일");
        }
    }

    [Button("삼항연산 (왼쪽, 오른쪽)")]
    void TernaryOperator1()
    {
        
        //        if ( 조건1 )
        //        {
        //          참
        //        }
        //        else if ( 조건2 )
        //        {
        //        }
        //        else
        //        {
        //          거짓
        //        }

        // (Ternay 연산) 결과 = 조건 ? 참 : 거짓;
        // D를 멤버 변수에 부울 타입으로 만든다
        // D가 참이면 왼쪽, 아니면 오른쪽

        string d = D ? "왼쪽" : "오른쪽";
        Debug.Log(d);
    }

    // A가 3 이상이고 A가 9미만, 또는 B가 5 초과이고 B가 10 이하
    // 참이면 "참", 거짓이면 "거짓" 
    [Button("삼항연산 (이고, 또는)")]
    void TernaryOperator2()
    {
        string result = (A >= 3 && A < 9) || (B > 5 && B <= 10) ? "참" : "거짓";
        Debug.Log(result);
    }

}
