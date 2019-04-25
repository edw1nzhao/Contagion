using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropletCollide : MonoBehaviour
{
    public GameObject water;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Destroy(this.gameObject);
            water.transform.position += new Vector3(0, 50, 0);
        }
    }
}
