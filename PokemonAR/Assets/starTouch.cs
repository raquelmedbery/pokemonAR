using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starTouch : MonoBehaviour
{
    public GameObject bars;

    // Start is called before the first frame update
    void Start()
    {
        //lightning.SetActive(false);
        bars = GameObject.Find("shooting_bars");
        bars.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (!(bars.activeSelf))
        {
            print("Bars should NOT be appearing");
        }

        for (int i = 0; i < Input.touchCount; ++i)
        {

            if (Input.GetTouch(i).phase == TouchPhase.Began && !(bars.activeSelf))
            {

                bars.SetActive(true);
            }

        }

    }
}
