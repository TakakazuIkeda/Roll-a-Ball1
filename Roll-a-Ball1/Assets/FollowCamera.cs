using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // FollowするTarget
    public GameObject followTarget;

    // Targetとなる位置との差
    public Vector3 OffSet;

    // UnityEngine の更新
    // 1.Awake 2.Start 3.Update 4.LateUpdte 3.4.3.4.3.4......
    // Playerの移動はUpdateで行っているので、位置を正確に把握するために「LateUpdate」で追従しょりを行いました。
    private void LateUpdate()
    {
        // 自分の位置にFollowするTargetとの位置との差をPositionに代入する
        transform.position = followTarget.transform.position + OffSet;
        // 自分の向きをFollowするTargetに向かせる
        transform.LookAt(followTarget.transform);
    }
}
