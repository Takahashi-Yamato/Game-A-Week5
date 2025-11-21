using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public int scoreValue = 1;   // 1クリックで加算するスコア
    public float lifeTime = 2f;  // 自動で消えるまでの秒数

    void Start()
    {
        float scale = DifficultyManager.Instance.targetScale;
        transform.localScale = new Vector3(scale, scale, 1);

        Destroy(gameObject, lifeTime); // ←自動消滅の処理
    }

    // マウスクリック時
    private void OnMouseDown()
    {
        //ScoreManager.Instance.CountClick();  // ← これが重要！


        // スコア加算
        ScoreManager.Instance.AddScore(scoreValue);

        // 自分を消す
        Destroy(gameObject);
    }
}
