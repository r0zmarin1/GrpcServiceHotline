namespace GrpcServiceHotline
{
    public class NewRequest
    {
        public string model { get; set; } = "qwen3-8b";
        public Messages[] messages { get; set; }
        public double temperature { get; set; } = 0.7;
        public int max_tokens { get; set; } = -1;
        public bool stream { get; set; } = false;
    }
}
