using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : HeroBase
{   
    void Start()
    {
        heroClass = HeroClass.Mage;
    }

    public override void MouseClick()
    {
        base.MouseClick();
    }

    public override void MouseDrag()
    {
        base.MouseDrag();
    }
}
