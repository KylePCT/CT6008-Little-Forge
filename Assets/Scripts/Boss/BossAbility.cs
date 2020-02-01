//TOYE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BossAbility : MonoBehaviour
{
    protected Boss boss;
    protected MultiMovementV2 playerMovement;
    public virtual void AbilitySetUp(Boss boss, MultiMovementV2 multiMovementV2)
    {
        this.boss = boss;
        this.playerMovement = multiMovementV2;
    }

    public abstract void AbilityStart();

    // Update is called once per frame
    public abstract void AbilityUpdate();

    public abstract void StopAbility();

}
