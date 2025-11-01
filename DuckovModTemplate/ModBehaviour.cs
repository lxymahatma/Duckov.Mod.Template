using Duckov.Modding;

namespace DuckovModTemplate;

internal class ModBehaviour : Duckov.Modding.ModBehaviour
{
    private static readonly Harmony HarmonyInstance = new("DuckovModTemplate");

    public void Awake()
    {
        HarmonyInstance.PatchAll();
    }
}