using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barTouch : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("none") && gameObject.activeSelf)
            {
                anim.Play("bars");
                //gameObject.SetActive(true);
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("bars") && gameObject.activeSelf)
            {
                anim.Play("none");
            }
        }

    }
}
