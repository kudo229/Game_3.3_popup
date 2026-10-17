using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        // Khi đối tượng có Tag là Player chạm vào tường
        if (other.CompareTag("Player"))
        {
            if (GameMenu != null)
            {
                GameMenu.enabled = true; // Bật Popup lên
            }
        }
    }
}