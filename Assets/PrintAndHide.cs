using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int j;
    public Renderer rend;
    public GameObject red;
    public GameObject blue;

    // Start is called before the first frame update
    void Start()
    {
      red = GameObject.FindGameObjectWithTag("Red");
      blue = GameObject.FindGameObjectWithTag("Blue");

      j = Random.Range(200, 250);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        i++;

        if (red && i == 100)
        {
            red.SetActive(false);
        }

        if (blue && i == j)
        {
            blue.GetComponent<Renderer>().enabled = false;
        }

    }
}
