using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItemSpawner : MonoBehaviour
{
    // 生成するPickUpItem
    public GameObject PickUpItem;
    // 生成する個数
    public int SpawnCount = 0;
    // 生成する円の半径
    // public float SpawnCircleRadius = 3f;
    // Start is called before the first frame update
    public List<Transform> SpawnPositions = new List<Transform>();

    // PickUpItemに渡すSESoundManager
    public SESoundManager SESoundManager;

    public float SpawnCircleRadius { get; private set; }

    private void Awake()
    {
        for (int i = 0; i < SpawnPositions.Count; i++)
        {
            GameObject Pick = Instantiate(PickUpItem);

            Pick.GetComponent<PickUpItem>().SESoundManager = SESoundManager;
                
            Pick.transform.position = SpawnPositions[i].position;
            SpawnCount++;
        }


        // 円周をSpawnCountで割った角度
        // 数学的な計算を用いてゲームの表現をしたいときはMathf Unityで検索するとだいたいできる
        float radian = Mathf.PI * 2 / SpawnCount;
        //  for(第一引数,第二引数)
        // 「iを0で定義して、0がSpawnCountになるまでiを増やしてください」
        for (int i = 0; i < SpawnCount; i++)
        {
            GameObject Pick = Instantiate(PickUpItem) ;
            // 新しくVector3を作成し、生成したPickUpItemのPositionを代入 
            Vector3 pos = Pick.transform.position;
            // Posのzの値に円周のyの値をSpawnCircleRadiusで掛けた値を代入
            pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
            // Posのxの値に円周のxの値をSpawnCircleRadiusで掛けた値を代入
            pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
            // 求められたVector3を生成されたPickのpositionに代入
            Pick.transform.position = pos;
        }
    }
}
