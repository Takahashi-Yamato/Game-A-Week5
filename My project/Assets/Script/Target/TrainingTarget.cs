using UnityEngine;

public class TrainingTarget : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    private void OnMouseDown()
    {
        // ˆê’UÁ‚·
        gameObject.SetActive(false);

        // 1•bŒã‚É•œŠˆ
        Invoke("Respawn", 1f);
    }

    void Respawn()
    {
        transform.position = startPos;
        gameObject.SetActive(true);
    }
}
