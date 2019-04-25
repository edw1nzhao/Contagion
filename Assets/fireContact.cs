using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTriggerEnter(Collider other) { 
        if(other.tag == "PlayerProjectile") {
            Destroy(this.gameObject);
        }
    }
}
