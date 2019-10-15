using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokeTouch : MonoBehaviour
{

    public GameObject lightning;

    // Start is called before the first frame update
    void Start()
    {
        //lightning.SetActive(false);
        lightning = GameObject.Find("poly_lightning");
        lightning.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (!(lightning.activeSelf))
        {
            print("Lightning should NOT be appearing");
        }

        for (int i = 0; i < Input.touchCount; ++i)
        {

            if (Input.GetTouch(i).phase == TouchPhase.Began && !(lightning.activeSelf))
            {

                lightning.SetActive(true);
            }

        }

        /*for (int i = 0; i < Input.touchCount; ++i)
        { 
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Instantiate(lightning, touchPos, Quaternion.identity);
            }
        }*/

    }
}
