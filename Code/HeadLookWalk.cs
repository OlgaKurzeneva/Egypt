using UnityEngine;
using System.Collections;
using CnControls;

public class HeadLookWalk : MonoBehaviour {
    public float velocity = 0.7f;
    public bool isWalking = false;
    private Clicker clicker = new Clicker();
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //ax = Input.GetAxis("Button_A");
        //if (ax == -0.1861143)
        //if (Input.GetAxis("mouse 0") != 0)
        //if (clicker.clicked())
        //if (Input.GetKeyDown("Button_A"))
        //if (CnInputManager.GetButton("Button_A"))
        //{
        //    //isWalking = !isWalking;
        //}
        if(CnInputManager.GetButton("Button_Y"))
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
        if (CnInputManager.GetButton("Button_A"))
        {
            controller.SimpleMove(Camera.main.transform.forward * -velocity);
        }
        if (CnInputManager.GetButton("Button_X"))
        {
            controller.SimpleMove(Camera.main.transform.right * -velocity);
        }
        if (CnInputManager.GetButton("Button_B"))
        {
            controller.SimpleMove(Camera.main.transform.right * velocity);
        }
    }
}
