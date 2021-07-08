using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == player.name)
        {
            player.GetComponent<move>().moveSpeed += 1f;
            player.GetComponent<move>().isGrounded = true;
            FindObjectOfType<AudioManager>().Play("PowerUp");
            Destroy(gameObject);
        }
    }
}
