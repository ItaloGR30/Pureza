using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StageFailure stageFailure = FindFirstObjectByType<StageFailure>();

            if (stageFailure != null)
            {
                stageFailure.FailStage();
            }
        }
    }
}