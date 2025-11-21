using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int Score { get; private set; } = 0;

    public int totalClicks = 0;   // 全クリック数
    public int hitTargets = 0;    // 当てた数（スコアと同じ）

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ---------- 命中率用処理 ----------
    public void CountClick()
    {
        totalClicks++;
    }

    public float GetAccuracy()
    {
        if (totalClicks == 0) return 0f;
        return (float)hitTargets / totalClicks;
    }

    // ---------- スコア ----------
    public void AddScore(int amount)
    {
        Score += amount;
        hitTargets++;  // 当たった回数
    }

    public void ResetScore()
    {
        Score = 0;
        hitTargets = 0;
        totalClicks = 0;
    }
}
