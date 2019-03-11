using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonDoor : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Dungeon");
    }
}
