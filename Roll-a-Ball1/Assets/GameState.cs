using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // ゲームの進行度
    // Enumとは…列挙型　中身は文字列とint型の値を持つ。
    public enum GameProgressStates
    {
        GameStart = 0,
        GameMain  ,
        GameResult  
    }

    // 外から参照するためのGameProgressStatesの変数
    public GameProgressStates GameProgressState = GameProgressStates.GameStart;

    // Gameの進行度を変更するメソッド
    public void SetGameProgressState(GameProgressStates gameProgressState)
    {
        GameProgressState = gameProgressState;
    }
}
