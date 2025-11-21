using UnityEngine;
using UnityEngine.UI;

public class TrainingManager : MonoBehaviour
{
    public GameObject escMenu;
    public Slider sensitivitySlider;

    private bool isMenuOpen = false;

    void Start()
    {
        escMenu.SetActive(false);
        sensitivitySlider.value = GameSettingsManager.Instance.mouseSensitivity;
        sensitivitySlider.onValueChanged.AddListener(OnSensitivityChanged);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        escMenu.SetActive(isMenuOpen);
    }

    void OnSensitivityChanged(float value)
    {
        GameSettingsManager.Instance.SetSensitivity(value);
    }
}
