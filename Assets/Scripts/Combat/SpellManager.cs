using UnityEngine;
using System.Collections;

public class SpellManager : MonoBehaviour {
    ArrayList currentCast;
    
    // Use this for initialization
    void Start() {
        currentCast = new ArrayList();
    }

    // Update is called once per frame
    void Update() {
        /*
        if (Input.GetKeyDown("p")) {
            combo = true;
            GM.mgr_element.DisplayElement(Elements.Fire);
        }

        if (Input.GetKeyDown("o") && combo) {
            canCast = true;
            combo = false;
            GM.mgr_element.DisplayElement(Elements.Wind);
        }


        if (Input.GetButtonDown("Fire1") && canCast) {
            timer += Time.deltaTime;

            if (timer >= castingTime) {
                canCast = false;
                timer = 0.0f;
            }

            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
        */
    }
}
