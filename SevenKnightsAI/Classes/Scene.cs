namespace SevenKnightsAI.Classes
{
    internal class Scene
    {
        public Scene(SceneType sceneType)
        {
            SceneType = sceneType;
        }

        public SceneType SceneType
        {
            get;
            private set;
        }
    }
}