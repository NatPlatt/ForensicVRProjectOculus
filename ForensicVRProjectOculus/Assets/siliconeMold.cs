using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siliconeMold : MonoBehaviour
{
    private Animator myAnimator;

   
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    public void RunAnim()
    {
        myAnimator.SetBool("makeMold", true);
    }

    public void StopAnim()
    {
       // myAnimator.keepAnimatorControllerStateOnDisable.
    }
}
