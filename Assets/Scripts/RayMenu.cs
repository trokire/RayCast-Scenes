using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RayMenu : MonoBehaviour
{
    public SceneManager sceneManager;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.cyan);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) == true)
            {
                var selection = hit.transform;
                if (selection.CompareTag("Cube1") || selection.CompareTag("Cube2") || selection.CompareTag("Sphere"))
                {
                    if (selection.CompareTag("Cube1"))
                    {
                        SceneManager.LoadScene("Scene1 1");
                    }
                    if (selection.CompareTag("Cube2"))
                    {
                        SceneManager.LoadScene("Scene1 2");
                    }
                    if (selection.CompareTag("Sphere"))
                    {
                        SceneManager.LoadScene("Scene1 3");
                    }
                }
            }
        }
    }
}
   