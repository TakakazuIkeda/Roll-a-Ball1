using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeKeeper : MonoBehaviour
{
    // ���Ԃ�\������e�L�X�g
    public TextMeshProUGUI TimeText;
    
    // GameResult��\������N���X
    public GameResultViewer GameResultViewer;

    // ��������
    public float TimeLimit = 100f;

    // Gamestate���Q�Ƃ���
    public GameState GameState;

    private void Update()
    {
        Debug.Log(GameState);
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }



        // �������Ԃ�0����ŁA���A�܂����ׂĂ�PickUpItem���擾������Ă��Ȃ�������
        if (TimeLimit > 0 && !GameResultViewer.PlayerPickUpItemManager.GetAllPickUpItems)
        {
            // TimeLimit�𖈃t���[���A�t���[���ƃt���[���̍����ň����Ă���
            TimeLimit -= Time.deltaTime;
            // $"{�ϐ�}"�@�ϐ��𕶎���Ƃ��ĕ\������
            // TineText.text = (TimeLimit+1).ToString("f2")
            TimeText.text = $"{(int)TimeLimit + 1}";
        }

        //// Enemy��Player���ڐG������J�E���g���~�߂�
        //else if ()
        //{
        //    TimeText.text = $"{(int)TimeLimit + 1}";
        //}

        // �S�Ă�PickUpItem���擾�����ꂽ��A�J�E���g���~�߂�
        else if (GameResultViewer.PlayerPickUpItemManager.GetAllPickUpItems)
        {
            TimeText.text = $"{(int)TimeLimit + 1}";
        }



        // �������Ԃ��O��聫�ɂȂ�����Q�[���I�[�o�[
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
        }
    }
}
