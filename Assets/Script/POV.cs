using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV : MonoBehaviour
{
    public Transform position_of_player;
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    public int i;

    void Start()
    {
        ShowOverheadView();
        transform.Translate(position_of_player.position); 
        i=1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if(i==0){
                ShowOverheadView();
                i=1;
            } else {
                ShowFirstPersonView();
                i=0;
            }
            
        }
               
    }

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
