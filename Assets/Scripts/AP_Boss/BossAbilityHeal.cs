//TOYE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAbilityHeal : BossAbility
{
    public override void AbilitySetUp(Boss boss, MultiMovementV2 multiMovementV2)
    {
        base.AbilitySetUp(boss, multiMovementV2);
        this.boss = boss;
    }

    public override void AbilityStart()
    {

    }

    // Update is called once per frame
    public override void AbilityUpdate()
    {

    }

    public override void StopAbility()
    {

    }
}
