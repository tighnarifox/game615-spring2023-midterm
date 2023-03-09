using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingscript : MonoBehaviour
{
      [SerializeField] float moveSpeed = 11f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }


     void Moving() 
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}