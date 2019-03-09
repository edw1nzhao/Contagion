﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDB : MonoBehaviour
{
    [System.Serializable]
    public class Spell
    {
        public string combination;
        public string spellName;
        public float attackDmg;
        public float mpUsage;

        public Spell(string comb, string name, float att, float mp){
            combination = comb;
            spellName = name;
            attackDmg = att;
            mpUsage = mp;
        }

    }

    Dictionary<string, Spell> spellDB = 
    new Dictionary<string, Spell>(){
        {"FFF", new Spell("FFF", "castFireBall", 30, 30)}
    };

    public Dictionary<string, Spell> getSpellDB(){
        return spellDB;
    }

    // Start is called before the first frame update
    void Start()
    {
        GM.db_spells = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}