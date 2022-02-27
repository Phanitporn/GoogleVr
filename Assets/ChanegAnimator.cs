using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanegAnimator : MonoBehaviour
{
    // Start is called before the first frame update
   public void getAnimatorVar1(){
       this.GetComponent<Animator>().Play("Breakdance Uprock Var 1");
   }
   public void getAnimatorVar3(){
       this.GetComponent<Animator>().Play("Breakdance Freeze Var 3");
   }
}
