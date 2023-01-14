using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public void change_scence() {
        Debug.Log("change_scence");
         SceneManager.LoadScene("level1");
    }
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
