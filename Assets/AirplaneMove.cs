using UnityEngine;

public class AirplaneMove : MonoBehaviour
{
    public float speed = 5f; // Tốc độ bay của máy bay

    void Update()
    {
        // Tự động di chuyển tiến về phía trước theo trục Z
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}