using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
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
