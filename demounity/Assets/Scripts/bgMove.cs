using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.2f;
    public float offset = 0;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
