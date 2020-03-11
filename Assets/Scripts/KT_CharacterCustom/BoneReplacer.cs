////////////////////////////////////////////////////////////
// File: BoneReplacer.cs
// Author: Morgan Henry James
// Date Created: 29-02-2020
// Brief: Replaces the bones with the correct ones.
//////////////////////////////////////////////////////////// 

using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Replaces the bones with the correct ones.
/// </summary>
public class BoneReplacer : MonoBehaviour
{
	#region Variables
	#region Private

	#endregion
	#region Public

	#endregion
	#endregion

	#region Methods
	#region Private
	/// <summary>
	/// Replaces the bones with the correct ones.
	/// </summary>
	private void Start()
	{
		SkinnedMeshRenderer myRenderer;
		Transform[] newBones;
		SkinnedMeshRenderer targetRenderer;
		Dictionary<string, Transform> boneMap = new Dictionary<string, Transform>();
		GameObject target = transform.parent.parent.parent.gameObject;

		targetRenderer = target.GetComponent<SkinnedMeshRenderer>();

		foreach (Transform _bone in targetRenderer.bones)
		{
			boneMap[_bone.gameObject.name] = _bone;
		}

		myRenderer = gameObject.GetComponent<SkinnedMeshRenderer>();
		newBones = new Transform[myRenderer.bones.Length];

		for (int i = 0; i < myRenderer.bones.Length; i++)
		{
			GameObject _bone = myRenderer.bones[i].gameObject;
			if (!boneMap.TryGetValue(_bone.name, out newBones[i]))
			{
				Debug.Log("Unable to map bone ~" + _bone.name + "~ to target skeleton!");
				break;
			}
		}

		myRenderer.bones = newBones;
		myRenderer.rootBone = targetRenderer.rootBone;
		#endregion
		#region Public

		#endregion
		#endregion
	}
}