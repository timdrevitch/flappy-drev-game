using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject snowGenerator;
    public GameObject score;
    
    private void Start(){
        gameOverCanvas.SetActive(false);
        snowGenerator.SetActive(true);
        score.SetActive(true);
        Time.timeScale = 1;
    }
    
    public void GameOver(){
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void replay() {
        SceneManager.LoadScene(0);
    }
    
}
