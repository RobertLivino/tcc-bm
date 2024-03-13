using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using System.Threading;

public class Unidade : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    bool agentStatus = false;
    
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
        

        if (agentStatus == false)
        {
            agent.SetDestination(target1.position);
        }
        else
        {
            agent.SetDestination(target2.position);
        }
        
        /*interromper SetDestination
        seguir para outro target*/
        /*Utilizar collision como trigger
        Oncollision enter
        Flag de colisao false, chegou no "posto" troca flag pra true
        Troca target*/
        /*possibilidade de colocar area de collision para iniciar timer
        e trocar sprite*/
    }

    private void OnTriggerEnter2D()
    {
        if (agentStatus == false)
        {
            agentStatus = true;
        }
        else
        {
            agentStatus = false;
        }
    }
}

