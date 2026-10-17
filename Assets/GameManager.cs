using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI References")]
    public Canvas GameMenu;
    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    private bool isShowingMenu = false;

    void Start()
    {
        // 1. Ẩn Canvas lúc bắt đầu
        if (GameMenu != null)
            GameMenu.enabled = isShowingMenu;

        // 2. Nạp nội dung động từ C#
        if (Title != null) Title.text = "Welcome to Unity!";
        if (Message != null) Message.text = "Do you want continue?";
        if (ContinueButton != null) ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        if (RestartButton != null) RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    // Nút Enter
    public void NextScene()
    {
        Debug.Log("Chuyển màn kế tiếp!");
        // SceneManager.LoadScene("_Scene_1");
    }

    // Nút Restart
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}