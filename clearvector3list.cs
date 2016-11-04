using UnityEngine;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
    [TaskCategory("Basic/SharedVariable")]
    [TaskDescription("Clears a Vector3 List.")]
    public class ClearVector3List : Action
    {

        [RequiredField]
        [Tooltip("The SharedVector3List to clear")]
        public SharedVector3List storedVector3List;
      

        public override void OnAwake()
        {
          
        }

        public override TaskStatus OnUpdate()
        {



            storedVector3List.Value.Clear();


            return TaskStatus.Success;
        }

        public override void OnReset()
        {
          
            storedVector3List = null;
        }
    }
}