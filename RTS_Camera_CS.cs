using UnityEngine;
using System.Collections;

public class RTS_Camera_CS : MonoBehaviour {

    bool intTopView;
    public int scrollArea = 100;
    public int scrollSpeed = 3;
    public int dragSpeed = 3;
    Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        float mPosX = Input.mousePosition.x;
        float mPosY = Input.mousePosition.y;


        //cam mov by mPos
        if (mPosX < scrollArea)
        {
            myTransform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime, Space.World);
        }

        if(mPosX >= Screen.width-scrollArea) 
        {
            myTransform.Translate(Vector3.right * scrollSpeed * Time.deltaTime, Space.World);
        }

        if(mPosY < scrollArea)
        {
            myTransform.Translate(Vector3.forward * -scrollSpeed * Time.deltaTime, Space.World);
        }

        if(mPosY >= Screen.height-scrollArea)
        {
            myTransform.Translate(Vector3.forward * scrollSpeed * Time.deltaTime, Space.World);
        }

        //cam mov by keyboard
        myTransform.Translate(new Vector3(Input.GetAxis("Horizontal") * scrollSpeed * Time.deltaTime,
            Input.GetAxis("Vertical") * scrollSpeed * Time.deltaTime, 0));

        //cam mov by holding down option or middle mouse and moving mouse
        if ((Input.GetKey("left alt") || Input.GetKey("right alt")) || Input.GetMouseButton(2))
        {
            myTransform.Translate(new Vector3(Input.GetAxis("Mouse X") * dragSpeed * -1, 0,
                Input.GetAxis("Mouse Y") * dragSpeed * -1), Space.World);
        }
        
        
        //zooming in & out camera
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //something like translating y-axis to +
        myTransform.Translate(Vector3.up * scrollSpeed);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            //and here is translating y-axis to -
        myTransform.Translate(Vector3.down * scrollSpeed);
        }
         //really no idea of what am I doing yet
         //but if it is proper, I'd fucking buy myself a drink
         */
	}
}
