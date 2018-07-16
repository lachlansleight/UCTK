using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UCTK {

	public class BufferSetupWithDispatch : BufferSetup {

		public ComputeDispatcher Dispatcher;
		public int ThreadGroupsX;
		public int ThreadGroupsY;
		public int ThreadGroupsZ;

		protected override void CreateData() {
			Dispatcher.Dispatch(ThreadGroupsX, ThreadGroupsY, ThreadGroupsZ);
		}
	}
}