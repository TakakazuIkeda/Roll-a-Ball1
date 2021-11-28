using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionOfForce : MonoBehaviour
{
    public float JumpPower = 500f;

    private void OnCollisionEnter(Collision collision)
    {
      // Player‚ª“–‚½‚Á‚½‚ç
      if (collision.gameObject.tag.Equals("Player"))
      {
            // Player‚ÌRigitBody‚É‘Î‚µ‚ÄAy²‚É‘Î‚µ500kg‚Ì—Í‚ğ‰Á‚¦‚é
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
      }


    }
}
