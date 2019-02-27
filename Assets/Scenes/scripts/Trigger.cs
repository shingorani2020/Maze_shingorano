using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
  //public varibales
  public string sendToName;
  public string call;
  public string key;
  public bool delete;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
      Debug.Log(Other.gameObject.name + "hit" + this.gameObject.name);
      GameObject.Find(sendtoName).SendMessage(call,key);
      if (delete)
      {
        Destrou(this.gameObject);
      }

    }
}
