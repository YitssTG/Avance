using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCameraControl : MonoBehaviour
{
    public float minPosx;
    public float maxPosx;
    public CameraControl _cameraControl;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            _cameraControl.minXPosition = minPosx;
            _cameraControl.maxXPosition = maxPosx;
           
        }
    }
}
