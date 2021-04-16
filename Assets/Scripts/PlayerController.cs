using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float xBoundary = 15.0f;
    public bool GameOver = false;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (transform.position.x < -xBoundary)
            {
                transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xBoundary)
            {
                transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
            }
            horizontalInput = horizontalInput = Input.GetAxis("Horizontal");
        if (GameOver != true)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        }
        }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bad"))
        {
            playerAnim.SetTrigger("Trigger");
            GameOver = true;
        }
    }

}
