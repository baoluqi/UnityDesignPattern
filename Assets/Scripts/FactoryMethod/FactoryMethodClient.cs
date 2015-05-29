using UnityEngine;
using System.Collections;

namespace FactorMethod
{

    public class FactoryMethodClient : MonoBehaviour
    {

        CreatorResourceFactory audioFactory;
        CreatorResourceFactory uiFactory;

        ResourceManager audioManager;
        ResourceManager uiManager;

        void Start() {

            audioFactory = new AudioResourceManagerFactory();
            uiFactory = new UIResourceManagerFactory();
        }

        void OnGUI() {

            if (GUILayout.Button("音乐资源管理器")) {

                audioManager = audioFactory.CreateFactory();
                audioManager.LoadConfig("http...");
                audioManager.LoadAsset("PersagyAudio");
                audioManager.UnLoadResource(false);

            }

            if (GUILayout.Button("界面资源管理器"))
            {

                uiManager = uiFactory.CreateFactory();
                uiManager.LoadConfig("http...");
                uiManager.LoadAsset("PersagyUI");
                uiManager.UnLoadResource(true);

            }
                
        }
        
    }

}