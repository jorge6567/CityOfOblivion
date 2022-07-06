using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class romper : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject, 1);
        }
    }
}
