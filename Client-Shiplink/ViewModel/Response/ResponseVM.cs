namespace Client_Shiplink.ViewModel.Response
{
    public class ResponseVM<Entity>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Entity Data { get; set; }
    }
}
