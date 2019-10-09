using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public static YouWin Instance;
    public GameObject container;
    public Button nextLevelButton;
    public Button dismissButton;

    private void OnEnable()
    {
        nextLevelButton.onClick.AddListener(HandleNextLevelPressed);
        dismissButton.onClick.AddListener(Hide);
    }

    private void OnDisable()
    {
        nextLevelButton.onClick.RemoveListener(HandleNextLevelPressed);
    }

    private void HandleNextLevelPressed()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    private void Awake()
    {
        Instance = this;
    }

    public void Show()
    {
        container.SetActive(true);
    }
    public void Hide()
    {
        container.SetActive(false);
    }
}
