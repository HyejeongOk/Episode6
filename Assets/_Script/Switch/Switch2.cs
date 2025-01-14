using NaughtyAttributes;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public bool redsignal;
    public bool yellowsignal;
    public bool greensignal;
    [Foldout("신호등 오브젝트")]
    public GameObject red;
    [Foldout("신호등 오브젝트")]
    public GameObject yellow;
    [Foldout("신호등 오브젝트")]
    public GameObject green;

    [Button]
    void Red()
    {
        // 토글 : !반대로 스위치 ( True <=> False)
        // 임시 보관했다가 처리
        redsignal = !redsignal;
        red.SetActive(redsignal);
    }

    [Button]
    void Green()
    {
        greensignal = !greensignal;
        green.SetActive(greensignal);
    }

    [Button]
    void Yellow()
    {
        yellowsignal = !yellowsignal;
        yellow.SetActive(yellowsignal);
    }

    public int A = 0;
    [Button("신호등 켜기/끄기")]
    void Signal()
    {
        // 모두 켜진 경우
        // red.SetActive(true);
        // yellow.SetActive(true);
        // green.SetActive(true);

        // % 나머지 연산
        // A % 3 풀이 : A를 3으로 나눈 나머지
        // 7 % 3  몫 2 나머지는 1
        // 8 % 3  몫 2 나머지는 2
        // 9 % 3  몫 3 나머지는 0
        // 10 % 3 몫 3 나머지는 1
        // 11 % 3 몫 3 나머지는 2
        // 12 % 3 몫 4 나머지는 0
        // 13 % 3 몫 4 나머지는 1

        // ++ --
        // ++A  A++

        /*
        */

        int r = A++ % 3;

        if (r == 0)
        {
            //빨강만 켜진 경우 : 1
            red.SetActive(true);
            yellow.SetActive(false);
            green.SetActive(false);
        }

        else if (r == 1)
        {
            //노랑만 켜진 경우 : 2
            red.SetActive(false);
            yellow.SetActive(true);
            green.SetActive(false);
        }

        else
        {
            //초록만 켜진 경우 : 3
            red.SetActive(false);
            yellow.SetActive(false);
            green.SetActive(true);
        }
    }
}
