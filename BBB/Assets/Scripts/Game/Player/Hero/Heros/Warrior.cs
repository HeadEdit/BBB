using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : HeroBase
{
    void Start()
    {
        heroClass = HeroClass.Warrior;
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
