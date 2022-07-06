using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour
{
    public float timer, interval = 5f;
    public GameObject lightz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            for (int i = 0; i < 10; i++)
            {
                lightz.SetActive(false);
                Debug.Log("Apagar");
            }
            StartCoroutine(EsperarLuz(1f));
        }
        else
        {
            lightz.SetActive(true);
        }
    }

    IEnumerator EsperarLuz(float time)
    {
        yield return new WaitForSeconds(1f);
        timer = 0;
    }
}
