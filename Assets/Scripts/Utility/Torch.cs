using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Player"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log("LOOOOL");
        }
    }
}
