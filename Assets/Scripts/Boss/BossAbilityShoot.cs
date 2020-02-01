//TOYE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAbilityShoot : BossAbility
{
    [SerializeField] private BossBullet prefabBossBullet;
    [SerializeField] private float shootCoolDown;
    private float lastShotTime;

    [SerializeField] private float shotdamage;
    [SerializeField] private float shotSpeed;

    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private Transform turretHeadRotatePoint;
    [SerializeField] private Transform turretHeadAimPoint;

    [SerializeField] private float rotateTurretSpeed;
    [SerializeField] private float pivotTurretSpeed;

    private float minShootingDistance;
    private float maxShootingDistance;

    public override void AbilitySetUp(Boss boss, MultiMovementV2 multiMovementV2)
    {
        base.AbilitySetUp(boss, multiMovementV2);
        this.boss = boss;
        lastShotTime = 0f;


    }

    public override void AbilityStart()
    {


    }

    // Update is called once per frame
    public override void AbilityUpdate()
    {
        MoveTowardsPlayer();
        AimAtPlayer();
        TryShoot();
    }

    public override void StopAbility()
    {

    }


    private void MoveTowardsPlayer()
    {
        //Move to a position where we can shoot the player
        float distToPlayer = Vector3.Distance(playerMovement.transform.position, boss.navAgent.destination);
        if (distToPlayer > maxShootingDistance)
        {
            //Move closer to player


        }
        else if (distToPlayer < minShootingDistance)
        {
            //Move away from player


        }
        else
        {

            Ray ray = new Ray(bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000f, boss.pillarLayer))
            {

            }
            else if (Physics.Raycast(ray, out hit, 1000f, boss.playerLayer))
            {
                //If we aiming at player with clean line of sight stay here
                boss.SetNavTarget(this.transform.position);
            }
            else
            {
                //Keep moving along as normal
            }
        }





    }

    private void TryShoot()
    {
        if (lastShotTime + shootCoolDown < Time.time)
        {
            lastShotTime = Time.time;
            BossBullet bullet = Instantiate(prefabBossBullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation, null);
            bullet.Fire(shotdamage, shotSpeed);
        }
    }


    private void AimAtPlayer()
    {

        //First part is rotating turret head to look at player on y axis
        Vector3 targetPosition = playerMovement.transform.position + (Vector3.Distance(this.transform.position, playerMovement.transform.position) * Time.deltaTime * shotSpeed * playerMovement.playerAccelaration); //No idea if this will work but should incorporate player accelleration?
        Vector3 lookPos = new Vector3(targetPosition.x, turretHeadRotatePoint.position.y, targetPosition.z);
        Vector3 lookDir = (lookPos - turretHeadRotatePoint.position).normalized;

        Quaternion look = Quaternion.LookRotation(lookDir, transform.up);
        turretHeadRotatePoint.rotation = Quaternion.Lerp(turretHeadRotatePoint.rotation, look, rotateTurretSpeed * Time.deltaTime);

        //second part is pivoting turret arm to look at player on z axis (up down)

        Vector3 pivotLookPos = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
        Vector3 pivotLookDir = (pivotLookPos - turretHeadAimPoint.position).normalized;
        Quaternion pivot = Quaternion.LookRotation(pivotLookDir, transform.right);

        float xClamp = Mathf.Clamp(pivot.eulerAngles.x, -30, 30);
        pivot = Quaternion.Euler(xClamp, 0, 0);

        turretHeadAimPoint.rotation = Quaternion.Lerp(turretHeadAimPoint.rotation, pivot, pivotTurretSpeed * Time.deltaTime);
    }

    float AngleBetweenPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.z - b.z, a.x - b.x) * Mathf.Rad2Deg;
    }
}