using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCollisionHandler : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if GM.elementmanager lighton && hit --> hp gain
        // if GM.elementmanager darkon && hit --> attack * 1.20

    }

    void OnCollisionEnter (Collision col){
        if(GM.mgr_element.LightOn()){
            GM.mgr_spells.getPlayerHealth().currHealth += 20;
            GM.mgr_spells.getPlayerHealth().setHealthSlider();
            Debug.Log("hit");
        } else if(GM.mgr_element.DarkOn()){

        }
    }

    
}
