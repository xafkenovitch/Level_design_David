using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Tooltip("List the names of all the scenes to load")]
    public string[] scenesToLoad;

    public void Start ()
    {
        foreach (string s in scenesToLoad)
        {
            SceneManager.LoadSceneAsync(s, LoadSceneMode.Additive);
        }

    }
}
