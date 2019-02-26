using UnityEngine;
using System.Collections;

public class SpellManager : MonoBehaviour {
    ArrayList currentCast;
    private bool combo = false;
    private bool canCast = true;
    private float timer;
    public float castingTime = 10f;
    public Rigidbody projectile;
    public float speed = 100f;
    public GameObject shootingRoot;
    //public Image light;

    // Use this for initialization
    void Start() {
        currentCast = new ArrayList();
    }

    // Update is called once per frame
    void Update() {

        
        if (Input.GetKeyDown("o")) {
            combo = true;
            GM.mgr_element.DisplayElement(Elements.Fire);
        }
        if (Input.GetKeyDown("k")) {
            combo = true;
            GM.mgr_element.DisplayElement(Elements.Light);
        }

        // if (Input.GetKeyDown("Fire1") && combo) {
        //     canCast = true;
        //     combo = false;
        //     GM.mgr_element.DisplayElement(Elements.Wind);
        // }


        if (Input.GetKeyDown("p") && canCast) {
            timer += Time.deltaTime;
            
            if (timer >= castingTime) {
                canCast = false;
                timer = 0.0f;
            }

            Rigidbody instantiatedProjectile = Instantiate(projectile, shootingRoot.transform.position, shootingRoot.transform.rotation) as Rigidbody;
            instantiatedProjectile.AddForce(shootingRoot.transform.forward * speed);
            //instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
        
    }
}
