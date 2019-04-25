using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFull : MonoBehaviour
{
    private float level;
    bool full = false;
    // Start is called before the first frame update
    void Start()
    {
        level = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if((this.transform.position.y >= (level + (0.3f * 8)-.1f)) && !full) {
            //move to level 3
            Debug.Log("full");
            full = true;
        }
    }
}
