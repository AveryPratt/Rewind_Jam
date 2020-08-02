using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        if (!FindObjectOfType<PersistentManager>())
        {
            SceneManager.LoadScene(0);
        }
    }
}
