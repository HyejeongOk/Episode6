using NaughtyAttributes;
using UnityEngine;

public class TileGanerator : MonoBehaviour
{
    [Foldout("프리팹")]
    public GameObject tilePrefab;

    public float x;
    //public float z;
    public int n;

    // 가로 개수 : Horizontal Count
    public int horzCnt;
    // 세로 개수 : Vertical Count
    public int vertCnt;
    // 층 개수 : floor Count
    public int floorCnt;
    // 타일과 타일 사이 거리
    public float gap;

    // int n개수
    // n만큼 x축으로 순차적으로 생성 되게

    [Button]
    void Build1()
    {
        // 인스턴스 ? 객체, 오브젝트
        // 클래스 틀(Template)에서 생성한 제품 중 하나

        // 1. n번 루프 돌린다.
        // 2. 간격 설정을 한다.

        // 3. 가로 X 세로 배치한다.
        // (옵션1) 2중 for문 활용할 수 있다
        // (옵션2) 단일 for문 카운트를 더 늘려서 할 수 있다 (줄바꿈)

        for (int a = 0; a < n; a++)
        {
            Instantiate(tilePrefab, new Vector3(a, 0f, 0f), Quaternion.identity);
        }

    }

    [Button]
    void Build2()
    {
        for (int a = 0; a < horzCnt; a++)
        {
            for (int b = 0; b < vertCnt; b++)
            {
                Instantiate(tilePrefab, new Vector3(a, 0f, b), Quaternion.identity);
            }
        }
    }

    // 0,0 => gap : 2 => 0 , 0
    // 1,0 => gap : 2 => 2 , 0
    // 2,0 => gap : 2 => 4 , 0
    // 3,0 => gap : 2 => 6 , 0
    // 4,0 => gap : 2 => 8 , 0

    // 0,0 => +2 => 2 , 0
    // 1,0 => +2 => 3 , 0
    // 2,0 => +2 => 4 , 0
    // 3,0 => +2 => 5 , 0
    // 4,0 => +2 => 6 , 0

    // 1,0 => x2 => 2 , 0
    // 2,0 => x2 => 4 , 0
    // 3,0 => x2 => 6 , 0
    // 4,0 => x2 => 8 , 0

    // 결과 => x * gap , y * gap, z * gap

    [Button]
    void Build3()
    {
        GameObject Empty = new GameObject("Group");

        for (int a = 0; a < horzCnt; a++)
        {
            for (int b = 0; b < floorCnt; b++)
            {
                for (int c = 0; c < vertCnt; c++)
                {
                    GameObject o = Instantiate(tilePrefab, new Vector3(a*gap, b*gap, c*gap), Quaternion.identity); 
                    o.transform.SetParent(Empty.transform);
                }
            }
        }
    }

    [Button]
    void Build4()
    {
        GameObject Empty = new GameObject("Group");

        for (int a = 0; a < horzCnt; a++)
        {
            for (int b = 0; b < floorCnt; b++)
            {
                for (int c = 0; c < vertCnt; c++)
                {
                    GameObject o = Instantiate(tilePrefab, new Vector3(a*gap, b*gap, c*gap), Quaternion.identity); 
                    o.transform.SetParent(Empty.transform);
                }
            }
        }
    }
}
