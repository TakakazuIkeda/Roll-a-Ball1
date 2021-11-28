using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    // PlayerPickUpItemManagerからフラグを受け止めるためにPlayePickUpItemManagerを参照する
    public PlayerPickUpItemManager PlayerPickUpItemManager;
    public BGMSoundManager BGMSoundManager;

    // 結果を表示するTextMeshProを参照する
    public TextMeshProUGUI ResultText;

    public GameState GameState;

    void Start()
    {
        // 結果を表示するTextMeshProの文字を空にする
        ResultText.text = string.Empty;
    }

    // 一度だけ鳴らす
    private bool PlayedGameClearBGM = false;

    // Update is called once per frame
    void Update()
    {
        // PlayerPickUpItemManagerのフラグがたてばGame Clearを表示する
        if (PlayerPickUpItemManager.GetAllPickUpItems)
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            if (!PlayedGameClearBGM)
            {
                BGMSoundManager.PlayGameClearBGM();
                PlayedGameClearBGM = true;
            }
            ResultText.text = "Game Clear";
        }
    }
}
