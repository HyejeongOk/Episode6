using NaughtyAttributes;
using UnityEngine;

public class random1 : MonoBehaviour
{
    public int seed;

    [Button]
   void RandomRange()
   {
        // 가로 (Horizontal) <-> 세로 (Vertical)
        // static (정적인) <-> dynamic(동적인)
        // static의 목적, 용도 : 유틸리티 (도구로 활용)

        // UnityEngine 제공 Random
        // .Net Framework 제공 Random

        //Random.InitState(seed);
        //Debug.Log($"랜덤(Int) = {Random.Range(1,10)}");
        //Debug.Log($"랜덤(Float) = {Random.Range(0.5f, 1.5f):F3}");
        //float x = Random.value; // 기본값을 단위 수치(0.0f~1.0f) 설정해서 출력
        //Debug.Log($"랜덤(Float) = {x}");

        //Random.insideUnitCircle //2D 용 랜덤 생성 (x -1.0f ~ 1.0f, y .. )
        //콘솔 출력
        Debug.Log($"랜덤: {Random.insideUnitSphere}");
        // Random.insideUnitSphere //3D 용랜덤 생성 ( x, y, z )

        // 랜덤 float 1개 출력 : value
        // 랜덤 float 2개 출력 : UnitCircle : Vector2
        // 랜덤 float 3개 출력 : UnitSpere : Vector3
        //                                  : Vector4 == color(r,g,b,a)
   }

    // 멤버 변수에 입력한 숫자가 안나오도록
    // 범위 1 ~ 10까지
   public int excludeNum;
   
   [Button("랜덤 1 ~ 10")]
   void RandomExclude()
   {
        // 1 포함, 11 불포함 => 1 ~ 10
        int result = Random.Range(1, 11);

        // excludeNum이 안나오도록
        if(result != excludeNum)
            Debug.Log($"랜덤 결과 = {result}");

        else
        {
            result = result + 1;
        }
   }

    // 5% 확률로 입력한 숫자가 나오도록 => 특정 아이템
    // 시도횟수 출력
    // 결론 : n번 시도 끝에, 입력한 숫자 출력 : ?% 확률

    // 예) 오크의 허름한 반바지  // 1/3
    //     간달프의 마법 지팡이 // 1/1000
    //     사우론의 절대반지   // 1/1000000

    public int TargetNum;
    public int trynum = 0;

    [Button]
   void RandomRate()
   {
        // float형 1개 ( 0.xxxx ~ 1.xxxx ) => 퍼센트
        float chance = Random.value;
        int result = Random.Range(1, 30);

        if((chance > 0.05) && (result != TargetNum))
        {
            Debug.Log($"{result}");
            trynum = trynum +1;
        }

        else
        {
            trynum = trynum +1;
            Debug.Log($"{trynum}시도 끝에 입력한 숫자 출력 : {TargetNum}");
        }
   }

  
}
