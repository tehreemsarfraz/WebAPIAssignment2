namespace WebAPIAssignment2.Model
{
    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
        public char IsACTIVE { get; internal set; }
        public string UserName { get; internal set; }
    }
}

