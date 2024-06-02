using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scr : MonoBehaviour
    
{

    private int  score= 0;
    public Text scoreText;
    public GameObject over;
    

    public void addScore()
    {
        score++;
        scoreText.text = $"Score:{score}";
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        
        over.SetActive(true);
    }
}
