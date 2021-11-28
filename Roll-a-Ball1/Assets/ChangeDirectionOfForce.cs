using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionOfForce : MonoBehaviour
{
    public float JumpPower = 500f;

    private void OnCollisionEnter(Collision collision)
    {
      // Player������������
      if (collision.gameObject.tag.Equals("Player"))
      {
            // Player��RigitBody�ɑ΂��āAy���ɑ΂�500kg�̗͂�������
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
      }


    }
}
