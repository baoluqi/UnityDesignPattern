using UnityEngine;
using System.Collections;

namespace SimpleFactory { 


    public class ResourceSimpleFactory {

        //1.
        public ResourceManager CreateManager(string type) {

            if (type == "UI") {

                return new UIResourceManager();
            }
            else if (type == "Audio")
            {

                return new AudioResourceManager();
            }
            else {

                return null;
            }

        }

        //2.
        public ResourceManager CreateManager(ResourceEnum re) {


            switch (re) { 
            
                case ResourceEnum.UIResource:
                    return new UIResourceManager();
                case ResourceEnum.AudioResource:
                    return new AudioResourceManager();
                default:
                    return null;
            }

        }
	
    }


    public abstract class ResourceManager {

        public abstract void LoadConfig(string path);
        public abstract void LoadAsset(string name);
        public abstract void UnLoadResource(bool status);

    }

    public enum ResourceEnum { 
    
        None,
        UIResource,
        AudioResource

    }

    public class AudioResourceManager : ResourceManager {

        public override void LoadConfig(string path)
        {
            Debug.Log("加载音乐配置文件");
        }

        public override void LoadAsset(string name)
        {
            Debug.Log("加载音乐文件");
        }

        public override void UnLoadResource(bool status)
        {
            Debug.Log("卸载音乐文件");
        }
    }

    public class UIResourceManager : ResourceManager {


        public override void LoadConfig(string path)
        {
            Debug.Log("加载UI配置文件");
        }

        public override void LoadAsset(string name)
        {
            Debug.Log("加载ui文件");
        }

        public override void UnLoadResource(bool status)
        {
            Debug.Log("卸载UI文件");
        }
    }
}