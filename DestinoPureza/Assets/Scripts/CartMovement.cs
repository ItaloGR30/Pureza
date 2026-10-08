using UnityEngine;

public class CartMovement : MonoBehaviour
{
    [Header("Movimento para frente")]
    [SerializeField] private float speed = 3f;

    [Header("Movimento para os lados")]
    [SerializeField] private float lateralSpeed = 5f;

    private void Update()
    {
        // Movimento automático para frente
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Movimento lateral usando teclado
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(
            Vector2.up * verticalInput * lateralSpeed * Time.deltaTime
        );
    }
}