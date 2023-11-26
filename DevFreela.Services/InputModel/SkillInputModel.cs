namespace DevFreela.Services.InputModel
{
    public class SkillInputModel
    {
        public SkillInputModel(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}