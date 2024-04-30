﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IEventParam
{  

}

public class OnDestroyEvent: IEventParam
{
    public Actor actor = null;
}

public class OnJumpEvent: IEventParam{}

public class OnLeftMoveEvent: IEventParam{}
public class OnUpEvent: IEventParam{}
public class OnRightMoveEvent: IEventParam{}

public class OnShiftEvent: IEventParam{}

public class OffLeftMoveEvent: IEventParam{}
public class OffRightMoveEvent: IEventParam{}
public class OffUpEvent: IEventParam{}

public class OnAttackEvent : IEventParam { }
public class OnSpinAttackEvent : IEventParam { }

public class OnItemKeyPressed : IEventParam
{
    public int num;
    public OnItemKeyPressed(int num) { this.num = num; }
}
public class OnGuardDamageEvent: IEventParam{}
public class OnHpChangeEvent: IEventParam
{
    public int hp = 0;
}

public class ItemAddedEvent: IEventParam
{
    public Item item;
    public ItemAddedEvent(Item item)
    {
        this.item = item;
    }
}