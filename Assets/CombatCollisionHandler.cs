using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCollisionHandler : MonoBehaviour
{
    PlayerHealth pHealth;
    PlayerMana pMana;

    // Start is called before the first frame update
    void Start()
    {
        pHealth = GM.mgr_spells.player.GetComponent<PlayerHealth>();
        pMana = GM.mgr_spells.player.GetComponent<PlayerMana>();
    }

    // Update is called once per frame
    void Update()
    {
        // if GM.elementmanager lighton && hit --> hp gain
        // if GM.elementmanager darkon && hit --> attack * 1.20

    }

    void OnCollisionEnter (Collision col){
        if(GM.mgr_element.LightOn()){
            pHealth.addHealth(20);
        } else if(GM.mgr_element.DarkOn()){
            pMana.addMana(20);
        }
    }
}
