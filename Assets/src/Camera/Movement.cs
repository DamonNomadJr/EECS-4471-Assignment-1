using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool beta;
    bool rotate;
    bool position;
    // Start is called before the first frame update
    void Start()
    {
        beta = false;
        rotate = false;
        position = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!beta)
        {
            Transform t = gameObject.GetComponent<Transform>();
            float y = t.rotation.eulerAngles.y;
            float x = t.rotation.eulerAngles.x;
            float z = t.rotation.eulerAngles.z;
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.Rotate(new Vector​3(0.0f, -3.0f, 0.0f));
            }
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.Rotate(new Vector​3(0.0f, 3.0f, 0.0f));
            }
        }
        else if (beta)
        {
            if (rotate) { 
                if (Input.GetKey(KeyCode.A))
                {
                    gameObject.transform.Rotate(new Vector​3(0.0f, -3.0f, 0.0f));
                }
                if (Input.GetKey(KeyCode.D))
                {
                    gameObject.transform.Rotate(new Vector​3(0.0f, 3.0f, 0.0f));
                }
                if (Input.GetKey(KeyCode.S))
                {
                    gameObject.transform.Rotate(new Vector​3(3.0f, 0.0f, 0.0f));
                }
                if (Input.GetKey(KeyCode.W))
                {
                    gameObject.transform.Rotate(new Vector​3(-3.0f, 0.0f, 0.0f));
                }
            }
            if (position)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    gameObject.transform.Translate(new Vector3(-0.3f, 0.0f, 0f));
                }
                if (Input.GetKey(KeyCode.D))
                {
                    gameObject.transform.Translate(new Vector3(0.3f, 0.0f, 0f));
                }
                if (Input.GetKey(KeyCode.S))
                {
                    gameObject.transform.Translate(new Vector3(0f, 0.0f, -0.3f));
                }
                if (Input.GetKey(KeyCode.W))
                {
                    gameObject.transform.Translate(new Vector3(0f, 0.0f, 0.3f));
                }
                if (Input.GetKey(KeyCode.Q))
                {
                    gameObject.transform.Translate(new Vector3(0f, 0.3f, 0f));
                }
                if (Input.GetKey(KeyCode.E))
                {
                    gameObject.transform.Translate(new Vector3(0f, -0.3f, 0.0f));
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (beta) { 
                //Reset the position of camera
                transform.position = new Vector3(-2.380423f, 0.85f, 1.376393f);
                transform.rotation = Quaternion.Euler(0f, 72f, 0f);
            }
            beta = !beta;
            print("Engaging Beta Mode as " + beta);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            this.position = true;
            this.rotate = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.position = false;
            this.rotate = true;
        }
    }
}
