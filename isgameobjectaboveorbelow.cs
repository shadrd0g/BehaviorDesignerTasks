//by MDS
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
    [TaskCategory("Basic/GameObject")]
    [TaskDescription("Checks if a game object is above or below another using the threshold value. Returns success if true. Stores bool if is above. Stores the difference.")]
    public class isGameObjectAboveOrBelow : Action
    {
        public SharedGameObject firstObject;
        public SharedGameObject secondObject;
        public SharedFloat threshold;
        public SharedBool isAbove;
        public SharedFloat difference;

        public override TaskStatus OnUpdate()
        {
            float firstY = firstObject.Value.gameObject.transform.position.y;
            float secondY = secondObject.Value.gameObject.transform.position.y;

            float differenceRaw = firstY - secondY;
            difference.Value = Mathf.Abs(differenceRaw);

            if(difference.Value >= threshold.Value)
            {
                if(differenceRaw >= 1f)
                {

                    isAbove.Value = false;
                    return TaskStatus.Success;
                } 
                else
                {

                    isAbove.Value = true;
                    return TaskStatus.Success;
                }
                
                          
             
            } 
            else
            {
                return TaskStatus.Failure;
            }
           
        }

        public override void OnReset()
        {

            firstObject = null;
            secondObject = null;
            threshold = 2;
            isAbove = null;
            difference = null;
        }
    }
}
