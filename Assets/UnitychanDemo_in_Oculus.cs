using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class UnitychanDemo_in_Oculus : MonoBehaviour {

    private Animator animator;
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
        Debug.Log(cameraRotation);
        unitychanHead = GameObject.FindWithTag("Unitychan_Head");
        Quaternion unitychanRotation = unitychanHead.transform.rotation;
        Debug.Log(unitychanRotation);
        unitychanEyeVector = unitychanRotation * Vector3.forward;
        cameraVector = cameraRotation * Vector3.forward;

        if (Vector3.Dot(unitychanEyeVector, cameraVector) > -1.05 && Vector3.Dot(unitychanEyeVector, cameraVector) < -0.95)
        {
            animator.SetBool("gesture", true);
        }else{
            animator.SetBool("gesture", false);
        }
	}
}
