using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	/*
	// Update is called once per frame
	void Update () {

		 		
						if (Input.GetKey (KeyCode.A)) {


								transform.Rotate (Vector3.forward, 1, Space.World);		
		
		
						} else if (Input.GetKey (KeyCode.D)) {
							
								transform.Rotate (Vector3.back, 1, Space.World);
						} else if (Input.GetKey (KeyCode.W)) {
								
								transform.Rotate (Vector3.right, 1, Space.World);
							
				
		
						} else if (Input.GetKey (KeyCode.S)) {
							
								transform.Rotate (Vector3.left, 1, Space.World);		
		
						}

				
	}*/
	/**/
	  void Update () {
 
        float horRot = (Input.GetAxis("Horizontal")) * Time.deltaTime * -20;
        float vertRot = (Input.GetAxis("Vertical")) * Time.deltaTime * 20;
 
       float totalHorRot;
       float totalVertRot;
 
       if (transform.eulerAngles.x + horRot < 350) {
         totalHorRot = transform.eulerAngles.x + horRot;
       } else {
         totalHorRot = transform.eulerAngles.x + horRot - 360;
       }
 
       if (transform.eulerAngles.z + vertRot < 350) {
         totalVertRot = transform.eulerAngles.z + vertRot;
       } else {
         totalVertRot = transform.eulerAngles.z + vertRot - 360;
       }
 
        transform.rotation = Quaternion.Euler(Mathf.Clamp(totalHorRot, -5.5f, 5.5f), 0, Mathf.Clamp(totalVertRot, -5.5f, 5.5f));
    }
}
