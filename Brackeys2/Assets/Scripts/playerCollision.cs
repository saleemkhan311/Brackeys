using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovemet movement;
    

    void OnCollisionEnter(Collision collisionInfo )
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().endGame();

        }
    }
}
