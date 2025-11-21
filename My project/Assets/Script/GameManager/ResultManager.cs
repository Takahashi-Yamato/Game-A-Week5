using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    public Text scoreText;
    public Text accuracyText;

    public Text resultText;

    void Start()
    {
        int score = ScoreManager.Instance.Score;
        int maxScore = DifficultyManager.Instance.GetMaxScore();
        float accuracy = ScoreManager.Instance.GetAccuracy();

        scoreText.text = "Score: " + score;
        accuracyText.text = "Accuracy: " + Mathf.RoundToInt(accuracy * 100) + "%";

        if (score >= 30)
        {
            resultText.text = "PERFECT!";
        }
        else if (accuracy >= 0.8f)
        {
            resultText.text = "GREAT!";
        }
        else
        {
            resultText.text = "GOOD!";
        }
    }


    public void Retry()
    {
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene("SampleScene");
    }

    public void GoTitle()
    {
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene("TitleScene");
    }
}
