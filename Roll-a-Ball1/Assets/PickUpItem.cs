using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    // SESoundManager��Unity��ŎQ�Ƃ���
    public SESoundManager SESoundManager;

    // ��]�̑��x��1�ɂ��܂�
    public float RollSpeed = 0.2f;

    private void Update()
    {
        // toransform�̂Ȃ���Rotate���g����
        // right�A���Ȃ킿(1,0,0)�ɉ񂵂Ă�������
        // �y�ύX������zup�A���Ȃ킿�i0,1,0�j�ɉ�]�����
        // Space.World ���Ȃ킿���E�n�̍��W�ł�
        // �y�⑫�zSpace.Self �Ȃ玩�����猩���Ƃ��̍��W�ɂł����
        this.gameObject.transform.Rotate(Vector3.up * RollSpeed, Space.World);    
    }

    // �Փ˔�����擾���܂� (�Փ˔���̎���OnCollisionEnter���g����)
    private void OnCollisionEnter(Collision collision)
    {
        // �����Փ˂��Ă����̂�Player��������
        if(collision.gameObject.tag.Equals("Player"))
        {
            //// PickUpItem�p��SE���Đ�����
            // SESoundManager.PlayPickUpItemSE();

            // �����������܂�
            Destroy(this.gameObject);
        }
    }
}