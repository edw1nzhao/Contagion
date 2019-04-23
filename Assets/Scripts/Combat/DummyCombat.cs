using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCombat : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals("FireballCollider") || collision.gameObject.Equals("Fireball(Clone)"))
        {
            Destroy(gameObject);
        }
    }
}
