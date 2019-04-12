using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnContact : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            if(this.tag == "Health")
                other.GetComponent<PlayerHealth>().addHealth(100);
            if (this.tag == "Mana")
                other.GetComponent<PlayerMana>().addMana(100);
            if (this.tag == "EnemyProjectile")
                other.GetComponent<PlayerHealth>().addHealth(-5);

        }
    }
}
