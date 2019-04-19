using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastSlect : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
           Debug.Log("Mouse is down");

           RaycastHit hitInfo = new RaycastHit();
           bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
           if (hit)
           {
               Debug.Log("Hit " + hitInfo.transform.gameObject.name);
               if (hitInfo.transform.gameObject.tag == "Construction")
               {
                   Debug.Log ("It's working!");
               } else {
                   Debug.Log ("nopz");
               }
               obj = hitInfo.transform.gameObject;
           } else {
               Debug.Log("No hit");
           }
           Debug.Log("Mouse is down");
       }

        if (Input.GetKey(KeyCode.LeftShift)){
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
             obj.transform.Translate(new Vector3(-0.3f, 0.0f, 0f));
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
             obj.transform.Translate(new Vector3(0.3f, 0.0f, 0f));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
             obj.transform.Translate(new Vector3(0f, 0.0f, -0.3f));
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
             obj.transform.Translate(new Vector3(0f, 0.0f, 0.3f));
            }
            if (Input.GetKey(KeyCode.P))
            {
                obj.transform.position = new Vector3(0f, 5f, 0f);
                obj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.LeftAlt)){
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                obj.transform.Rotate(new Vector3(0.0f, -3.0f, 0.0f));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                obj.transform.Rotate(new Vector3(0.0f, 3.0f, 0.0f));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                obj.transform.Rotate(new Vector3(3.0f, 0.0f, 0.0f));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                obj.transform.Rotate(new Vector3(-3.0f, 0.0f, 0.0f));
            }
        }

        
    }

}
