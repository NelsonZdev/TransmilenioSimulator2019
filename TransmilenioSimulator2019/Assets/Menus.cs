using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour
{
    public Animator menu;
    bool opened = false;
    
    public void Presion(){
        opened = !opened;

        if(opened){
            menu.SetBool("Panel_Compra_Open", true);
        }
        else{
            menu.SetBool("Panel_Compra_Open", false);
        }

    }

    public void allOut(){
        menu.SetBool("Panel_Compra_Open", false);
    }

}
