using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameOrTutorial : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Lab", LoadSceneMode.Single);
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Lab", LoadSceneMode.Single);
    }

}
