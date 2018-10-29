
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {

	public void LoadSceneByIndex(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}
