using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeKeeper : MonoBehaviour
{
    // 時間を表示するテキスト
    public TextMeshProUGUI TimeText;
    
    // GameResultを表示するクラス
    public GameResultViewer GameResultViewer;

    // 制限時間
    public float TimeLimit = 100f;

    // Gamestateを参照する
    public GameState GameState;

    private void Update()
    {
        Debug.Log(GameState);
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }



        // 制限時間が0より上で、かつ、まだすべてのPickUpItemが取得しきれていなかったら
        if (TimeLimit > 0 && !GameResultViewer.PlayerPickUpItemManager.GetAllPickUpItems)
        {
            // TimeLimitを毎フレーム、フレームとフレームの差分で引いていく
            TimeLimit -= Time.deltaTime;
            // $"{変数}"　変数を文字列として表示する
            // TineText.text = (TimeLimit+1).ToString("f2")
            TimeText.text = $"{(int)TimeLimit + 1}";
        }

        //// EnemyとPlayerが接触したらカウントを止める
        //else if ()
        //{
        //    TimeText.text = $"{(int)TimeLimit + 1}";
        //}

        // 全てのPickUpItemが取得しきれたら、カウントを止める
        else if (GameResultViewer.PlayerPickUpItemManager.GetAllPickUpItems)
        {
            TimeText.text = $"{(int)TimeLimit + 1}";
        }



        // 制限時間が０より↓になったらゲームオーバー
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
        }
    }
}
