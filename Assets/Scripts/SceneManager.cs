using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level-1");
    }
}
