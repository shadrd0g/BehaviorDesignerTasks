using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
    [TaskCategory("Basic/GameObject")]
    [TaskDescription("Returns the distance between two Game Objects.")]
    public class gameObjectDistance : Action
    {
        public SharedGameObject firstObject;
        public SharedGameObject secondObject;
        
        public SharedFloat distance;
        

        public override TaskStatus OnUpdate()
        {
            Vector3 firstVector3 = firstObject.Value.gameObject.transform.position;
            Vector3 secondVector3 = secondObject.Value.gameObject.transform.position;

            distance.Value = Vector3.Distance(firstVector3, secondVector3);
            return TaskStatus.Success;
        }

        public override void OnReset()
        {

            firstObject = null;
            secondObject = null;
            distance = 0;
        }
    }
}
