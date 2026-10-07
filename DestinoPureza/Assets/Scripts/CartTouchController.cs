using UnityEngine;
using UnityEngine.EventSystems;

public class CartTouchController : MonoBehaviour
{
    [SerializeField] private float lateralSpeed = 5f;

    private bool movingUp = false;
    private bool movingDown = false;

    public void MoveUp()
    {
        movingUp = true;
        movingDown = false;
    }

    public void MoveDown()
    {
        movingDown = true;
        movingUp = false;
    }

    public void StopMoving()
    {
        movingUp = false;
        movingDown = false;
    }

    private void Update()
    {
        float direction = 0f;

        if (movingUp)
            direction = 1f;
        else if (movingDown)
            direction = -1f;

        transform.Translate(
            Vector2.up * direction * lateralSpeed * Time.deltaTime
        );
    }
}