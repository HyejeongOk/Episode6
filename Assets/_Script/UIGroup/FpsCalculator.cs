// 네임스페이스 영역
using UnityEngine;
using TMPro;


//클래스 영역 : 클래스의 부모 클래스
public class FpsCalculator : MonoBehaviour
{
    // 멤버 변수 영역
    [SerializeField] private string s;
    [SerializeField] private TextMeshProUGUI tmFps;

    //함수 영역

    //Start()는 MonoBehaviour에 미리 선언된 함수 : 1번만 실행
    void Start()
    {
           
    }

    float dt = 0.0f;

    void Update()
    {
        int fps;

        // FPS 구하는 공식
        dt += (Time.deltaTime - dt) * 0.1f;
        fps = (int)(1.0 / dt);

        // FPS는 80% 사이즈, 나머지는 그대로
        // <size = 80%> </size>
        tmFps.text = $"<size=80%> FPS </size> {fps}";
    }
}
