using UnityEngine;
using System.Collections;

namespace SimpleFactory
{

    public class SimpleFactoryClient : MonoBehaviour
    {
        //资源管理类的实例
        ResourceSimpleFactory rsf;

        public void Start() {

            rsf = new ResourceSimpleFactory();
        }

        public void OnGUI() {

            if (GUILayout.Button("UI管理器")) {

                ResourceManager ui = rsf.CreateManager(ResourceEnum.UIResource);
                ui.LoadConfig("http:...");
                ui.LoadAsset("Persagy");
                ui.UnLoadResource(false);

            }

            if (GUILayout.Button("Audio管理器")) {

                ResourceManager audio = rsf.CreateManager(ResourceEnum.AudioResource);
                audio.LoadConfig("http:...");
                audio.LoadAsset("PersagyAudio");
                audio.UnLoadResource(true);
                    
            }

        }

    }
}
