using UnityEngine;

public class HandMove : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.MovePosition(mousePos); // mueve la mano correctamente
    }
}
