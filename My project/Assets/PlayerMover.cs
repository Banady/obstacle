using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed=33f;
        float Xvalue=Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float Zvalue=Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(Xvalue * 33, 0, Zvalue * 33);
    }
}
