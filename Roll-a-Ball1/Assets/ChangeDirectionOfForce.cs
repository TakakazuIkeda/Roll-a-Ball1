using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionOfForce : MonoBehaviour
{
    public float JumpPower = 500f;

    private void OnCollisionEnter(Collision collision)
    {
      // Playerが当たったら
      if (collision.gameObject.tag.Equals("Player"))
      {
            // PlayerのRigitBodyに対して、y軸に対し500kgの力を加える
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
      }


    }
}
