using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Follow����Target
    public GameObject followTarget;

    // Target�ƂȂ�ʒu�Ƃ̍�
    public Vector3 OffSet;

    // UnityEngine �̍X�V
    // 1.Awake 2.Start 3.Update 4.LateUpdte 3.4.3.4.3.4......
    // Player�̈ړ���Update�ōs���Ă���̂ŁA�ʒu�𐳊m�ɔc�����邽�߂ɁuLateUpdate�v�ŒǏ]�������s���܂����B
    private void LateUpdate()
    {
        // �����̈ʒu��Follow����Target�Ƃ̈ʒu�Ƃ̍���Position�ɑ������
        transform.position = followTarget.transform.position + OffSet;
        // �����̌�����Follow����Target�Ɍ�������
        transform.LookAt(followTarget.transform);
    }
}
