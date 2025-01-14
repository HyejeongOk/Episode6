using NaughtyAttributes;
using UnityEngine;

//switch ( 조건 )
//{

//  case 해당 조건 1: 
//           작업
//           break;

//  case 해당 조건 2: 
//           작업
//           break;

//  default 아닐경우 : 
//          break;
//}

public class Switch1 : MonoBehaviour
{
    public int a;

    [Button]
    void SwitchDayWeek()
    {
        // a가 1이면 월요일, 2이면 수요일, 3이면 금요일, 4이면 일요일, 그 외는 잘못입력
        switch (a) // 변수 자체를 삽입
        {
            case 1:
                Debug.Log("월요일");
                break;

            case 2:
                Debug.Log("수요일");
                break;

            case 3:
                Debug.Log("금요일");
                break;

            case 4:
                Debug.Log("일요일");
                break;

            default:
                Debug.Log("잘못입력");
                break;
        }
    }

    [Button("새로운 스위치")]
    void NewSwitch()
    {
        string r = a switch
        {
            1 => "월요일",
            2 => "수요일",
            3 => "금요일",
            4 => "일요일",
            _ => "잘못입력"
        };

        Debug.Log(r);
    }

    // 3,4,5 => 봄
    // 6,7,8 => 여름
    // 9,10,11 => 가을
    // 11,1,2 => 겨울

    //if else문
    //새로운 switch문

    public int season;

    [Button("If문계절")]
    void Ifseason1()
    {
        if (season >= 3 && season <= 5)
        {
            Debug.Log("봄");
        }

        else if (season >= 6 && season <= 8)
        {
            Debug.Log("여름");
        }

        else if (season >= 9 && season <= 11)
        {
            Debug.Log("가을");
        }

        else if ((season > 0 && season <= 2) || season == 12)
        {
            Debug.Log("겨울");
        }

        else
        {
            Debug.Log("잘못입력");
        }
    }

    [Button("Switch문 계절")]
    void SwitchSeason()
    {
        string result = season switch
        {
            // 1 => "겨울",
            // 2 => "겨울",
            // 3 => "봄",
            // 4 => "봄",
            // 5 => "봄",
            // 6 => "여름",
            // 7 => "여름",
            // 8 => "여름",
            // 9 => "가을",
            // 10 => "가을",
            // 11 => "가을",
            // 12 => "겨울",
            // _ => "잘못입력"

            <= 0 => "잘못입력",
            <= 2 => "겨울",
            <= 5 => "봄",
            <= 8 => "여름",
            <= 11 => "가을",
            12 => "겨울",
            _ => "잘못업력"
        };

        Debug.Log(result);
    }

}
