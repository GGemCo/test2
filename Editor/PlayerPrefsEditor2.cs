using UnityEditor;

namespace Editor
{
    public class PlayerPrefsEditor2 : EditorWindow
    {
        private const string Title = "PlayerPrefs2";
        
        [MenuItem("aaaaa/PlayerPrefs2")]
        public static void ShowWindow()
        {
            GetWindow<PlayerPrefsEditor2>(Title);
        }
    }
}