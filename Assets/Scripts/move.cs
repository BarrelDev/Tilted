using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    public bool isGrounded = false;
    public GameObject lostText;
    public GameObject tutorial;
    Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 50)
        {
            tutorial.SetActive(false);
        }
        Jump();
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Death")
        {
            lostText.SetActive(true);
            tutorial.SetActive(false);
            Time.timeScale = 0.1f;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Reloading game");
                SceneManager.LoadScene("game");
            }
           
        }
    }
    public void Retry()
    {
        SceneManager.LoadScene("game");
    }

}
