using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : Item
{
    public virtual void Drink(){
      Debug.Log("driking");
    }
}
