//by MDS
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	[TaskCategory("Basic/Vector3")]
	[TaskDescription("Creates a Flank right position. Returns failure if target is null.")]
	public class FlankRight : Action
	{
		public SharedGameObject target;
		public SharedVector3 thePosition;
        public SharedFloat distanceMultiplier;

		public override TaskStatus OnUpdate()
		{
            if (target.Value != null)
            {
                Transform autobots = target.Value.gameObject.transform;
                thePosition.Value = autobots.TransformPoint(Vector3.right * distanceMultiplier.Value);
                return TaskStatus.Success;
            } else
            {
                return TaskStatus.Failure;
            }
        }
        public override void OnReset()
        {
            target = null;
            thePosition = Vector3.zero;
            distanceMultiplier = 2;          
        }
    }
}