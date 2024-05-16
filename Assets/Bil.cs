using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bil : MonoBehaviour
{  // Hastigheten f�r bilens r�relse
    public float speed = 0.4f;
    // Referens till bilens "transform"
    public Transform transform;
    // Rotationens hastighet 
    public float rotationSpeed = 2f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // R�relse �t h�ger och lutning
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -60), rotationSpeed * Time.deltaTime);

        }
        // R�relse �t v�nster och lutning
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 60), rotationSpeed * Time.deltaTime);
        }

        //R�relse upp�t
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        // R�relse ned�t
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }

        // �tterst�llning av rotationen
        if (transform.rotation.z != 150)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 2f * Time.deltaTime);
        }

    }

}

