using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public void SelectDifficulty(int mode)
    {
        DifficultyManager.Instance.SetDifficulty(mode);
        SceneManager.LoadScene("SampleScene");
    }
    public void GoTraining()
    {
        SceneManager.LoadScene("TrainingScene");
    }

}
