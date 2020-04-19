using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        player = gameObject.transform.parent.gameObject;
    } 

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            player.GetComponent<move>().isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "PowerUp")
        {
            player.GetComponent<move>().isGrounded = false;
        }
    }
}
