using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpItemManager : MonoBehaviour
{
    // PickUpItem�����܂�鐔���擾���邽�߂�PickUpItemSpawner���Q�Ƃ���
    public PickUpItemSpawner PickUpItemSpawner;

    // �v���C���[���擾�����A�C�e����
    // ( �u = 0 �v �ϐ��̏������@)
    // public int PlayerHp = 100 ; �ȂǂƎg�����Ƃ��ł��܂�
    public int PickUpItemCount = 0;

    // ���܂ꂽ��
    public int PickUpItemSpawnCount = 0;

    // �S�Ď擾�ł������̃t���O
    // ���̒i�K�ł́A�t���O���u�p�ӂ��Ă���v
    public bool GetAllPickUpItems = false;

    public GameState GameState;

    private void Start()
    {
        // PickUpItemSpawnCount��PickUpItem�����܂�鐔��������
        PickUpItemSpawnCount = PickUpItemSpawner.SpawnCount;
    }

    // ���t���[���u�������Ă��܂����v���m�F
    private void OnCollisionEnter(Collision collision)
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }

        // ������������̃^�O���uPickUpItem�v��������
        if (collision.gameObject.tag.Equals("PickUpItem"))
        {
            // PickUpItemCount�̒l���P���₷
            // �u++�v�C���N�������g
            // PickUpItemCount++; �Ɓ@PickUpItemCount +=1;�͓���
            // �܂�u1�����₵�Ăˁv�Ƃ����Ӗ��ɂȂ�܂��B
            PickUpItemCount++;
            // ���܂ꂽ����PickUpItemCount�����l�ɂȂ�����GetAllPickUpItems�̃t���O�𗧂Ă�
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

// �^�́Afloat �����_�̂���^�@�@int �����̂���^�@ bool �t���O�̊m�F�@�̂R�ŃQ�[�������������ł����Ⴄ
// ��r���Z�q�@==  <  >  <=  >=  != �i!�͔ے�̈Ӂj
