using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject); // Cleanup if it goes off-screen
    }
}
