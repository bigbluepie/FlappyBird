using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    public void StartGame()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
