using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // �ǂ�������Player�̈ʒu
    public Transform TargetPlayer;

    // ���ʂ�\������GameResultViewer
    public GameResultViewer GameResultViewer;

    // Unity��AI�@�\
    private NavMeshAgent navMeshAgent;
 
    // �v���C���[�֐G�ꂽ���̃t���O�uTouch�v
    // ���̒i�K�ł́A�t���O���u�p�ӂ��Ă���v
    public bool Touch = false; public void Start()

    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // �ړ���̌���
        navMeshAgent.SetDestination(TargetPlayer.transform.position);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameResultViewer.ResultText.text = "Game Over";
            Touch = true;
        }
    }
}
