using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement movement;

    public AudioSource audioPlayer;
    public AudioSource audioPlayer2;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            audioPlayer.Play();
            audioPlayer2.Stop();
        }
    }
}
