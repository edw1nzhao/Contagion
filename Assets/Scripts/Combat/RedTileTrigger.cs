using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTileTrigger : MonoBehaviour
{
    static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WoodenBox")
        {
            Transform cube = transform.parent;
            cube.GetComponent<Renderer>().material.color = Color.green;

            count++;
            if (count == 4)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Dungeon Boss", UnityEngine.SceneManagement.LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "WoodenBox")
        {
            Transform cube = transform.parent;
            cube.GetComponent<Renderer>().material.color = Color.red;
            count--;
        }
    }
}
