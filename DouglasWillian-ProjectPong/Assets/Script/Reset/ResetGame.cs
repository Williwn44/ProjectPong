using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{

    /*private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }

    }*/
    public void ResetKeys()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}

