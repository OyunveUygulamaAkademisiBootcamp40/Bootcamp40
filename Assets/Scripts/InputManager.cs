
using UnityEngine;

public class InputManager
{
    private static float mouseFirstPositionX;
    private float difference;
    
    private void setOrigin()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            mouseFirstPositionX = Input.mousePosition.x;
            Debug.Log("input alindi");
        }
        else if (Input.GetMouseButton(0))
        {
            mouseFirstPositionX = Input.mousePosition.x;
        }
    }

    private float getDifferencefromNewPositiontoOldPosition()
    {
        if (mouseFirstPositionX != null && Input.GetMouseButton(0))
        {
            difference = mouseFirstPositionX - Input.mousePosition.x ;
            
            return difference;
        }

        return 0;
    }


}
