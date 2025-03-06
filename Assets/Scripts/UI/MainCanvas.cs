using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainCanvas : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] private GameObject loadingScreen;
    [Header("Main Buttons")]
    [SerializeField] private Button playButton;
    [Header("HUD")]
    [SerializeField] private TextMeshProUGUI currentLevelLabel;
    [SerializeField] private Image levelProgressBar;

    private GameManager gm;

    private void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void Initialize()
    {
        gm = FindFirstObjectByType<GameManager>();
        playButton.gameObject.SetActive(true);
        SetLevelProgressBar(0f);
    }

    public void ShowLoadingScreen()
    {
        loadingScreen.SetActive(true);
    }

    public void HideLoadingScreen()
    {
        loadingScreen.SetActive(false);
    }

    public void OnPlayButtonClicked()
    {
        playButton.gameObject.SetActive(false);
        gm.Play();
    }

    public void OnSettingsButtonClicked()
    {

    }

    public void SetLevelText(int level)
    {
        currentLevelLabel.text = "Level" + level.ToString();
    }

    public void SetLevelProgressBar(float amount)
    {
        levelProgressBar.fillAmount = amount;
    }
}
