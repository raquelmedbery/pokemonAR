using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTouch : MonoBehaviour
{


    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        //gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    { 

        for(int i=0; i<Input.touchCount; ++i)
         {
             if(Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("none") && gameObject.activeSelf)
             {
                 anim.Play("light");
                 //gameObject.SetActive(true);
             }
             else if(Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("light") && gameObject.activeSelf)
             {
                 anim.Play("none");
             }
        }
    }
}
