using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance;

    public float spawnInterval = 1f;  // èoåªä‘äu
    public float gameTime = 30f;      // êßå¿éûä‘
    public float targetScale = 1f;    // ìIÇÃëÂÇ´Ç≥î{ó¶
    public float lifeTime = 2f;  // é©ìÆÇ≈è¡Ç¶ÇÈÇ‹Ç≈ÇÃïbêî

    private void Awake()
    {
        // ÉVÅ[ÉìÇÇ‹ÇΩÇ¢Ç≈Ç‡è¡Ç≥Ç»Ç¢
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

    // ìÔà’ìxê›íË
    public void SetDifficulty(int mode)
    {
        switch (mode)
        {
            case 1:
                spawnInterval = 1.0f;
                gameTime = 31f;
                targetScale = 2f;
                lifeTime = 1f;
                break;

            case 2:
                spawnInterval = 0.8f;
                gameTime = 24.5f;
                targetScale = 2f;
                lifeTime = 0.8f;
                break;

            case 3:
                spawnInterval = 0.8f;
                gameTime = 24.5f;
                targetScale = 1.25f;
                lifeTime = 0.8f;
                break;

            case 4:
                spawnInterval = 0.6f;
                gameTime = 18.5f;
                targetScale = 1.25f;
                lifeTime = 0.6f;
                break;

            case 5:
                spawnInterval = 0.6f;
                gameTime = 18.5f;
                targetScale = 0.8f;
                lifeTime = 0.6f;
                break;
        }
    }
    public int GetMaxScore()
    {
        return Mathf.FloorToInt(gameTime / spawnInterval);
    }

}
