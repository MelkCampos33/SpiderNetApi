
namespace SpiderMissionApi.Model
{
    public class SpiderMission
    {
        public int Id { get; set; }
        public string VilaoEnfrentado { get; set; }
        public string Localizacao { get; set; }
        public int NivelPerigo  { get; set; }
        public bool Resolvido  { get; set; }
    }
}