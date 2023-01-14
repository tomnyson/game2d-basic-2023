using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator ani;
    public Text score;
    public bool isRight = true;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = false;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isRight == true)
            {
                transform.Translate(Time.deltaTime * 5, Time.deltaTime * 20, 0);
            }
            else
            {
                transform.Translate(-Time.deltaTime * 5, Time.deltaTime * 20, 0);
            }

        }


    }
}
