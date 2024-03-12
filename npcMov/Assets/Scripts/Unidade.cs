using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unidade : MonoBehaviour
{
    [SerializeField] Transform target;
    
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        /*interromper SetDestination
        seguir para outro target*/
        /*Utilizar collision como trigger
        Oncollision enter
        Flag de colisao false, chegou no "posto" troca flag pra true
        Troca target*/
        /*possibilidade de colocar area de collision para iniciar timer
        e trocar sprite*/
    }
}
