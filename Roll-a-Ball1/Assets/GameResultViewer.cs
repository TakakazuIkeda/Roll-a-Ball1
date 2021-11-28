using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    // PlayerPickUpItemManager����t���O���󂯎~�߂邽�߂�PlayePickUpItemManager���Q�Ƃ���
    public PlayerPickUpItemManager PlayerPickUpItemManager;
    public BGMSoundManager BGMSoundManager;

    // ���ʂ�\������TextMeshPro���Q�Ƃ���
    public TextMeshProUGUI ResultText;

    public GameState GameState;

    void Start()
    {
        // ���ʂ�\������TextMeshPro�̕�������ɂ���
        ResultText.text = string.Empty;
    }

    // ��x�����炷
    private bool PlayedGameClearBGM = false;

    // Update is called once per frame
    void Update()
    {
        // PlayerPickUpItemManager�̃t���O�����Ă�Game Clear��\������
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
