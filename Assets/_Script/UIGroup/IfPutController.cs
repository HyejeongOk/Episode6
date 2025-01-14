using UnityEngine;
using TMPro;
using UnityEditor.Rendering;

public class IfPutController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI output;
    [SerializeField] private TMP_InputField input;

    void Start()
    {
        
    }

    void Update()
    {
        output.text = NumOnlyFilter(input.text);

        // 목적 : 문자는 패스, 숫자만 입력 후 전달
        // NumFilter


        // 문자 12345 출력하고 한글 나오면 숫자까지만 나오게하기
    }

    int _temp;

    // 입력 : 문자(string) -> 출력 : 숫자 (int)
    string NumFilter(string s)
    {
        //return $"{int.Parse(s)}";
        //return int.Parse(s).ToString();

        // 참 일 경우 실행
        if(int.TryParse(s, out int o))  //return이 bool과 int
        {
            return o.ToString();
        }

        // 거짓 ??
        else
        {
            return "";
        }
    }

    string NumOnlyFilter(string s)
    {
        if(int.TryParse(s, out int o))  //return이 bool과 int
        {
            _temp = o;
            return o.ToString();
        }

        else
        {
            return _temp.ToString();
        }
        
    }
}
