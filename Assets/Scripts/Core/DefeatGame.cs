using System.Collections;
using UnityEngine;

public class DefeatGame : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private GameObject[] _objectsOff;

    private void Start()
    {
        _game.GameStateChanged +=GameOver;
    }
    
    private void GameOver (GameStates gameState)
    {
        if (gameState == GameStates.Defeat)
        {
            StartCoroutine(ShowPanel());
        }
    }

    IEnumerator ShowPanel()
    {
        
        yield return new WaitForSecondsRealtime(0.3f);
        _defeatPanel.SetActive(true);
        foreach (GameObject objectOff in _objectsOff)
        {
            objectOff.SetActive(false);
        }
    }
}
