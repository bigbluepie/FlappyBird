using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    [SerializeField] private ScoreCounter _scoreCounter;
    [SerializeField] private string _sceneToLoad;
    public const string PRE_AD_SCORE = "SavedPreAdScore";

    public void ShowAdvertisement()
    {
        
    }

    public void ContinuePlay()
    {
        PlayerPrefs.SetInt(PRE_AD_SCORE, _scoreCounter.CurrentScore);
        PlayerPrefs.Save();
        SceneManager.LoadScene(_sceneToLoad);
    }
}
