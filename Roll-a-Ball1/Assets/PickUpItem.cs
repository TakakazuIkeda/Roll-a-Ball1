using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    // SESoundManagerをUnity上で参照する
    public SESoundManager SESoundManager;

    // 回転の速度を1にします
    public float RollSpeed = 0.2f;

    private void Update()
    {
        // toransformのなかのRotateを使うよ
        // right、すなわち(1,0,0)に回してください
        // 【変更したよ】up、すなわち（0,1,0）に回転するよ
        // Space.World すなわち世界系の座標です
        // 【補足】Space.Self なら自分から見たときの座標にできるよ
        this.gameObject.transform.Rotate(Vector3.up * RollSpeed, Space.World);    
    }

    // 衝突判定を取得します (衝突判定の時にOnCollisionEnterを使うよ)
    private void OnCollisionEnter(Collision collision)
    {
        // もし衝突してきたのがPlayerだったら
        if(collision.gameObject.tag.Equals("Player"))
        {
            //// PickUpItem用のSEを再生する
            // SESoundManager.PlayPickUpItemSE();

            // 自分を消します
            Destroy(this.gameObject);
        }
    }
}