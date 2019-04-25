using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTheFire : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "PlayerProjectile")
        {
            Destroy(gameObject);
        }
    }
}
