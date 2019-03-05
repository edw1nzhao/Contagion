using UnityEngine;
using System.Collections;

public class SpellManager : MonoBehaviour {
    ArrayList currentCast;
    private bool combo = false;
    private bool canCast = false;
    private float timer;

    public GameObject player;
    public float castingTime = 10f;
    public float speed = 100f;
    public float second = 1f;

    private PlayerMana playerMana;

    // Use this for initialization
    void Start() {
        currentCast = new ArrayList();
        playerMana = player.GetComponent<PlayerMana>();
        GM.mgr_spells = this;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftShift)) {
            combo = true;
        } else {
            combo = false;
        }

        if (Input.GetKeyDown("l")) {
            playerMana.setManaSlider(castSpell(Elements.Dark, playerMana.getMana()));
            GM.mgr_element.DisplayElement(Elements.Dark);
        }

        if (Input.GetKeyDown("k")) {
            playerMana.setManaSlider(castSpell(Elements.Light, playerMana.getMana()));
            GM.mgr_element.DisplayElement(Elements.Light);
        }

        if (combo) {
            if (Input.GetKeyDown("p")) {

                playerMana.setManaSlider(castSpell(Elements.Fire, playerMana.getMana()));
            }
            if (Input.GetKeyDown("o")) {
                playerMana.setManaSlider(castSpell(Elements.Water, playerMana.getMana()));
            }
            if (Input.GetKeyDown("i")) {
                playerMana.setManaSlider(castSpell(Elements.Earth, playerMana.getMana()));
            }
        }


    }

    public int castSpell(Elements e, int currMana) {
        int cost = GM.mgr_element.getElementCost(e);

        if (e == Elements.Dark) {
            if (currMana < playerMana.currMaxMana) {
                currMana += cost;
                if (currMana > playerMana.currMaxMana) {
                    currMana = playerMana.currMaxMana;
                }
            } else {
                GM.mgr_element.DisplayElement(e);
            }
        } else if (e == Elements.Light) {
            if (currMana > 0) {
                currMana -= cost;
                if (currMana < 0) {
                    currMana = 0;
                }
            } else {
                GM.mgr_element.DisplayElement(e);
            }
        } else {
            if (currMana >= cost) {
                currMana -= cost;
                GM.mgr_element.DisplayElement(e);

            }
        }

        return currMana;
    }
}
