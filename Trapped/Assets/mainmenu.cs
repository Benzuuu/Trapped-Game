
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
   public void PlayGame(){
       SceneManager.LoadScene("Prison");
   }

   public void QuitGame(){
       Application.Quit();
   }
}
