/* persistent singleton 
 * this fixes the persistency problem (across scenes)
 */
using UnityEngine;

public class PersistentSingleton : MonoBehaviour {

    private readonly string Tag = "persistentSingleton";
    public static PersistentSingleton instance;

    private string yourName = "";

    public string Name
    {
        get
        {
            Debug.Log(Tag + " get name " + yourName);
            return yourName;
        }

        set
        {
            Debug.Log(Tag + " name set to " + yourName);
            yourName = value;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Destroy " + Tag + " " + gameObject.name);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Assign this " + Tag + " instance  with name " + gameObject.name);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
