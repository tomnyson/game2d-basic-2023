using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public float jump = 10;
    public bool isRight = true;
    public bool isJump = true;
    public Animator playerAnm;

    void Start()
    {
        playerAnm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            playerAnm.SetBool("isRunning", true);
            transform.Translate(Time.deltaTime * speed, 0, 0);
            // lật hình bên phải, scale image
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerAnm.SetBool("isRunning", true);
            // kt trái phải của nhân vật
            isRight = false;
            //move -> x
            transform.Translate(-Time.deltaTime * speed, 0, 0);
            // lật hình bên phải, scale image
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isJump == true)
            {
                if (isRight == true)
                {
                    transform.Translate(0.1f, 1.5f, 0);
                    isJump = false;
                }
                else
                {
                    transform.Translate(-0.1f, 1.5f, 0);
                    isJump = false;
                }
            }
        }
        //stop moving
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("horizontal" + horizontal);
        if (horizontal == 0)
        {
            playerAnm.SetBool("isRunning", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("call OnCollisionEnter" + isJump);
        Debug.Log("collision.gameObject.tag" + collision.gameObject.tag);
        if (collision.gameObject.tag == "grass")
        {
            isJump = true;
        }
        if (collision.gameObject.tag == "attack")
        {
            Debug.Log("Kill Nam");
        }
        if (collision.gameObject.tag == "kill")
        {
            Debug.Log("Player");
        }
    }
}
