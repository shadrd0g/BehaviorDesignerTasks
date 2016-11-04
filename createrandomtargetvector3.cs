//by MDS
using UnityEngine;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
    [TaskCategory("Basic/SharedVariable")]
    [TaskDescription("Generates a random vector3 on the X and Y axis from an origin.")]
    public class CreateRandomTargetVector3 : Action
    {
        public SharedGameObject originGO;
        public SharedFloat randomHigh;
        public SharedFloat randomLow;
        public SharedVector3 randomTargetPosition;
        private SharedFloat rx;
        private SharedFloat rz;
        private SharedVector3 originPos;
    


        public override void OnAwake()
        {
            originPos = originGO.Value.gameObject.transform.position;

        }

        public override TaskStatus OnUpdate()
        {
            rx = Random.Range(randomLow.Value, randomHigh.Value);
            rz = Random.Range(randomLow.Value, randomHigh.Value);
           
            randomTargetPosition.Value = new Vector3(originPos.Value.x + rx.Value, originPos.Value.y, originPos.Value.z + rz.Value);





            return TaskStatus.Success;

        }

        public override void OnReset()
        {

            originGO = null;
            randomHigh = null;
            randomLow = null;
            randomTargetPosition = null;
            rx = null;
            rz = null;
            originPos = null;


        }
    }
}