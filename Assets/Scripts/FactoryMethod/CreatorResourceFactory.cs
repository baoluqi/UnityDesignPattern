using UnityEngine;
using System.Collections;

namespace FactorMethod
{
    //工厂类
    public abstract class CreatorResourceFactory
    {

        public abstract ResourceManager CreateFactory();
    }


    //音频资源管理工厂
    public class AudioResourceManagerFactory : CreatorResourceFactory {

        public override ResourceManager CreateFactory()
        {
            return new AudioResourceManager();
        }

    }

    //UI资源管理工厂
    public class UIResourceManagerFactory : CreatorResourceFactory {

        public override ResourceManager CreateFactory()
        {
            return new UIResourceManager();
        }
    }

    public abstract class ResourceManager {

        public abstract void LoadConfig(string path);
        public abstract void LoadAsset(string name);
        public abstract void UnLoadResource(bool status);

    }


    //音频资源产品
    public class AudioResourceManager : ResourceManager
    {

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
    //ui资源产品
    public class UIResourceManager : ResourceManager
    {


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
