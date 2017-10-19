using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    float distance = 25.0f;
    public float power = 500;
    private Vector3 hitPos  ;
    private Vector3 hitObjectPos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

        if(Input.GetMouseButtonDown(0))
        {

            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;

            if (Physics.Raycast(rayOrigin,out hitinfo, distance))
            {
                Debug.Log("You are casting an ray");
                Debug.DrawLine(rayOrigin.direction,hitinfo.point);
                hitPos = hitinfo.point;
                hitObjectPos = hitinfo.transform.position;
             
            }

        }
      
	}


    void OnGUI()
    {
        //The world position of the ray's contact point->
       // GUI.Box(new Rect(5, 5, 200, 50), "Ray Hit Vector3 = " + hitPos);
        // The world position of the object the ray hits->
        GUI.Box(new Rect(605, 405, 200, 50), "Vector3 = " + hitObjectPos);
    }

}
