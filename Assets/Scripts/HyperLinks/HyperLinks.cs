using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLinks : MonoBehaviour
{
   public void openFacebook()
   {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100055079255728");
   }

   public void openInstagram()
   {
        Application.OpenURL("https://www.instagram.com/vijay_vj_dev/");
   } 

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/VijayvjOfficia1?s=09");
    }

}
