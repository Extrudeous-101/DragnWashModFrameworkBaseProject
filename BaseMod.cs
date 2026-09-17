using BepInEx;
using DragNWash.ModFramework;
using DragNWash.ModFramework.Text;
using UnityEngine;

namespace Extrudeous.DragnSprint 
{
    [BepInPlugin(GUID, MOD_NAME, "1.0")]
    [BepInDependency(ModFramework.Guid, BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency(GameText.Guid, BepInDependency.DependencyFlags.HardDependency)]
    public class BaseMod : BaseUnityPlugin
    {
        public const string GUID = "dragn_wash_base_project";
        public const string MOD_NAME = "Drag'n Wash Base Project";
        public const string MOD_DESCRIPTION = "Base mod description";
        public const string MOD_WEBSITE = "";
        public static readonly string[] MOD_AUTHORS = new[] { "your-name" };
        
        private void Awake()
        {
            ModFramework.Register(new ModInfo
            {
                Guid = GUID,
                DisplayName = MOD_NAME,
                Description = MOD_DESCRIPTION,
                Authors = MOD_AUTHORS,
                Website = MOD_WEBSITE
            });
        }
    }
}