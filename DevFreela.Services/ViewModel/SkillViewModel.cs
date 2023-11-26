namespace DevFreela.Services.ViewModel
{
    public class SkillViewModel
    {
        public SkillViewModel(Guid id, string decription)
        {
            Id = id;
            Decription = decription;
        }

        public Guid Id { get; set; }
        public string Decription { get; set; }
    }
}