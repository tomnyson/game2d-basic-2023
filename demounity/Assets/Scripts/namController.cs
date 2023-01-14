using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namController : MonoBehaviour
{
    public float speed = 0.5f;
    public bool isRight = true;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Time.deltaTime * speed, 0, 0);
        }
        else
        {
            transform.Translate(-Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            isRight = !isRight;
        }
       
    }
}
