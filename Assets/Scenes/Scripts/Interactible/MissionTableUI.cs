using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTableUI : MonoBehaviour
{
    public GameObject missionUI;
    public GameObject CamHolder;
    public GameObject player;

    private PlayerCam cameraMovement;
    private PMovement playerMovement;

    void Start()
    {
        if (CamHolder != null)
        {
            cameraMovement = CamHolder.GetComponent<PlayerCam>();
        }
        else
        {
            Debug.LogError("CamHolder is not Assigned in MissionTableUI.cs");
        }

        if(player != null)
        {
            playerMovement = player.GetComponent<PMovement>();
        }
        else
        {
            Debug.LogError("Player is not assigned in MissionTableUI.cs");
        }
        
       
    }

    void OnMouseDown()
    {
        ToggleUI();
    }

    void ToggleUI()
    {
        bool isActive = !missionUI.activeSelf;
        missionUI.SetActive(isActive);

      

        if (isActive)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            cameraMovement.enabled = false;
            playerMovement.enabled = false;
            
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            cameraMovement.enabled = true;
            playerMovement.enabled = true;
           
        }
        
    }
   
}
