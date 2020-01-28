using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 5;
    AudioSource audioSource;
    [SerializeField] AudioClip audioWin;
 
    int score;
 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
         
        audioSource = GetComponent<AudioSource>();
    }

    public void AddPoint()
    {
        if (!audioSource.isPlaying){audioSource.Play();}
        if (score == maxScore){
            scoreText.text = "You won!";
            score++;
        }
        else{
        score++;
        }
        if (score != maxScore)
            scoreText.text = "Score: " + score;

        else {
            scoreText.text = "You won!";
            if(score < 6)
            audioSource.PlayOneShot(audioWin);
        
        }
    }
}