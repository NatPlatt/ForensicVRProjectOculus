using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siliconeMold : MonoBehaviour
{
    private Animator myAnimator;
    private Animation myAnim;
    public string myAnimState;
   
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
        myAnim = gameObject.GetComponent<Animation>();
    }

    public void RunAnim()
    {
        myAnim[myAnimState].speed = 1;
    }

    public void StopAnim()
    {
        myAnim[myAnimState].speed = 0;
    }
}
