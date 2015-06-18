using UnityEngine;
using System.Collections;

public class UnitychanDemo_in_Oculus : MonoBehaviour {

    private Animator animator;
    public bool isSpace = true;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey("space")){
            animator.SetBool("gesture", true);
            isSpace = true;
        }else{
            animator.SetBool("gesture", false);
            isSpace = false;
        }
	}
}
