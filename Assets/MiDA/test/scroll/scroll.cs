using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    [SerializeField]
    private Transform cameraGr;

    [SerializeField]
    private Transform charGr;

    [SerializeField]
    private GameObject VRcontroller_R;

    [SerializeField]
    private Vector3 speedvec = Vector3.right;

    [SerializeField]
    private Transform route;

    private Vector3 stage_dir;

    [SerializeField]
    private float speed_mul;

	// Use this for initialization
	void Start () {
        float angleDir = route.eulerAngles.z * (Mathf.PI / 180.0f);
        stage_dir = new Vector3(Mathf.Cos(angleDir), Mathf.Sin(angleDir), 0.0f);

        angleDir = route.eulerAngles.z * (Mathf.PI / 180.0f);
        speedvec = new Vector3(Mathf.Cos(angleDir), Mathf.Sin(angleDir), 0.0f);
        speedvec *= speed_mul;
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.Z))
        {
            cameraGr.position -= speedvec;
            charGr.position -= speedvec;
        }
        if (Input.GetKey(KeyCode.X))
        {
            cameraGr.position += speedvec;
            charGr.position += speedvec;
        }
    }
}
