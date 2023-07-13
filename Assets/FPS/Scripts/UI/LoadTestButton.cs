using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class LoadTestButton : MonoBehaviour
    {
        public string SceneName = "";

        // Update is called once per frame
        void Update()
        {
            if (EventSystem.current.currentSelectedGameObject == gameObject)
            {
                //Debug.Log("button:" + Input.GetButtonDown(GameConstants.k_ButtonNameSubmit));
                //LoadTargetScene();
            }
    }

        public void LoadTargetScene()
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
