using NaughtyAttributes;
using UnityEngine;

// 5% 확률로 입력한 숫자가 나오도록 => 특정 아이템
// 시도횟수 출력
// 결론 : n번 시도 끝에, 입력한 숫자 출력 : ?% 확률

// 예) 오크의 허름한 반바지  // 1/3
//     간달프의 마법 지팡이 // 1/1000
//     사우론의 절대반지   // 1/1000000

public class RandomGenerator : MonoBehaviour
{
    public int numerator; // 분자

    public int denominator; // 분모

    [ReadOnly] public float percent; // 분자 / 분모 * 100f

    [Button]
    void GenerateByRange()
    {
        float probabilty = (float)numerator / denominator;
        percent = probabilty * 100;

        // 랜덤발생 후, 성공실패 판단
        // (퍼센트 안에 들어오면 성공, 밖이면 실패)

        float rnd = Random.Range(0.0f, 100.0f);

        if (rnd < percent) // 성공영역
        {
            Debug.Log("성공");
        }

        else // 실패영역
        {
            Debug.Log("실패");
        }
    }


}