using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIN : MonoBehaviour
{
    public GameObject Canvas;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            Canvas.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
