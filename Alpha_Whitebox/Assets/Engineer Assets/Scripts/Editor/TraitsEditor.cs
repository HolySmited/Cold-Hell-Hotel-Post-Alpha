using UnityEngine;
using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR 
using UnityEditor;
//      ObjectTraits
[CustomEditor(typeof(ObjectTraits))]
[CanEditMultipleObjects]
public class TraitsEditor : Editor
{
	SerializedProperty traits;
	void OnEnable() { traits = serializedObject.FindProperty("traits"); }
	
	Vector2 scrollBarPos = new Vector2();
	public override void OnInspectorGUI()
	{
		// Update the serializedProperty - always do this in the beginning of OnInspectorGUI.
		serializedObject.Update();
		
		//  Display Serialized Values
		for (int i = 0; i < ObjectTraits.TRAITS_SIZE; i++)
			traits.GetArrayElementAtIndex(i).boolValue = EditorGUILayout.ToggleLeft(ObjectTraits.traitNames[i], traits.GetArrayElementAtIndex(i).boolValue);

		// Apply changes to the serializedProperty - always do this in the end of OnInspectorGUI.
		serializedObject.ApplyModifiedProperties();
	}
}
#endif
