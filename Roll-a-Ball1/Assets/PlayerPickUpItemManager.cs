using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpItemManager : MonoBehaviour
{
    // PickUpItemが生まれる数を取得するためにPickUpItemSpawnerを参照する
    public PickUpItemSpawner PickUpItemSpawner;

    // プレイヤーが取得したアイテム数
    // ( 「 = 0 」 変数の初期化　)
    // public int PlayerHp = 100 ; などと使うこともできます
    public int PickUpItemCount = 0;

    // 生まれた数
    public int PickUpItemSpawnCount = 0;

    // 全て取得できたかのフラグ
    // この段階では、フラグを「用意している」
    public bool GetAllPickUpItems = false;

    public GameState GameState;

    private void Start()
    {
        // PickUpItemSpawnCountにPickUpItemが生まれる数を代入する
        PickUpItemSpawnCount = PickUpItemSpawner.SpawnCount;
    }

    // 毎フレーム「当たっていますか」を確認
    private void OnCollisionEnter(Collision collision)
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        // 当たった相手のタグが「PickUpItem」だったら
        if (collision.gameObject.tag.Equals("PickUpItem"))
        {
            // PickUpItemCountの値を１つ増やす
            // 「++」インクリメント
            // PickUpItemCount++; と　PickUpItemCount +=1;は同じ
            // つまり「1個ずつ増やしてね」という意味になります。
            PickUpItemCount++;
            // 生まれた数とPickUpItemCountが同値になったらGetAllPickUpItemsのフラグを立てる
            if (PickUpItemCount == PickUpItemSpawnCount)
            {
                GetAllPickUpItems = true;
                GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            }
        }

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
        }

    }
}

// 型は、float 小数点のある型　　int 整数のある型　 bool フラグの確認　の３つでゲームがけっこうできちゃう
// 比較演算子　==  <  >  <=  >=  != （!は否定の意）
