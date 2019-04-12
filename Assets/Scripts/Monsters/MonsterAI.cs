using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject player;
    bool canAttack = true;
    public int delay = 100;
    public GameObject projectile;
    int increment;


    // Start is called before the first frame update

    void Start()
    {
       
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canAttack) {
            increment++;
            if (increment >= delay)
                canAttack = true;
        }
        Vector3 dest = GameObject.FindGameObjectWithTag("Player").transform.position;
        var dist = Vector3.Distance(this.transform.position, dest);
        if (dist < 10f) {
            //Vector3 dest = player.transform.position;
            //dest.y = this.transform.position.y;
            nav.SetDestination(dest);
            Debug.Log("player" + dest);
        }

        if (!nav.pathPending)
        {
            if (nav.remainingDistance < 1.5)
            {
                nav.Stop();
                if (canAttack)
                {
                    GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                    var heading = transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
                    var distance = heading.magnitude;
                    var direction = heading / distance;
                    bullet.GetComponent<Rigidbody>().AddForce(direction * -300);
                    canAttack = false;
                    increment = 0;
                }

            }
            else {
                nav.Resume();
            }
        }

    }
    private void FixedUpdate()
    {
        //Debug.Log(player.transform.position);
    }
}
