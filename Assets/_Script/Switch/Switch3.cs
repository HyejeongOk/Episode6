using NaughtyAttributes;
using UnityEngine;

// hp > 70 : Green
// hp > 40 : Yellow
// hp > 0 : Red
// hp <= 0 : 투명 (Transparent)

public class Switch3 : MonoBehaviour
{
    [Header("색깔")]
    [HorizontalLine(height:1, EColor.Red)]
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

    [Header("UI")]
    [HorizontalLine(height:1, EColor.Red)]
    public int hp;
    public int damage;
    public int heal;

    [Button]
    void ChangeColor() // 함수를 선언했다.
    {
        Color col;

        if(hp > 70)
        {
            col = color1;
        }

        else if(hp > 40)
        {
             col = color2;
        }

        else if (hp > 0)
        {
            col = color3;
        }

        else{
            col = color4;
        }

        //GetComponent<MeshRenderer>().material.color = col; 
        GetComponent<MeshRenderer>().material.SetColor("_Color", col);
        // hp : 0 ~ 100, _ Fade : 0.0f ~ 1.0f
        GetComponent<MeshRenderer>().material.SetFloat("_Fade", hp * 0.01f);
    }

    // 버튼 : Damage 함수 선언
    [Button]
    void Damage()
    {
        hp -= damage;

        //삼항(Ternary) 연산으로
        // 변수 = 조건? 참 : 거짓
        //hp = hp <= 0? hp = 0 : hp -= damage;

        // hp가 최소 0에서 멈추게 한다.
        // hp가 0이하입니까?

        if(hp <= 0)
        hp = 0;

       ChangeColor();
        Debug.Log($"{damage} 피해 입고, 남은 피는 {hp}");
    }

    // 버튼
    [Button]
    void Heal()
    {
        hp += heal;
        
        // hp가 100에서 멈추기
        if(hp > 100)
        hp = 100;

        ChangeColor();
        Debug.Log($"{heal} 피복, 남은 피는 {hp}");
        
    }

    [Button]
    void ColorSwitch()
    {
        Color col = hp switch
        {
            > 70 => color1,
            > 40 => color2,
            > 0 => color3,
            _ => color4
        };
        //GetComponent<MeshRenderer>().material.color = col;
    }
}
