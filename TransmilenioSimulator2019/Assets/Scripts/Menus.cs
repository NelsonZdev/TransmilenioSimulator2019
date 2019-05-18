using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public Animator menu, mant;
    bool openedM = false, openedN = false;
    
    public void Presion1(){
        openedM = !openedM;

        if(openedM){
            menu.SetBool("Panel_Compra_Open", true);
            mant.SetBool("Panel_Mant_Open", false);
        }
        else{
            menu.SetBool("Panel_Compra_Open", false);
        }

    }
    
    public void Presion2(){
        openedN = !openedN;

        if(openedN){
            mant.SetBool("Panel_Mant_Open", true);
            menu.SetBool("Panel_Compra_Open", false);
        }
        else{
            mant.SetBool("Panel_Mant_Open", false);
        }

    }

    public void allOut(){
        menu.SetBool("Panel_Compra_Open", false);
        mant.SetBool("Panel_Mant_Open", false);
    }

}
