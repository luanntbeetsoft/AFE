﻿using UnityEngine;

namespace Com.Beetsoft.AFE
{
    public class Twist : ObjectElementSkillBehaviour
    {
        internal override void OnSpawn(Vector3 startPos, Vector3 direction)
        {
            movable.MoveToDir(startPos, direction);
        }

        internal override void SetIdIgnore(int value)
        {
            trigger.SetIdIgnore(value);
        }
    }
}