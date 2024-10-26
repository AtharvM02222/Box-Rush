using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement moverment;

    private void OnCollisionEnter (Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle")
        {
            moverment.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
