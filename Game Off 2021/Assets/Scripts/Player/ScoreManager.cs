using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    //get food score, credits to Coco code's for the yt tutorial
    public static ScoreManager instance; 

    public Text scoreText;
    public Text objectiveScoreText;

    public int score = 0;
    public int objectiveScore = 30;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Food scraps";
        objectiveScoreText.text = "Objective: " + objectiveScore.ToString() + " Food scraps";
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString() + " Food scraps";
    }

    public GameObject Player;
    public Animator transitions;
    private void Update()
    {
        if (score == objectiveScore)
        {
            Player.SetActive(false);
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transitions.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }

}
