using UnityEngine;
using UnityEditor;

namespace EDT
{
    [CustomEditor(typeof(GTLauncher), false)]
    public class EditorLauncher : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GTLauncher manager = target as GTLauncher;

            EditorGUILayout.LabelField("当前场景名",   manager.CurrSceneName);
            EditorGUILayout.LabelField("当前游戏状态", manager.CurrCopyType.ToString());
            EditorGUILayout.LabelField("下一游戏状态", manager.NextCopyType.ToString());

            manager.UseGuide     = EditorGUILayout.Toggle("使用新手引导", manager.UseGuide);
            bool musicActive  = EditorGUILayout.Toggle("关闭音乐", manager.MusicDisable);
            if(manager.MusicDisable != musicActive)
            {
                manager.MusicDisable = musicActive;
            }
        }
    }
}