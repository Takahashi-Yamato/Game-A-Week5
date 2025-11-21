using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float gameTime = 30f;
    private bool isPlaying = true;

    void Start()
    {
        gameTime = DifficultyManager.Instance.gameTime;
    }

    void Update()
    {
        if (!isPlaying) return;

        gameTime -= Time.deltaTime;

        if (gameTime <= 0f)
        {
            gameTime = 0f;
            EndGame();
        }

        if (Input.GetMouseButtonDown(0))
        {
            ScoreManager.Instance.CountClick();
        }
    }

    void EndGame()
    {
        isPlaying = false;

        // ターゲット生成停止
        TargetSpawner spawner = FindObjectOfType<TargetSpawner>();
        if (spawner != null) spawner.enabled = false;

        // リザルトシーンへ移動
        SceneManager.LoadScene("ResultScene");
    }

    public bool IsPlaying()
    {
        return isPlaying;
    }
}
