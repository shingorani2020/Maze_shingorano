using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
  //ublic variables can be set in the inspector
  public GameObject startObj;
  public float movementSpeed = 1.0f; //mult. to adjust the movment rate
  //public GameObject Start = startObj;
  float mouseSensitivity = 1.0f;
  float rotUDrange = 45.0f; //range to look up and down

  //priavte Var
  private CharacterController cc ;
  private float forwardSpeed; // relative amount to move forward
  private Vector3 move; // the direction and magnitude of movment
  private float sideSpeed;  //relative amount to move sideways
  private float rotLR;
  private float rotUD;   // the current up/dwn orientation
  // public GameObject startgameobj = startObj




    // Start is called before the first frame update
    void Start()
    {
      //position the Camera node at the start location
      transform.position = startObj.transform.position;
      //gain access to the characterController Component
      cc = GetComponent<CharacterController>();
      rotUD = 0;
    }

    // Update is called once per frame
    void Update()
    {
      //rotation
      rotLR = Input.GetAxis("Mouse X") * mouseSensitivity;
      transform.Rotate(0, rotLR, 0); // rotate the CameraNode left and right
      rotUD -= Input.GetAxis("Mouse Y") * mouseSensitivity;
      rotUD = Mathf.Clamp(rotUD, -rotUDrange, rotUDrange);
    Camera.main.transform.localRotation = Quaternion.Euler(rotUD, 0, 0);
      //movement
      forwardSpeed = Input.GetAxis("Vertical") * movementSpeed; // how far to move forward or backwards
      sideSpeed = Input.GetAxis("Horizontal") * movementSpeed; //how far to move to the left or the right
      move = new Vector3(sideSpeed, 0, forwardSpeed);    // create a vector pointing in the direction of the desired movement
      move = transform.rotation * move;
      cc.SimpleMove(move);  // tell the character controller to move along the provided vector

    }
}
