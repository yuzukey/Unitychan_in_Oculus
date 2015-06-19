using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class UnitychanDemo_in_Oculus : MonoBehaviour {

    private Animator animator;
    public bool IsSpace = true;
    private GameObject unitychan;
    private GameObject unitychanHead;
    private Vector3 unitychanEyeVector;
    private Vector3 cameraVector;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        

        Quaternion cameraRotation = InputTracking.GetLocalRotation(VRNode.CenterEye);
        unitychanHead = GameObject.FindWithTag("Unitychan_Head");
        Debug.Log(unitychanHead);
        Quaternion unitychanRotation = unitychanHead.transform.rotation;
        unitychanEyeVector = unitychanRotation * Vector3.forward;
        cameraVector = cameraRotation * Vector3.forward;

        if (Vector3.Dot(unitychanEyeVector, cameraVector) > -1.1 || Vector3.Dot(unitychanEyeVector, cameraVector) < -0.9)
        {
            animator.SetBool("gesture", true);
            IsSpace = true;
        }else{
            animator.SetBool("gesture", false);
            IsSpace = false;
        }
	}
}
