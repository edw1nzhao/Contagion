using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestSelect : MonoBehaviour
{

    private void OnMouseDown()
    {
        if(this.name == "PrizeA") {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setMax(150);
            Globals.PLAYER_START_HP = 150;
        }
        if(this.name == "PrizeB") {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setMax(150);
            Globals.PLAYER_START_MP = 150;
        }
        GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(1.7f,.77f,11.5f);
    }
}
