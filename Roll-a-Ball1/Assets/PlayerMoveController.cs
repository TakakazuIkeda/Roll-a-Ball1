using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    // プレイヤーのRigitbody
    private Rigidbody playerRigidbody;
    // 【練習問題】float型の変数Speedをpublicで定義する
    public float Speed = 1f;

    // GameStateを参照する
    public GameState GameState;

    // GameResultViewerを参照する
    public GameResultViewer GameResultViewer;
       
    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーのRigitBodyをアタッチしたGameObjectから取得します
        playerRigidbody = GetComponent<Rigidbody>();
        // 【練習問題】void Start の中でSpeedに2fを代入する
        // fは浮動小数点（整数以外の実数）型を示すため末尾に付している　
        // 例えば2.5だとドットと小数点の区別がつかずエラーになる　だから2.5f と入力する Speed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        // 一定の高さより下になったらゲームオーバー
        if (this.transform.position.y < -1)
        {
            GameState.SetGameProgressState( GameState.GameProgressStates.GameResult);
            GameResultViewer.ResultText.text = "Game Over";
            return;
        }


        // vector3型の変数moveに（左右キー,0,上下キー）の値を代入します
        var move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        // playerRigidbodyにmove向きの力を加えます
        // 【練習問題】moveにSpeedを掛ける（演算子 * ）
        playerRigidbody.AddForce(move * Speed);
    }
}
