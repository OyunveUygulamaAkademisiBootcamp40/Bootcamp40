using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    private float mouseFirstPositionX;
    public float getInput()
    {
        setOrigin();
        return getDifferencefromNewPositiontoOldPosition();
    }

    private void setOrigin()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseFirstPositionX = Input.mousePosition.x;
        }
    }

    private float getDifferencefromNewPositiontoOldPosition()
    {
        if (mouseFirstPositionX != null && Input.GetMouseButton(0))
        {
            return Input.mousePosition.x - mouseFirstPositionX;
        }

        return 0;
    }


}
