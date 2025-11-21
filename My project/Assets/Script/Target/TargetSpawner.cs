using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval = 1.0f;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;

    private float timer = 0f;
    private GameTimer gameTimer;

    void Start()
    {
        // 難易度設定を反映
        var dif = DifficultyManager.Instance;
        spawnInterval = dif.spawnInterval;

        // ★ゲームタイマーを取得（これがないと止まらない）
        gameTimer = FindObjectOfType<GameTimer>();
    }

    void Update()
    {
        // 時間切れなら敵を出さない
        if (gameTimer != null && !gameTimer.IsPlaying())
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnTarget();
            timer = 0f;
        }
    }

    void SpawnTarget()
    {
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);

        Vector2 spawnPos = new Vector2(x, y);
        Instantiate(targetPrefab, spawnPos, Quaternion.identity);

        // ★ 出現した数カウント
       // ScoreManager.Instance.AddTargetCount();
    }

}
