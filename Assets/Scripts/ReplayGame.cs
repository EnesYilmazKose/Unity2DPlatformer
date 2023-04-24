using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayGame : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
