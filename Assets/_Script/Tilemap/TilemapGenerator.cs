using NaughtyAttributes;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    [Header("하이트맵 소스")]
    [SerializeField] private Texture2D heightmap;
    [SerializeField] GameObject tilePrefab; // 지형 프리팹
    [SerializeField] GameObject treePrefab; // 나무 프리팹
 
    [Header("하이트맵 속성")]
    [MinValue(0f), MaxValue(50f)] 
    [SerializeField] float heightRange;
    [SerializeField] float treeoffset;

    [Button]
    void GetInfo()
    {
        // width, height를 콘솔에 출력한다.
        Debug.Log($"Width : {heightmap.width}");    // Horizontal
        Debug.Log($"Height : {heightmap.height}");   // Vertical

        // 루프문으로 w, h 크기 만큼 반복한다.
        // 반환값(Color)을 콘솔에 출력한다.

        for (int a = 0; a < heightmap.width; a++)
        {
            for (int b = 0; b < heightmap.height; b++)
            {
                Color col = heightmap.GetPixel(a, b);
                //Debug.Log($"컬러 r = {col}");
                Debug.Log($"컬러 g = {col.g}");
            }
        }
    }
    // col (r, g, b, a) 
    // r : 레벨을 디자인 (등고선 표현)
    // g : 나무 심기 (배경 프랍 배치)
    // b : 몹 배치 ( 적, 캐릭터 배치)
    // a : START, GOAL ( 시작점, 골인지점)

    // col.r이 0.5 기준으로 크면 (x,y,z) y를 1로 판단한다.
    // col.r이 0.5 기준으로 작으면 (x,y,z) y를 0로 판단한다.
    // Instantiate 함수를 활용해서 Cube 프리팹을 생성한다.

    // 가로 개수 : Horizontal Count
   
    [Button]
    void Buildmap()
    {
        // Width, Height 만큼 루프를 돌린다
        // GetPixel() col.r을 구한다
        // col.r을 기준으로 Instantiate할 때, y값을 설정 해준다.
        // Cube 월드를 만든다. (큐브, size Y 0.5f => 5.0f)

        GameObject Empty = new GameObject("TileGroup");

         for (int x = 0; x < heightmap.width; x++)
        {
            for (int z = 0; z < heightmap.height; z++)
            {
                Color col = heightmap.GetPixel(x, z);
                // col 범위 ( 최소  : 0.0f ~ 최대 : 1.0f)

                // RED 채널만 활용 : 등고선 표현
                //컬러의 r 채널을 높이 값으로 활용 * heightRange로 값을 증폭 (더 국명하게 보여주기 위해)
                float y = col.r * heightRange;

                
                GameObject contour = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity); 
                contour.transform.SetParent(Empty.transform);
                
                

                if( col.g != 0f)
                { 
                GameObject tree = Instantiate(treePrefab, new Vector3(x, y+treeoffset, z), Quaternion.identity);
               tree.transform.SetParent(Empty.transform);
                }
                //GREEN 채널만 활용 : 나무를 심는다
            }
        }
    }
}