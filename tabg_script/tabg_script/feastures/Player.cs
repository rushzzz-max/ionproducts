using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tabg_script.feastures
{
    class Player
	{
        / Token: 0x060003B1 RID: 945 RVA: 0x000160BC File Offset: 0x000142BC
	internal void LookAt(Vector3 position, bool ignoreY = false, float lerpSpeed = 0f)
		{
			Vector3 vector = position - this.m_head.transform.position;
			Vector3 vector2 = vector;
			vector2.y = 0f;
			if (ignoreY)
			{
				vector = vector2;
			}
			if (lerpSpeed != 0f)
			{
				this.xRot.rotation = Quaternion.Lerp(this.xRot.rotation, Quaternion.LookRotation(vector2), lerpSpeed);
				this.yRot.rotation = Quaternion.Lerp(this.yRot.rotation, Quaternion.LookRotation(vector), lerpSpeed);
				return;
			}
			this.xRot.rotation = Quaternion.LookRotation(vector2);
			this.yRot.rotation = Quaternion.LookRotation(vector);
		}




	}
}
