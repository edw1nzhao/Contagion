using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCombat : MonoBehaviour
{
    public GameObject sign;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (!collision.gameObject.tag.Equals("Player") && !collision.gameObject.tag.Equals("Environment"))
        {
            Destroy(gameObject);
            if (gameObject.tag.Equals("Dummy"))
            {
                sign = GameObject.Find("Sign");
                Destroy(sign);
            }
        }
    }
}
