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
    // 홀수만출력
    // Odd30to1()
    // 홀수의 갯수 출력

    [Button]
    void Odd30to1()
    {
        int count = 0;
        for(int a = 30; a > 0; a-- )
        {
            if(a % 2 == 1)
            {
                Debug.Log($"{a}");
                count++;
            }
            
        }
            Debug.Log($"총 홀수의 수는 {count}");
    }
}
