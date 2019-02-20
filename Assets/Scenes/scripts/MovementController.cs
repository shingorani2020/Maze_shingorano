using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
  //ublic variables can be set in the inspector
  public GameObject startObj;

  //priavte Var
  private CharacterController cc ;


    // Start is called before the first frame update
    void Start()
    {
      //position the Camera node at the start location
      transform.position = startObj.transform.position;
      cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
