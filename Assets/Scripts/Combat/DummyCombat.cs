using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCombat : MonoBehaviour
{
    public GameObject sign;
    public Transform explosionPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Player"))
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
