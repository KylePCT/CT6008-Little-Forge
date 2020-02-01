//TOYE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public float health;
    public float runSpeed;
    public float turnSpeed;


    public NavMeshAgent navAgent;
    [SerializeField] private Animator animator;

    [SerializeField] private BossAbilityGoHome abilityGoHome;
    [SerializeField] private BossAbilityHeal abilityHeal;
    [SerializeField] private BossAbilityShoot abilityShoot;

    [SerializeField] private MultiMovementV2 playerMovement;

    public LayerMask pillarLayer;
    public LayerMask playerLayer;

    private enum BossState {
        Idle,
        GoHome,
        Heal,
        ShootAttack,
        MeleeAttack,
        Dead
    }

    private BossState currentState;

    
    // Start is called before the first frame update
    void Start()
    {

        if (playerMovement == null)
        {
            playerMovement = FindObjectOfType<MultiMovementV2>();
        }

        abilityGoHome.AbilitySetUp(this, playerMovement);
        abilityHeal.AbilitySetUp(this, playerMovement);
        abilityShoot.AbilitySetUp(this, playerMovement);

        ChooseAbility();
    }

    void ChooseAbility()
    {
        currentState = BossState.ShootAttack;
        abilityShoot.AbilityStart();
    }

    // Update is called once per frame
    void Update()
    {

        switch (currentState)
        {
            case BossState.Idle:

                break;
            case BossState.GoHome:
                abilityGoHome.AbilityUpdate();
                break;
            case BossState.Heal:
                abilityHeal.AbilityUpdate();
                break;
            case BossState.ShootAttack:
                abilityShoot.AbilityUpdate();
                break;
            default:
                break;
        }
    }

    public void TakeDamage(float ammount)
    {
        health -= ammount;
        CheckState();
    }

    private void CheckState()
    {

    }

    #region movement
    public void SetNavTarget(Vector3 vector3)
    {
        navAgent.enabled = true;
        navAgent.SetDestination(vector3);
    }


    private BoxCollider movemenCollider;
    private void MoveToRandomLocation()
    {
        navAgent.enabled = true;
        navAgent.SetDestination(new Vector3(Random.Range(movemenCollider.bounds.min.x, movemenCollider.bounds.max.x), 0f, Random.Range(movemenCollider.bounds.min.z, movemenCollider.bounds.max.z)));
    }



    #endregion

}
