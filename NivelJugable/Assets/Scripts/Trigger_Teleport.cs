
using UnityEngine;
public class Trigger_Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    //public AudioSource teleport;

    //public Camera cam;
    //public Transform cameraOrigin;

    void OnTriggerEnter(Collider collider)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        //teleport.Play();
        //cam.GetComponent<SFPSC_FPSCamera>().
        //cam.transform.LookAt(cameraOrigin);
        Debug.Log("Activado");
    }
}
