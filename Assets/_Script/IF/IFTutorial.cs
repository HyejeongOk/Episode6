using UnityEngine;


// if ( 참/거짓 ) { }
// Branch문

public class IFTutorial : MonoBehaviour
{
    public int A = 16;

    void Start()
    {
    //         &&                    ||
    // A 10  그리고  A 20            또는
    // A가 10 이상이고, 20 미만이면 참

    // A가 90이상이면 A학점
    // 80 이상고 90미만 B학점
    // 70 이상이면 C학점
    // 60 미만이면 F학점

    //참
    if (A >= 90)
    {
        // 참이면 실행, 거짓이면 패스
        Debug.Log("A학점");
    }
    //거짓

    else if(A >= 80 && A < 90)
    {
        Debug.Log("B학점");
    }

    else if(A >= 70 && A < 80)
    {
        Debug.Log("C학점");
    }

    else
    {
        Debug.Log("F학점");
    }
    }
    
}
