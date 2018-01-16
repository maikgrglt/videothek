public class Customer: User{
    public int CustomerNo { get; set; }
    public IEnumerable<Video> Videos { get; set; }
}