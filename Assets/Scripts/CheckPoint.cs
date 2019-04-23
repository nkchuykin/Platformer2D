using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class CheckPoint
{
    float x;
    float y;
    float z;

    public CheckPoint(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public CheckPoint(Vector3 loc)
    {
        x = loc.x;
        y = loc.y;
        z = loc.z;
    }

    public Vector3 GetLocation()
    {
        return new Vector3(x, y, z);
    }

}

