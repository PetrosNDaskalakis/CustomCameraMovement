using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTriggerVolume : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam;

    BoxCollider box;

    private void Awake()
    {
        box = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Swithing camera to: " + cam.name);
            if (CameraSwitcher.activeCamera != cam) 
                CameraSwitcher.SwitchCamera(cam);
        }
    }

}
